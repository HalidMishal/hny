using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Accessories : System.Web.UI.Page
{
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



    protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton17 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label43.Text;
            dr["price"] = Label44.Text;
            dr["qty"] = DropDownList13.SelectedItem.Text;
            dr["size"] = DropDownList16.SelectedItem.Text;
            Int32 total1 = Convert.ToInt32(DropDownList13.SelectedItem.Text) * Convert.ToInt32(Label44.Text);
            dr["totalprice"] = total1;



            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }
    }

    protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton18 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label46.Text;
            dr["price"] = Label47.Text;
            dr["qty"] = DropDownList14.SelectedItem.Text;
            dr["size"] = DropDownList17.SelectedItem.Text;
            Int32 total2 = Convert.ToInt32(DropDownList14.SelectedItem.Text) * Convert.ToInt32(Label47.Text);
            dr["totalprice"] = total2;



            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton20 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label35.Text;
            dr["price"] = Label37.Text;
            dr["qty"] = DropDownList1.SelectedItem.Text;
            dr["size"] = DropDownList9.SelectedItem.Text;
            Int32 total1 = Convert.ToInt32(DropDownList1.SelectedItem.Text) * Convert.ToInt32(Label37.Text);
            dr["totalprice"] = total1;



            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }
    }

    protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
    {

        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton21 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label36.Text;
            dr["price"] = Label38.Text;
            dr["qty"] = DropDownList2.SelectedItem.Text;
            dr["size"] = DropDownList10.SelectedItem.Text;
            Int32 total1 = Convert.ToInt32(DropDownList2.SelectedItem.Text) * Convert.ToInt32(Label38.Text);
            dr["totalprice"] = total1;



            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }
    }

    protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton22 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label40.Text;
            dr["price"] = Label41.Text;
            dr["qty"] = DropDownList11.SelectedItem.Text;
            dr["size"] = DropDownList12.SelectedItem.Text;
            Int32 total1 = Convert.ToInt32(DropDownList11.SelectedItem.Text) * Convert.ToInt32(Label41.Text);
            dr["totalprice"] = total1;



            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }
    }

    protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton19 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label49.Text;
            dr["price"] = Label50.Text;
            dr["qty"] = DropDownList19.SelectedItem.Text;
            dr["size"] = DropDownList18.SelectedItem.Text;
            Int32 total1 = Convert.ToInt32(DropDownList19.SelectedItem.Text) * Convert.ToInt32(Label50.Text);
            dr["totalprice"] = total1;



            dt1.Rows.Add(dr);

            GridView1.DataSource = dt1;
            GridView1.DataBind();
        }
    }
}