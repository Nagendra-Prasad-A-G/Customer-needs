using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderPlaced : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelOid.Text = Session["Oid"].ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomeMain.aspx");
    }
}