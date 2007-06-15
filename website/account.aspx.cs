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
}
