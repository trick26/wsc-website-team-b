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
/// Summary description for CartsComponent
/// </summary>
public class CartsComponent
{
	public CartsComponent()
	{
	}

    public List<Cart> GetCarts()
    {
        List<Cart> carts = new List<Cart>();
        DataSet ds = new DataSet();
        DataSetTableAdapters.cartsTableAdapter adapter = new DataSetTableAdapters.cartsTableAdapter();
        adapter.Fill(ds.carts);
        DataSet.cartsDataTable table = adapter.GetCartData();

        // load all carts into the list
        foreach (DataSet.cartsRow row in table.Rows)
        {
            // create memory for new cart & fill in properties
            Cart c = new Cart();
            c.UserName = row.userName;
            c.Details = row.details;
            c.CatalogId = row.catalogId;

            // add this cart to the list
            carts.Add(c);
        }
        // returns the list w/ 0 or more Carts
        return carts;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <returns>A cart if found; null if cart not found</returns>
    public Cart GetCartByUserName(String userName)
    {
        DataSet ds = new DataSet();
        DataSetTableAdapters.cartsTableAdapter adapter = new DataSetTableAdapters.cartsTableAdapter();
        adapter.Fill(ds.carts);
        Cart c = new Cart();

        // find the cart
        DataSet.cartsDataTable table = adapter.GetCartByUserName(userName);

        // if a cart was found, then fill in the details 
        if (table.Rows.Count > 0)
        {
            // use the 1st row's data
            DataSet.cartsRow row = (DataSet.cartsRow)table.Rows[0];
            c.UserName = row.userName;
            c.Details = row.details;
            c.CatalogId = row.catalogId;
            return c;
        }
        else
        {
            return null;
        }
    }

    public int UpdateCart(Cart c)
    {
        return UpdateCart(c.UserName, c.Details, c.CatalogId);
    }

    public int UpdateCart(String userName, String details, int catalogId)
    {
        DataSet ds = new DataSet();
        DataSetTableAdapters.cartsTableAdapter adapter = new DataSetTableAdapters.cartsTableAdapter();

        return adapter.Update(userName, details, catalogId, userName);
    }

    public int InsertCart(Cart c)
    {
        return InsertCart(c.UserName, c.Details, c.CatalogId);
    }

    public int InsertCart(String userName, String details, int catalogId)
    {
        DataSet ds = new DataSet();
        DataSetTableAdapters.cartsTableAdapter adapter = new DataSetTableAdapters.cartsTableAdapter();

        return adapter.Insert(userName, details, catalogId);
    }

    public int DeleteCart(Cart c)
    {
        return DeleteCart(c.UserName);
    }

    public int DeleteCart(String userName)
    {
        DataSet ds = new DataSet();
        DataSetTableAdapters.cartsTableAdapter adapter = new DataSetTableAdapters.cartsTableAdapter();

        return adapter.Delete(userName);
    }
}
