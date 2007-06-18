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

public partial class account : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // make sure user is logged in
        if (Request.Cookies["userName"] == null)
        {
            Response.Redirect("login.aspx?ret=" + Request.Url.LocalPath);
        }

    }
    protected void btnChangePassword_Click(object sender, EventArgs e)
    {
        // make sure password textboxes are not empty
        if ((txtCurrentPassword.Text == "") || (txtNewPassword1.Text == "") || (txtNewPassword2.Text == ""))
        {
            lblPasswordMessage.Text = "Passwords cannot be blank. Please try again.";
            lblPasswordMessage.ForeColor = System.Drawing.Color.Red;
            lblPasswordMessage.Visible = true;
        }
        // make sure new passwords match
        else if (!String.Equals(txtNewPassword1.Text, txtNewPassword2.Text))
        {
            lblPasswordMessage.Text = "New passwords must match. Please try again.";
            lblPasswordMessage.ForeColor = System.Drawing.Color.Red;
            lblPasswordMessage.Visible = true;
        }
        // good to go
        else
        {
            UsersComponent users = new UsersComponent();
            BLL.User u = users.GetUserByName(Request.Cookies["userName"].Value);
            // verify current password
            if (!String.Equals(u.Password, txtCurrentPassword.Text))
            {
                lblPasswordMessage.Text = "Current Password is incorrect. Please try again.";
                lblPasswordMessage.ForeColor = System.Drawing.Color.Red;
                lblPasswordMessage.Visible = true;
            }
            // good to go; change password
            else
            {
                u.Password = txtNewPassword1.Text;
                int success = users.UpdateUser(u);
                if (success > 0)
                {
                    lblPasswordMessage.Text = "Password successfully changed.";
                    lblPasswordMessage.Visible = true; 
                }
            }
        }
    }
    protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        // get the clientId to fill the grid w/ orders
        UsersComponent users = new UsersComponent();
        BLL.User u = users.GetUserByName(Request.Cookies["userName"].Value);
        e.InputParameters["id"] = u.ClientId;
    }
    protected void Button_Command(object sender, CommandEventArgs e)
    {
        // show the details of the order number clicked in the gridview
        if (e.CommandName == "btnOrderNum")
        {
            LinkButton lb = (LinkButton)sender;
            Response.Redirect("orderdetails.aspx?id=" + lb.Text);
        }
    }

}
