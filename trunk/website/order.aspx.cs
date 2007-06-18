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

public partial class order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // make sure user is logged in
        if (Request.Cookies["userName"] == null)
        {
            Response.Redirect("login.aspx?ret=order.aspx");
        }

        if (!IsPostBack)
        {
            // get the cart
            CartsComponent cComp = new CartsComponent();
            Cart c = cComp.GetCartByUserName(Request.Cookies["userName"].Value);

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
        }
    }
    protected void btnOrder_Click(object sender, EventArgs e)
    {
        // validate payment info
        if (ValidatePayment())
        {
            // get the cart
            CartsComponent cComp = new CartsComponent();
            Cart c = cComp.GetCartByUserName(Request.Cookies["userName"].Value);

            // get the user
            UsersComponent users = new UsersComponent();
            BLL.User u = users.GetUserByName(Request.Cookies["userName"].Value);

            // get the catalog
            CatalogComponent catalog = new CatalogComponent();
            Item it = catalog.GetItemById(c.CatalogId);

            // create a payment
            PaymentsComponent pmts = new PaymentsComponent();
            Payment pmt = new Payment();
            pmt.CardholderName = txtName.Text;
            pmt.CardNumber = txtNumber.Text;
            pmt.CardType = ddlType.SelectedValue;
            // make expiration date
            int month = Convert.ToInt32(ddlMonth.SelectedValue);
            int year = Convert.ToInt32(ddlYear.SelectedValue);
            int day = DateTime.DaysInMonth(year, month);
            DateTime dt = Convert.ToDateTime(month + "-" + day + "-" + year);
            pmt.CardExpiration = dt;
            // save the payment
            int pmtId = pmts.InsertPayment(pmt);

            // create the order
            OrdersComponent orders = new OrdersComponent();
            Order o = new Order();
            o.CatalogId = c.CatalogId;
            o.ClientId = u.ClientId;
            o.Details = c.Details;
            o.PaymentId = pmtId;
            o.Price = it.Price;
            o.OrderDate = DateTime.Now;
            // save the order
            int orderId = orders.InsertOrder(o);

            // delete the cart
            cComp.DeleteCart(c);
            
            // display results to user
            lblOrderNum.Text = Convert.ToString(orderId);
            pnlCC.Visible = false;
            pnlSuccess.Visible = true;
            pnlTopLabels.Visible = false;
        }
    }

    private bool ValidatePayment()
    {
        // this *only* verifies that the textboxes and dropdownlists are not blank!
        // a real-world application would also test for proper input types, 
        // like numbers only at the proper length for credit card data
        bool valid = true;
        if (txtName.Text == "")
        {
            valid = false;
            lblError.Text = "The credit card 'name' field cannot be blank!";
        }
        else if (ddlType.SelectedValue == "")
        {
            valid = false;
            lblError.Text = "The credit card 'type' field must have a valid selection!";
        }
        else if (txtNumber.Text == "")
        {
            valid = false;
            lblError.Text = "The credit card 'number' field cannot be blank!";
        }
        else if (ddlMonth.SelectedValue == "")
        {
            valid = false;
            lblError.Text = "The credit card 'month' field is not valid!";
        }
        else if (ddlYear.SelectedIndex == 0)
        {
            valid = false;
            lblError.Text = "The credit card 'year' field is not valid!";
        }
        if (!valid)
        {
            lblError.Visible = true;
        }
        return valid;
    }
}
