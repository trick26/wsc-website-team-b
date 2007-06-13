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

namespace BLL
{
    /// <summary>
    /// Summary description for ClientsComponent
    /// </summary>
    public class ClientsComponent
    {
        public ClientsComponent()
        {
        }

        /// <summary>
        /// Gets all clients from database
        /// </summary>
        /// <returns>List Generic Class</returns>
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

        /// <summary>
        /// Get a single client from the database
        /// </summary>
        /// <param name="id">The ID of the client to find</param>
        /// <returns>a Client if found; null if client not found</returns>
        public Client GetClientById(int id)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.clientsTableAdapter adapter = new DataSetTableAdapters.clientsTableAdapter();
            adapter.Fill(ds.clients);
            Client c = new Client();

            // find the client
            DataSet.clientsDataTable table = adapter.GetClientById(id);

            // if a client was found, then fill in the details 
            if (table.Rows.Count > 0)
            {
                // use the 1st row's data
                DataSet.clientsRow row = (DataSet.clientsRow)table.Rows[0];
                c.ID = row.clientId;
                c.Name = row.clientName;
                c.Address = row.clientAddress;
                c.City = row.clientCity;
                c.State = row.clientState;
                c.Zip = row.clientZip;
                c.Phone = row.clientPhone;
                c.ContactName = row.clientContactName;
                return c;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Update a client to the database
        /// </summary>
        /// <param name="c">a client</param>
        /// <returns># of rows affected</returns>
        public int UpdateClient(Client c)
        {
            return UpdateClient(c.ID, c.Name, c.Address, c.City, c.State, c.Zip, c.Phone, c.ContactName);
        }

        /// <summary>
        /// Update a client to the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phone"></param>
        /// <param name="contactName"></param>
        /// <returns># of rows affected</returns>
        public int UpdateClient(int id, String name, String address, String city, String state, String zip, String phone, String contactName)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.clientsTableAdapter adapter = new DataSetTableAdapters.clientsTableAdapter();

            return adapter.Update(name, address, city, state, zip, phone, contactName, id);
        }

        /// <summary>
        /// Insert a new client into the database
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int InsertClient(Client c)
        {
            return InsertClient(c.Name, c.Address, c.City, c.State, c.Zip, c.Phone, c.ContactName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phone"></param>
        /// <param name="contactName"></param>
        /// <returns></returns>
        public int InsertClient(String name, String address, String city, String state, String zip, String phone, String contactName)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.clientsTableAdapter adapter = new DataSetTableAdapters.clientsTableAdapter();

            return adapter.Insert(name, address, city, state, zip, phone, contactName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int DeleteClient(Client c)
        {
            return DeleteClient(c.ID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public int DeleteClient(int clientId)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.clientsTableAdapter adapter = new DataSetTableAdapters.clientsTableAdapter();

            return adapter.Delete(clientId);
        }
    }
}