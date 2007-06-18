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
            String extra = "";            
            if (Request.QueryString["item"] != null)
            {
                extra = "&item=" + Request.QueryString["item"];
            }
            Response.Redirect("login.aspx?ret=cart.aspx" + extra);
        }

        if (!IsPostBack) // don't reload controls/data if not necessary
        {
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
                SetVisibility(true);
            }
            else
            {
                // show 'cart empty'
                SetVisibility(false);
            } 
        }
    }
    protected void btnOrder_Click(object sender, EventArgs e)
    {
        // save the cart first
        SaveCart();
        Response.Redirect("order.aspx");
    }

    private void SetVisibility(bool show)
    {
        imgThumbPhoto.Visible = show;
        lblDescription.Visible = show;
        lblItemPrice.Visible = show;
        txtDetails.ReadOnly = !show;
        btnOrder.Visible = show;
        btnSaveCart.Visible = show;
        btnEmptyCart.Visible = show;
        lblEmptyCart.Visible = !show;
    }
    protected void btnSaveCart_Click(object sender, EventArgs e)
    {
        // save the ordering info to the cart as well
        SaveCart();
        Response.Redirect("cart.aspx");
    }
    protected void btnEmptyCart_Click(object sender, EventArgs e)
    {
        // delete this user's cart
        CartsComponent cComp = new CartsComponent();
        cComp.DeleteCart(Request.Cookies["userName"].Value);
        String str = txtDetails.Text;
        
        Response.Redirect("cart.aspx");
    }
    private void SaveCart()
    {
        CartsComponent cComp = new CartsComponent();
        Cart c = cComp.GetCartByUserName(Request.Cookies["userName"].Value);
        c.Details = txtDetails.Text;
        cComp.UpdateCart(c);
    }
}
