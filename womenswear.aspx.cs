using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class womenswear : System.Web.UI.Page
{
    int total1, total2, total3;
    private object dt2;

    DataTable dt1 = new DataTable();
    private void gridVIEWData()
    {

        dt1.Columns.Add("productID", typeof(int));
        dt1.Columns.Add("qty", typeof(int));
        dt1.Columns.Add("price", typeof(int));
        dt1.Columns.Add("size", typeof(string));
        dt1.Columns.Add("totalprice", typeof(int));
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            gridVIEWData();
            GridView1.DataSource = dt1;
            GridView1.DataBind();
            Session["dt1"] = dt1;
        }

    }

    protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton16 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label45.Text;
            dr["price"] = Label21.Text;
            dr["qty"] = DropDownList1.SelectedItem.Text;
            dr["size"] = DropDownList9.SelectedItem.Text;
             total1 = Convert.ToInt32(DropDownList1.SelectedItem.Text) * Convert.ToInt32(Label21.Text);
            dr["totalprice"] = total1;



            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }
    }

    protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
    {

        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton16 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label46.Text;
            dr["price"] = Label44.Text;
            dr["qty"] = DropDownList2.SelectedItem.Text;
            dr["size"] = DropDownList10.SelectedItem.Text;
            Int32 total2 = Convert.ToInt32(DropDownList2.SelectedItem.Text) * Convert.ToInt32(Label44.Text);
            dr["totalprice"] = total2;



            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }
    }

    protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
    {

        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton16 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label47.Text;
            dr["price"] = Label23.Text;
            dr["qty"] = DropDownList3.SelectedItem.Text;
            dr["size"] = DropDownList11.SelectedItem.Text;
            Int32 total3 = Convert.ToInt32(DropDownList3.SelectedItem.Text) * Convert.ToInt32(Label23.Text);
            dr["totalprice"] = total3;


            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();

           // Label49.Text = (total1 + total2 + total3).ToString();
        }
    }



    protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
    {

        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton25 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label49.Text;
            dr["price"] = Label50.Text;
            dr["qty"] = DropDownList12.SelectedItem.Text;
            dr["size"] = DropDownList15.SelectedItem.Text;
            Int32 total3 = Convert.ToInt32(DropDownList12.SelectedItem.Text) * Convert.ToInt32(Label50.Text);
            dr["totalprice"] = total3;


            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();

            // Label49.Text = (total1 + total2 + total3).ToString();
        }
    }


    protected void ImageButton26_Click1(object sender, ImageClickEventArgs e)
    {

        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton26 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label52.Text;
            dr["price"] = Label53.Text;
            dr["qty"] = DropDownList13.SelectedItem.Text;
            dr["size"] = DropDownList16.SelectedItem.Text;
            Int32 total3 = Convert.ToInt32(DropDownList13.SelectedItem.Text) * Convert.ToInt32(Label53.Text);
            dr["totalprice"] = total3;


            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();

            // Label49.Text = (total1 + total2 + total3).ToString();
        }
    }

    protected void ImageButton27_Click1(object sender, ImageClickEventArgs e)
    {

        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton27 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label55.Text;
            dr["price"] = Label56.Text;
            dr["qty"] = DropDownList14.SelectedItem.Text;
            dr["size"] = DropDownList17.SelectedItem.Text;
            Int32 total3 = Convert.ToInt32(DropDownList14.SelectedItem.Text) * Convert.ToInt32(Label56.Text);
            dr["totalprice"] = total3;


            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();

            // Label49.Text = (total1 + total2 + total3).ToString();
        }
    }
}



  