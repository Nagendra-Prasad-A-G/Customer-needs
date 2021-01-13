using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Payment : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label6.Text = (string)Session["cost"];
            LabelUid.Text = Session["Uid"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string pname = "";
        string pid = "";
        string qty = "";

        SqlDataAdapter da;
        DataSet ds;
        string sel = "";
        string oid = "";
        sel = "SELECT CAST(Oid AS int) AS Expr1 FROM Orders ORDER BY Expr1 desc";
        da = new SqlDataAdapter(sel, con);
        ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count == 0)
        {
            oid = "1";
        }
        else
        {
            string s = ds.Tables[0].Rows[0][0].ToString();
            int s1 = Convert.ToInt32(s) + 1;
            oid = s1.ToString();
        }

        if (Session["BuyNow"] != "Data")
        {
            sel = "select pid,productname,qty from cart where uid='" + LabelUid.Text + "'";
            da = new SqlDataAdapter(sel, con);
            ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    pid = ds.Tables[0].Rows[i][0].ToString();
                    pname = ds.Tables[0].Rows[i][1].ToString();
                    qty = ds.Tables[0].Rows[i][2].ToString();

                    string sql2 = "insert into orders(Oid,Productname,pid,qty,cost,uid,date,time,status) values('" + oid + "','" + pname + "','" + pid + "','" + qty + "','" + Label6.Text + "','" + LabelUid.Text + "','" + System.DateTime.Now.ToString("yyyy/MM/dd") + "','" + System.DateTime.Now.ToString("HH:mm") + "','Payment Success')";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        else
        {
            pname = Session["pname"].ToString();
            pid = Session["pid"].ToString();
            string sql2 = "insert into orders(Oid,Productname,pid,qty,cost,uid,date,time,status) values('" + oid + "','" + pname + "','" + pid + "','1','" + Label6.Text + "','" + LabelUid.Text + "','" + System.DateTime.Now.ToString("yyyy/MM/dd") + "','" + System.DateTime.Now.ToString("HH:mm") + "','Payment Success')";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
        }
        

        string sql1 = "insert into payment values('" + T1.Text + "','" + T2.Text + "','" + T3.Text + "','" + T4.Text + "')";
        SqlCommand cmd = new SqlCommand(sql1, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        

        string del = "delete from cart where uid='" + Session["Uid"].ToString() + "'";
        cmd = new SqlCommand(del, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Session["Oid"] = oid;
        Response.Redirect("OrderPlaced.aspx");
    }
}