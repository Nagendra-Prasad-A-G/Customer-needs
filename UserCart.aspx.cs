using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

public partial class UserCart : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["type"].ToString() != "User")
        {
            Response.Redirect("Login.aspx");
        }
        if (!IsPostBack)
        {
            LabelUid.Text = Session["Uid"].ToString();
            string s = "SELECT pid,productname,qty,cost,totcost,uid FROM Cart WHERE UID='" + LabelUid.Text + "' and Status='Cart'";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                float cal = 0;
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    cal += float.Parse(ds.Tables[0].Rows[j][4].ToString());
                }
                LabelPrice.Text = cal.ToString();
                GridView1.DataSource = ds;
                GridView1.DataBind();
                LabelErr.Visible = false;
                DivShow.Visible = true;
                ButtonPay.Visible = true;
            }
            else
            {
                DivShow.Visible = false;
                ButtonPay.Visible = false;
                LabelErr.Visible = true;
            }
        }
    }

    protected void ButtonPay_Click(object sender, EventArgs e)
    {
        Session["cost"] = LabelPrice.Text;
        Response.Redirect("Payment.aspx");
    }

    void Popup(bool isDisplay)
    {
        StringBuilder builder = new StringBuilder();
        if (isDisplay)
        {
            builder.Append("<script language=JavaScript> ShowPopup(); </script>\n");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "ShowPopup", builder.ToString());
        }
        else
        {
            builder.Append("<script language=JavaScript> HidePopup(); </script>\n");
            Page.ClientScript.RegisterStartupScript(this.GetType(), "HidePopup", builder.ToString());
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int calc = Convert.ToInt32(LabelP.Text) * Convert.ToInt32(TextBoxQty.Text);
        string up = "update cart set qty='" + TextBoxQty.Text + "', totcost='" + calc.ToString() + "' where pid='" + LabelFid.Text + "' and uid='" + LabelUid.Text + "'";
        SqlCommand cmd = new SqlCommand(up, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        string s = "SELECT pid,productname,qty,cost,totcost,uid FROM Cart WHERE UID='" + LabelUid.Text + "'";
        SqlDataAdapter da = new SqlDataAdapter(s, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            int cal = 0;
            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
            {
                cal += Convert.ToInt32(ds.Tables[0].Rows[j][2].ToString()) * Convert.ToInt32(ds.Tables[0].Rows[j][3].ToString());
            }
            LabelPrice.Text = cal.ToString();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ShowPopup")
        {
            string i = Convert.ToString(e.CommandArgument.ToString());
            string s = "SELECT pid,productname,qty,cost,totcost,uid FROM Cart WHERE pid='" + i + "' and UID='" + LabelUid.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            LabelItemName.Text = ds.Tables[0].Rows[0][1].ToString();
            TextBoxQty.Text = ds.Tables[0].Rows[0][2].ToString();
            LabelP.Text = ds.Tables[0].Rows[0][3].ToString();
            LabelFid.Text = ds.Tables[0].Rows[0][0].ToString();
            Popup(true);
        }
        else if (e.CommandName == "Delete")
        {
            string i = Convert.ToString(e.CommandArgument.ToString());
            string del = "delete from cart where pid='" + i + "' and uid='" + LabelUid.Text + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("UserCart.aspx");
        }
    }

    protected void ButtonClose_Click(object sender, EventArgs e)
    {
        Popup(false);
    }
}