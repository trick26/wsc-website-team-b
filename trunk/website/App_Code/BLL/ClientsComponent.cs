using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

/// <summary>
/// Summary description for ClientsComponent
/// </summary>
public class ClientsComponent
{
	public ClientsComponent()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public List<Client> GetClients()
    {
        List<Client> clients = new List<Client>();
        DataSet ds = new DataSet();
        DataSetTableAdapters.clientsTableAdapter adapter = new DataSetTableAdapters.clientsTableAdapter();
        adapter.Fill(ds.clients);
        DataSet.clientsDataTable table = adapter.GetClientData();

        // load all clients into the list
        foreach (DataSet.clientsRow row in table.Rows)
        {
            // create memory for new client & fill in properties
            Client c = new Client();
            c.ID = row.clientId;
            c.Name = row.clientName;
            c.Address = row.clientAddress;
            c.City = row.clientCity;
            c.State = row.clientState;
            c.Zip = row.clientZip;
            c.Phone = row.clientPhone;
            c.ContactName = row.clientContactName;

            // add this client to the list
            clients.Add(c);
        }
        // returns the list w/ 0 or more Clients
        return clients;
    }

    public Client GetClientById(int id)
    {
        DataSet ds = new DataSet();
        DataSetTableAdapters.clientsTableAdapter adapter = new DataSetTableAdapters.clientsTableAdapter();
        adapter.Fill(ds.clients);
        Client c; // null!
        
        // find the client
        DataSet.clientsDataTable table = adapter.GetClientById(id);

        // if a client was found, then fill in the details 
        if (table.Rows.Count > 0)
	    {
            c = new Client();
            DataSet.clientsRow row = new DataRow();
            // use the 1st row's data
            row = table.rows[0];
            c.ID = row.clientId;
            c.Name = row.clientName;
            c.Address = row.clientAddress;
            c.City = row.clientCity;
            c.State = row.clientState;
            c.Zip = row.clientZip;
            c.Phone = row.clientPhone;
            c.ContactName = row.clientContactName;
	    }
        // returns a client if a client w/ id was found, otherwise returns null
        return c;
    }

    public int UpdateClient(Client c)
    {
        UpdateClient(c.id, c.name, c.address, c.city, c.state, c.zip, c.phone, c.contactName);
    }

    public int UpdateClient(int id, String name, String address, String city, String state, String zip, String phone, String contactName)
    {
        DataSet ds = new DataSet();
        DataSetTableAdapters.clientsTableAdapter adapter = new DataSetTableAdapters.clientsTableAdapter();

        adapter.Update(name, address, city, state, zip, phone, contactName, id);
    }

    public int InsertClient(Client c)
    {
        InsertClient(c.name, c.address, c.city, c.state, c.zip, c.phone, c.contactName);
    }

    public int InsertClient(String name, String address, String city, String state, String zip, String phone, String contactName)
    {
        DataSet ds = new DataSet();
        DataSetTableAdapters.clientsTableAdapter adapter = new DataSetTableAdapters.clientsTableAdapter();

        adapter.Insert(name, address, city, state, zip, phone, contactName);
    }

    public int DeleteClient(Client c)
    {
        DeleteClient(c.ID);
    }

    public int DeleteClient(int clientId)
    {
        DataSet ds = new DataSet();
        DataSetTableAdapters.clientsTableAdapter adapter = new DataSetTableAdapters.clientsTableAdapter();

        adapter.Delete(clientId);
    }
}
