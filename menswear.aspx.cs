using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class menswear : System.Web.UI.Page
{

    DataTable dt1 = new DataTable();
     private object total6;

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
           

          //  gridVIEWData();
       //   GridView1.DataSource = dt1;
           // GridView1.DataBind();
          //  Session["dt1"] = dt1;



            string sQuery = "SELECT * FROM AddToCart";

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["october14ConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(sQuery, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            GridView SqlDataSource1 = new GridView();

            dt.Load(sdr);
            SqlDataSource1.DataSource = dt;
            SqlDataSource1.DataBind();
        }
    }

 protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        dt1 = (DataTable)Session["buyitems"];

        for (int i = 0; i <= dt1.Rows.Count - 1; i++)
        {
            int sr;
            int sr1;
            string qdata;
            string dtdata;
            sr = Convert.ToInt32(dt1.Rows[i]["productID"].ToString());
         //   TableCell cell = GridView1.Rows[e.RowIndex].Cells[0];
        //    qdata = cell.Text;
            dtdata = sr.ToString();
         //   sr1 = Convert.ToInt32(qdata);

         //   if (sr == sr1)
            {
                dt1.Rows[i].Delete();
                dt1.AcceptChanges();
                //Label1.Text = "Item Has Been Deleted From Shopping Cart";
                break;

            }
        }
              

        for (int i = 1; i <= dt1.Rows.Count; i++)
        {
            dt1.Rows[i - 1]["productID"] = i;
            dt1.AcceptChanges();
        }

      //  Session["buyitems"] = dt1;
      //  Response.Redirect("menswaer.aspx");
    }



  
    protected void ImageButton16_Click1(object sender, ImageClickEventArgs e)
    {

        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton16 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label53.Text;
            dr["price"] = Label55.Text;
            dr["qty"] = DropDownList19.SelectedItem.Text;
            dr["size"] = DropDownList20.SelectedItem.Text;
            Int32 total2 = Convert.ToInt32(DropDownList19.SelectedItem.Text) * Convert.ToInt32(Label55.Text);
            dr["totalprice"] = total2;



            dt1.Rows.Add(dr);

          //  GridView1.DataSource = dt1;
          //  GridView1.DataBind();
        }
    }

    protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
    {

        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton17 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label57.Text;
            dr["price"] = Label59.Text;
            dr["qty"] = DropDownList21.SelectedItem.Text;
            dr["size"] = DropDownList22.SelectedItem.Text;
            Int32 total3 = Convert.ToInt32(DropDownList21.SelectedItem.Text) * Convert.ToInt32(Label59.Text);
            dr["totalprice"] = total3;



            dt1.Rows.Add(dr);

           // GridView1.DataSource = dt1;
           // GridView1.DataBind();
        }
    }

    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {

        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton15 != null)
        {
           
            DataRow dr = dt1.NewRow();

            dr["productID"] = Label49.Text;
            dr["price"] = Label51.Text;
            dr["qty"] = DropDownList17.SelectedItem.Text;
            dr["size"] = DropDownList18.SelectedItem.Text;
            Int32 total4 = Convert.ToInt32(DropDownList17.SelectedItem.Text) * Convert.ToInt32(Label51.Text);
            dr["totalprice"] = total4;



            dt1.Rows.Add(dr);

           // GridView1.DataSource = dt1;
           // GridView1.DataBind();
        }
    }

    protected void ImageButton18_Click1(object sender, ImageClickEventArgs e)
    {
        // if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];
        
        if (ImageButton18 != null)
        {
            SqlCommand cmd;
          SqlConnection  con = new SqlConnection(ConfigurationManager.ConnectionStrings["october14ConnectionString"].ConnectionString);
            con.Open();
            
            string size = DropDownList24.SelectedItem.Text;
             Label72.Text = Session["Name"].ToString();
            Int32 total6 = Convert.ToInt32(DropDownList23.SelectedItem.Text) * Convert.ToInt32(Label63.Text);


            string insertQuery = "insert into AddToCart(ProductID,Email,Quantity,price,Size,TotalPrice) values (@ProductID,@email,@Quantity,@Price,@Size,@TotalPrice)";

            cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@ProductID", Label61.Text);
           cmd.Parameters.AddWithValue("@email",Label72.Text);

            cmd.Parameters.AddWithValue("@Quantity", DropDownList23.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@Price", Label63.Text);
            cmd.Parameters.AddWithValue("@Size", size);
             cmd.Parameters.AddWithValue("@TotalPrice", total6.ToString());

            cmd.ExecuteNonQuery();


           // DataRow dr = dt1.NewRow();

           // dr["productID"] = Label61.Text;
           // dr["price"] = Label63.Text;
            //dr["qty"] = DropDownList23.SelectedItem.Text;
            //dr["size"] = DropDownList24.SelectedItem.Text;
          //  Int32 total6 = Convert.ToInt32(DropDownList23.SelectedItem.Text) * Convert.ToInt32(Label63.Text);
        //   dr["totalprice"] = total6;



           // dt1.Rows.Add(dr);

          //  GridView1.DataSource = dt1;
          //  GridView1.DataBind();


            con.Close();
            Response.Redirect("AddtoCart.aspx");
        }
    }

    protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton19 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label65.Text;
            dr["price"] = Label67.Text;
            dr["qty"] = DropDownList25.SelectedItem.Text;
            dr["size"] = DropDownList26.SelectedItem.Text;
            Int32 total1 = Convert.ToInt32(DropDownList25.SelectedItem.Text) * Convert.ToInt32(Label67.Text);
            dr["totalprice"] = total1;



            dt1.Rows.Add(dr);

          //  GridView1.DataSource = dt1;
        //    GridView1.DataBind();
        }
    }

    protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
    {

        if (Session["dt1"] != null) dt1 = (DataTable)Session["dt1"];

        if (ImageButton20 != null)
        {

            DataRow dr = dt1.NewRow();

            dr["productID"] = Label69.Text;
            dr["price"] = Label71.Text;
            dr["qty"] = DropDownList27.SelectedItem.Text;
            dr["size"] = DropDownList28.SelectedItem.Text;
            Int32 total5 = Convert.ToInt32(DropDownList27.SelectedItem.Text) * Convert.ToInt32(Label71.Text);
            dr["totalprice"] = total5;



            dt1.Rows.Add(dr);

          //  GridView1.DataSource = dt1;
           // GridView1.DataBind();
        }
    }

   
}


