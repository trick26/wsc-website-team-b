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
/// Summary description for User
/// </summary>
public class User
{
	public User()
	{
	}

    public User(String name, String password, String email, int clientId)
    {
        this.Name = name;
        this.Password = password;
        this.Email = email;
        this.ClientId = clientId;
    }

    private String _name;

    public String Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private String _password; // not encrypted!

    public String Password
    {
        get { return _password; }
        set { _password = value; }
    }

    private String _email;

    public String Email
    {
        get { return _email; }
        set { _email = value; }
    }

    private int _clientId;

    public int ClientId
    {
        get { return _clientId; }
        set { _clientId = value; }
    }
	
}
