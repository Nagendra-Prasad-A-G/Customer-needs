using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewProduct : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConsumerConnect"].ConnectionString);
    int count12 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LabelUid.Text = Session["Uid"].ToString();
            LabelCategory.Text = Request.QueryString["Category"];
            LabelSubCategory.Text = Request.QueryString["SubCategory"];
            ButtonNxt.Visible = false;
            ButtonPrev.Visible = false;

            int count = 0;
            string s1 = ImageFiller1(0, count + 0);

            ImageButton1.ImageUrl = s1;
            if (s1 == "")
            {
                ImageButton1.Visible = false;
                Button1.Visible = false;
                lblp1.Visible = false;
                //Label1.Visible = false;

            }

            string s2 = ImageFiller1(1, count + 1);
            ImageButton2.ImageUrl = s2;
            if (s2 == "")
            {
                ImageButton2.Visible = false;
                Button2.Visible = false;
                lblp2.Visible = false;
                //Label2.Visible = false;
            }

            string s3 = ImageFiller1(2, count + 2);
            ImageButton3.ImageUrl = s3;
            if (s3 == "")
            {
                ImageButton3.Visible = false;
                Button3.Visible = false;
                //Label3.Visible = false;
                lblp3.Visible = false;

            }


            string s4 = ImageFiller1(3, count + 3);
            ImageButton4.ImageUrl = s4;
            if (s4 == "")
            {
                ImageButton4.Visible = false;
                Button4.Visible = false;
                lblp4.Visible = false;
                // Label4.Visible = false;

            }


            string s5 = ImageFiller1(4, count + 4);
            ImageButton5.ImageUrl = s5;
            if (s5 == "")
            {
                ImageButton5.Visible = false;
                Button5.Visible = false;
                lblp5.Visible = false;
                //Label5.Visible = false;

            }


            string s6 = ImageFiller1(5, count + 5);
            ImageButton6.ImageUrl = s6;

            if (s6 == "")
            {
                ImageButton6.Visible = false;
                Button6.Visible = false;
                lblp6.Visible = false;
                // Label6.Visible = false;
            }

            string s7 = ImageFiller1(6, count + 6);
            ImageButton7.ImageUrl = s7;
            if (s7 == "")
            {
                ImageButton7.Visible = false;
                Button7.Visible = false;
                lblp7.Visible = false;
                //Label7.Visible = false;

            }
            string s8 = ImageFiller1(7, count + 7);
            ImageButton8.ImageUrl = s8;
            if (s8 == "")
            {
                ImageButton8.Visible = false;
                Button8.Visible = false;
                lblp8.Visible = false;
                // Label8.Visible = false;

            }
            string s9 = ImageFiller1(8, count + 8);
            ImageButton9.ImageUrl = s9;
            if (s9 == "")
            {
                ImageButton9.Visible = false;
                Button9.Visible = false;
                lblp9.Visible = false;
                // Label8.Visible = false;

            }

            string s10 = ImageFiller1(9, count + 9);
            ImageButton10.ImageUrl = s10;
            if (s10 == "")
            {
                ImageButton10.Visible = false;
                Button10.Visible = false;
                lblp10.Visible = false;
                //Label8.Visible = false;

            }

            string s11 = ImageFiller1(10, count + 10);
            ImageButton11.ImageUrl = s11;
            if (s11 == "")
            {
                ImageButton11.Visible = false;
                Button11.Visible = false;
                lblp11.Visible = false;
                // Label8.Visible = false;

            }

            string s12 = ImageFiller1(11, count + 11);
            ImageButton12.ImageUrl = s12;
            if (s12 == "")
            {
                ImageButton12.Visible = false;
                Button12.Visible = false;
                lblp12.Visible = false;
                //Label8.Visible = false;

            }

            string ins = "insert into hits(category,subcategory,date,uid) values ('" + LabelCategory.Text + "','" + LabelSubCategory.Text + "','" + System.DateTime.Now.ToString("yyyy/MM/dd") + "','" + LabelUid.Text + "')";
            SqlCommand cmd = new SqlCommand(ins,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    protected String ImageFiller1(int i, int count)
    {

        string s0 = " ";
        string s1 = "";
        SqlDataAdapter sda;
        DataSet ds = new DataSet();

        s1 = "select pid,productname,cost,description,stock,image from product where subcategory='"+ LabelSubCategory.Text + "'";
        sda = new SqlDataAdapter(s1, con);
        ds = new DataSet();
        sda.Fill(ds);
        count12 = ds.Tables[0].Rows.Count;

        if (count12 != 1)
        {
            if (ds.Tables[0].Rows.Count > 12)
            {
                ButtonNxt.Visible = true;
            }
            else
            {
                ButtonNxt.Visible = false;
            }
        }
        try
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                LabelErr.Visible = false;
                if (ds.Tables[0].Rows[0][0] != null)
                {

                    if (count == 0)
                    {
                        lblp1.Text = Convert.ToString(ds.Tables[0].Rows[0][0]);
                        LabelPName1.Text = Convert.ToString(ds.Tables[0].Rows[0][1]);
                        Label1.Text = Convert.ToString(ds.Tables[0].Rows[0][2]);
                        LabelDesc1.Text = Convert.ToString(ds.Tables[0].Rows[0][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[0][5]);

                        ImageButton1.Visible = true;
                        Button1.Visible = true;
                        LabelPName1.Visible = true;
                        Label1.Visible = true;
                        LabelDesc1.Visible = true;
                    }
                }

                if (ds.Tables[0].Rows[1][0] != null)
                {
                    if (count == 1)
                    {
                        lblp2.Text = Convert.ToString(ds.Tables[0].Rows[1][0]);
                        LabelPName2.Text = Convert.ToString(ds.Tables[0].Rows[1][1]);
                        Label2.Text = Convert.ToString(ds.Tables[0].Rows[1][2]);
                        LabelDesc2.Text = Convert.ToString(ds.Tables[0].Rows[1][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[1][5]);

                        ImageButton2.Visible = true;
                        Button2.Visible = true;
                        LabelPName2.Visible = true;
                        Label2.Visible = true;
                        LabelDesc2.Visible = true;
                    }
                }

                if (ds.Tables[0].Rows[2][0] != null)
                {
                    if (count == 2)
                    {
                        lblp3.Text = Convert.ToString(ds.Tables[0].Rows[2][0]);
                        LabelPName3.Text = Convert.ToString(ds.Tables[0].Rows[2][1]);
                        Label3.Text = Convert.ToString(ds.Tables[0].Rows[2][2]);
                        LabelDesc3.Text = Convert.ToString(ds.Tables[0].Rows[2][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[2][5]);

                        ImageButton3.Visible = true;
                        Button3.Visible = true;
                        LabelPName3.Visible = true;
                        Label3.Visible = true;
                        LabelDesc3.Visible = true;
                    }
                }
                if (ds.Tables[0].Rows[3][0] != null)
                {
                    if (count == 3)
                    {
                        lblp4.Text = Convert.ToString(ds.Tables[0].Rows[3][0]);
                        LabelPName4.Text = Convert.ToString(ds.Tables[0].Rows[3][1]);
                        Label4.Text = Convert.ToString(ds.Tables[0].Rows[3][2]);
                        LabelDesc4.Text = Convert.ToString(ds.Tables[0].Rows[3][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[3][5]);

                        ImageButton4.Visible = true;
                        Button4.Visible = true;
                        LabelPName4.Visible = true;
                        Label4.Visible = true;
                        LabelDesc4.Visible = true;
                    }
                }
                if (ds.Tables[0].Rows[4][0] != null)
                {
                    if (count == 4)
                    {
                        lblp5.Text = Convert.ToString(ds.Tables[0].Rows[4][0]);
                        LabelPName5.Text = Convert.ToString(ds.Tables[0].Rows[4][1]);
                        Label5.Text = Convert.ToString(ds.Tables[0].Rows[4][2]);
                        LabelDesc5.Text = Convert.ToString(ds.Tables[0].Rows[4][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[4][5]);

                        ImageButton5.Visible = true;
                        Button5.Visible = true;
                        LabelPName5.Visible = true;
                        Label5.Visible = true;
                        LabelDesc5.Visible = true;
                    }
                }

                if (ds.Tables[0].Rows[5][0] != null)
                {
                    if (count == 5)
                    {
                        lblp6.Text = Convert.ToString(ds.Tables[0].Rows[5][0]);
                        LabelPName6.Text = Convert.ToString(ds.Tables[0].Rows[5][1]);
                        Label6.Text = Convert.ToString(ds.Tables[0].Rows[5][2]);
                        LabelDesc6.Text = Convert.ToString(ds.Tables[0].Rows[5][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[5][5]);

                        ImageButton6.Visible = true;
                        Button6.Visible = true;
                        LabelPName6.Visible = true;
                        Label6.Visible = true;
                        LabelDesc6.Visible = true;
                    }
                }

                if (ds.Tables[0].Rows[6][0] != null)
                {
                    if (count == 6)
                    {
                        lblp7.Text = Convert.ToString(ds.Tables[0].Rows[6][0]);
                        LabelPName7.Text = Convert.ToString(ds.Tables[0].Rows[6][1]);
                        Label7.Text = Convert.ToString(ds.Tables[0].Rows[6][2]);
                        LabelDesc7.Text = Convert.ToString(ds.Tables[0].Rows[6][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[6][5]);

                        ImageButton7.Visible = true;
                        Button7.Visible = true;
                        LabelPName7.Visible = true;
                        Label7.Visible = true;
                        LabelDesc7.Visible = true;
                    }
                }

                if (ds.Tables[0].Rows[7][0] != null)
                {
                    if (count == 7)
                    {
                        lblp8.Text = Convert.ToString(ds.Tables[0].Rows[7][0]);
                        LabelPName8.Text = Convert.ToString(ds.Tables[0].Rows[7][1]);
                        Label8.Text = Convert.ToString(ds.Tables[0].Rows[7][2]);
                        LabelDesc8.Text = Convert.ToString(ds.Tables[0].Rows[7][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[7][5]);

                        ImageButton8.Visible = true;
                        Button8.Visible = true;
                        LabelPName8.Visible = true;
                        Label8.Visible = true;
                        LabelDesc8.Visible = true;
                    }
                }

                if (ds.Tables[0].Rows[8][0] != null)
                {
                    if (count == 8)
                    {
                        lblp9.Text = Convert.ToString(ds.Tables[0].Rows[8][0]);
                        LabelPName9.Text = Convert.ToString(ds.Tables[0].Rows[8][1]);
                        Label9.Text = Convert.ToString(ds.Tables[0].Rows[8][2]);
                        LabelDesc9.Text = Convert.ToString(ds.Tables[0].Rows[8][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[8][5]);

                        ImageButton9.Visible = true;
                        Button9.Visible = true;
                        LabelPName9.Visible = true;
                        Label9.Visible = true;
                        LabelDesc9.Visible = true;
                    }
                }

                if (ds.Tables[0].Rows[9][0] != null)
                {
                    if (count == 9)
                    {
                        lblp10.Text = Convert.ToString(ds.Tables[0].Rows[9][0]);
                        LabelPName10.Text = Convert.ToString(ds.Tables[0].Rows[9][1]);
                        Label10.Text = Convert.ToString(ds.Tables[0].Rows[9][2]);
                        LabelDesc10.Text = Convert.ToString(ds.Tables[0].Rows[9][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[9][5]);

                        ImageButton10.Visible = true;
                        Button10.Visible = true;
                        LabelPName10.Visible = true;
                        Label10.Visible = true;
                        LabelDesc10.Visible = true;
                    }
                }

                if (ds.Tables[0].Rows[10][0] != null)
                {
                    if (count == 10)
                    {
                        lblp11.Text = Convert.ToString(ds.Tables[0].Rows[10][0]);
                        LabelPName11.Text = Convert.ToString(ds.Tables[0].Rows[10][1]);
                        Label11.Text = Convert.ToString(ds.Tables[0].Rows[10][2]);
                        LabelDesc11.Text = Convert.ToString(ds.Tables[0].Rows[10][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[10][5]);

                        ImageButton11.Visible = true;
                        Button11.Visible = true;
                        LabelPName11.Visible = true;
                        Label11.Visible = true;
                        LabelDesc11.Visible = true;
                    }
                }

                if (ds.Tables[0].Rows[11][0] != null)
                {
                    if (count == 11)
                    {
                        lblp12.Text = Convert.ToString(ds.Tables[0].Rows[11][0]);
                        LabelPName12.Text = Convert.ToString(ds.Tables[0].Rows[11][1]);
                        Label12.Text = Convert.ToString(ds.Tables[0].Rows[11][2]);
                        LabelDesc12.Text = Convert.ToString(ds.Tables[0].Rows[11][3]);
                        s1 = Convert.ToString(ds.Tables[0].Rows[11][5]);

                        ImageButton12.Visible = true;
                        Button12.Visible = true;
                        LabelPName12.Visible = true;
                        Label12.Visible = true;
                        LabelDesc12.Visible = true;
                    }
                }
            }
            else
            {
                LabelErr.Visible = true;
            }
            return s1;
        }
        catch (Exception e)
        {
            return s1;
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp1.Text + "");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp1.Text + "");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp2.Text + "");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp2.Text + "");
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp3.Text + "");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp3.Text + "");
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp4.Text + "");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp4.Text + "");
    }

    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp5.Text + "");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp5.Text + "");
    }

    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp6.Text + "");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp6.Text + "");
    }

    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp7.Text + "");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp7.Text + "");
    }

    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp8.Text + "");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp8.Text + "");
    }

    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp9.Text + "");
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp9.Text + "");
    }

    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp10.Text + "");
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp10.Text + "");
    }

    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp11.Text + "");
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp11.Text + "");
    }

    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp12.Text + "");
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        Session["uid"] = LabelUid.Text;
        Response.Redirect("ProductDetails.aspx?Pid=" + lblp12.Text + "");
    }
}