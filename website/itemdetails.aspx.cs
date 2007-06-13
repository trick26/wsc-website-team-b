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

public partial class itemdetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label lbl = (Label)FormView1.FindControl("lblDescription");
        Page.Title = "WSC :: Product Catalog :: " + lbl.Text;
    }

    protected void FormView1_ItemCommand(object sender, FormViewCommandEventArgs e)
    {
        if (e.CommandName == "AddToCart")
        {
            HiddenField h = (HiddenField)FormView1.FindControl("hiddenItemId");
            Response.Redirect("cart.aspx?item=" + h.Value);
        }
    }
}
