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
/// Summary description for Item
/// </summary>
public class Item
{
	public Item()
	{
	}

    public Item(int id, String description, String photo, double price)
    {
        this.ID = id;
        this.Description = description;
        this.Photo = photo;
        this.Price = price;
    }

    private int _id;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }
    
    private String _description;

    public String Description
    {
        get { return _description; }
        set { _description = value; }
    }

    private String _photo;

    public String Photo
    {
        get { return _photo; }
        set { _photo = value; }
    }

    private double _price;

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }
	
}
