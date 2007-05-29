using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Client
/// </summary>
public class Client
{
    DataSet dataSet = new DataSet();
    DataSet.clientsRow theClient;
    
    public Client()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public int ClientId
    {
        get { return theClient.clientId; }
    }

    public void LoadClientById(int clientId)
    {
        theClient = dataSet.clients.FindByclientId(clientId);
    }

    public String ClientName
    {
        get { return theClient.clientName; }
        set { theClient.clientName = value; }
    }

    public String ClientAddress
    {
        get { return theClient.clientAddress; }
        set { theClient.clientAddress = value; }
    }
	
    public String ClientCity
    {
        get { return theClient.clientCity; }
        set { theClient.clientCity = value; }
    }

    public String ClientState
    {
        get { return theClient.clientState; }
        set { theClient.clientState = value; }
    }

    public String ClientZip
    {
        get { return theClient.clientZip; }
        set { theClient.clientZip = value; }
    }

    public String ClientPhone
    {
        get { return theClient.clientPhone; }
        set { theClient.clientPhone = value; }
    }

    public String ClientContactName
    {
        get { return theClient.clientContactName; }
        set { theClient.clientContactName = value; }
    }
}
