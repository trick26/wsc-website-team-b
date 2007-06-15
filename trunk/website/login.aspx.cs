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

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // hide error messages
        lblNotValid.Visible = false;
        lblEmptyTextBox.Visible = false;

        // verify username & password textboxes are not empty
        if ((txtUserName.Text == "") || (txtPassword.Text == ""))
        {
            // either username or password textbox was empty
            lblEmptyTextBox.Visible = true;
        }
        else
        {
            // validate username/password
            UsersComponent users = new UsersComponent();
            BLL.User user = users.ValidateLogin(txtUserName.Text, txtPassword.Text);

            if (user != null) // a null user means the username/password combination was not in the DB
            {
                // set the cookie to remember user for 2 hours
                Response.Cookies["userName"].Value = user.Name;
                Response.Cookies["userName"].Expires = DateTime.Now.AddHours(2);
                // send browser back to previous page
                if (Request.Params["ret"] != null)
                {
                    String qStr = Request.QueryString["ret"];
                    // we must re-assemble the query string
                    if (Request.QueryString.Count > 1)
                        qStr += "?";
                    for (int i = 1; i < Request.QueryString.Count; i++)
			        {
                        qStr += Request.QueryString.GetKey(i) + "=" + Request.QueryString.Get(i) + "&";
                    }
                    qStr = qStr.TrimEnd('&');
                    Response.Redirect(qStr);
                }
                else
                {
                    Response.Redirect("default.aspx");
                }
            }
            else
            {
                // credentials are not valid
                lblNotValid.Visible = true;
            }
        }
    }
}
