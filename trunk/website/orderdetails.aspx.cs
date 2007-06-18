using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;

public partial class orderdetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // make sure user is logged in
        if (Request.Cookies["userName"] == null)
        {
            Response.Redirect("login.aspx?ret=" + Request.Url.LocalPath);
        }

        if (Request.Params["id"] != null)
        {
            // get the orderId
            int id = Convert.ToInt32(Request.Params["id"]);
            
            // load order info
            OrdersComponent orders = new OrdersComponent();
            Order o = orders.GetOrderById(id);

            // load catalog item info
            CatalogComponent cat = new CatalogComponent();
            BLL.Item it = cat.GetItemById(o.CatalogId);

            // fill the controls
            lblOrderNum.Text = Convert.ToString(o.ID);
            lblDate.Text = Convert.ToString(o.OrderDate);
            imgThumbPhoto.ImageUrl = it.ThumbPhoto;
            btnDescription.Text = it.Description;
            btnDescription.PostBackUrl = "itemdetails.aspx?item=" + o.CatalogId;
            lblItemPrice.Text = "$" + Convert.ToString(o.Price);
            lblTotalPrice.Text = lblItemPrice.Text;
            txtDetails.Text = o.Details;

            // update the page title
            Page.Title = "WSC :: Order Details for order #" + Convert.ToString(o.ID);
        }

        
    }
}
