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

public partial class Master1 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblWelcome.Visible = false;
        
        // find out if a cookie is already set
        if (Request.Cookies["userName"] != null)
        {
            Response.Cookies.Set(Request.Cookies["userName"]);
            // update display to let user know they're logged in
            lblWelcome.Text = "Welcome " + Server.HtmlEncode(Request.Cookies["userName"].Value) + "!";
            lblWelcome.Visible = true;
            btnLogin.Text = "Logout";
        }
        else
        {
            // no cookie set!
            btnLogin.Text = "Login";
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (String.Equals(btnLogin.Text, "Logout"))
        {
            // delete the cookie by making it expired
            Response.Cookies["userName"].Expires = DateTime.Now.AddYears(-30);
            // update display so user knows they're not logged in
            btnLogin.Text = "Login";
            lblWelcome.Visible = false;
            //Response.Redirect(Request.Url.AbsolutePath);
        }
        else
        {
            // user is trying to login
            Response.Redirect("login.aspx?ret=" + Request.Url.LocalPath);
        }
    }
}
