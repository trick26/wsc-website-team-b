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

public partial class cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // make sure user is logged in
        if (Request.Cookies["userName"] == null)
        {
            Response.Redirect("login.aspx?ret=" + Request.Url.LocalPath);
        }

        CartsComponent cComp = new CartsComponent();
        Cart c = cComp.GetCartByUserName(Request.Cookies["userName"].Value);

        // is user creating a new cart?
        if (Request.Params["item"] != null)
        {
            //CartsComponent cComp = new CartsComponent();
            //Cart c = cComp.GetCartByUserName(Request.Cookies["userName"].Value);
            
            // if a cart is already in database, then delete it
            if (c != null)
            {
                cComp.DeleteCart(c);
            }

            // now, add item to cart
            c = new Cart();
            c.UserName = Request.Cookies["userName"].Value;
            c.CatalogId = Convert.ToInt32(Request.Params["item"]);
            cComp.InsertCart(c);
        }
        
        // show user's cart, if any
        if (c != null)
        {
            // get the item's info
            CatalogComponent catalog = new CatalogComponent();
            Item it = catalog.GetItemById(c.CatalogId);
            // display the catalog item
            imgThumbPhoto.ImageUrl = it.ThumbPhoto;
            lblDescription.Text = it.Description;
            lblItemPrice.Text = "$" + Convert.ToString(it.Price);
            txtDetails.Text = c.Details;
            // since our cart only can contain 1 item, just use the item's price for total price
            lblTotalPrice.Text = lblItemPrice.Text;

            // show cart contents
            setVisibility(true);
        }
        else
        {
            // show 'cart empty'
            setVisibility(false);
        }
    }
    protected void btnOrder_Click(object sender, EventArgs e)
    {
        //
    }

    private void setVisibility(bool show)
    {
        imgThumbPhoto.Visible = show;
        lblDescription.Visible = show;
        lblItemPrice.Visible = show;
        txtDetails.Enabled = show;
        btnOrder.Enabled = show;
        lblEmptyCart.Visible = !show;
    }
    protected void btnSaveCart_Click(object sender, EventArgs e)
    {
        // save the ordering info to the cart as well
        CartsComponent cComp = new CartsComponent();
        Cart c = cComp.GetCartByUserName(Request.Cookies["userName"].Value);
        c.Details = txtDetails.Text;
    }
}
