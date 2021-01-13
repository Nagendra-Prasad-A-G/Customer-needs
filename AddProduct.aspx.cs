using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class AddProduct : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Add"] == "Data")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Product Details added')", true);
            Session["Add"] = "";
        }
        if (!IsPostBack)
        {
            string str1 = "SELECT CAST(pid AS int) AS Expr1 FROM product ORDER BY Expr1 desc";
            SqlDataAdapter da1 = new SqlDataAdapter(str1, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            if (ds1.Tables[0].Rows.Count == 0)
            {
                TextBoxPid.Text = "1";
            }
            else
            {
                string s = ds1.Tables[0].Rows[0][0].ToString();
                int s1 = Convert.ToInt32(s) + 1;
                TextBoxPid.Text = s1.ToString();
            }

            str1 = "select DISTINCT category from category";
            da1 = new SqlDataAdapter(str1, con);
            ds1 = new DataSet();
            da1.Fill(ds1);
            if (ds1.Tables[0].Rows.Count > 0)
            {
                DropDownListCategory.Items.Add("--Select--");
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    string val = ds1.Tables[0].Rows[i][0].ToString();
                    DropDownListCategory.Items.Add(val);
                }
            }
        }
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        string s = "insert into product values('" + TextBoxPid.Text + "','" + TextBoxName.Text + "','" + TextBoxCost.Text + "','" + DropDownListCategory.Text + "','" + DropDownListSubCategory.Text + "','" + TextBoxDesc.Text + "','" + TextBoxStock.Text + "','" + Image1.ImageUrl + "')";
        SqlCommand cmd = new SqlCommand(s, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Session["Add"] = "Data";
        Response.Redirect("AddProduct.aspx");
    }

    protected void ButtonUpload_Click(object sender, EventArgs e)
    {
        String image, path;
        try
        {
            image = FileUpload1.FileName;
            path = Server.MapPath("~\\images\\Products\\");
            FileUpload1.SaveAs(path + image);
            Image1.ImageUrl = "images\\Products\\" + image;
            Image1.Visible = true;
        }
        catch (Exception ep)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Kindly upload a photo');", true);
            Image1.Visible = false;
        }
        
    }

    protected void DropDownListCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownListCategory.Text != "--Select--")
        {
            string str1 = "select DISTINCT subcategory from category where category='" + DropDownListCategory.Text + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(str1, con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            if (ds1.Tables[0].Rows.Count > 0)
            {
                DropDownListSubCategory.Items.Clear();
                DropDownListSubCategory.Visible = true;
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    string val = ds1.Tables[0].Rows[i][0].ToString();
                    DropDownListSubCategory.Items.Add(val);
                }
            }
        }
        else
        {
            DropDownListSubCategory.Visible = false;
        }
    }
}