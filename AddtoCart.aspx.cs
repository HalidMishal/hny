using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class AddtoCart : System.Web.UI.Page
{
    //private void gridVIEWData()
    //{
    //    DataTable dt1 = new DataTable();
    //    dt1.Columns.Add("ProductID", typeof(string));
    //    dt1.Columns.Add("Quantity", typeof(int));
    //    dt1.Columns.Add("price", typeof(int));
    //    dt1.Columns.Add("Size", typeof(string));
    //    dt1.Columns.Add("TotalPrice", typeof(int));
    //}
    protected void Page_Load(object sender, EventArgs e)
    {

        //gridVIEWData();
        //DataTable dt1 = new DataTable();
        SqlConnection con;
        SqlCommand cmd;

         con = new SqlConnection(ConfigurationManager.ConnectionStrings["october14ConnectionString"].ConnectionString);
        con.Open();
       // DataRow dr = dt1.NewRow();
      string id=Session["Name"].ToString();
        string query = "select * from AddToCart where Email=@id";

        cmd = new SqlCommand(query, con);
        cmd.Parameters.Add(new SqlParameter("@id", id));


        //string productID = "select ProductID from AddToCart where Email = @id";
        //cmd = new SqlCommand(productID, con);
        //string price = "select price from AddToCart where Email = @id";
        //cmd = new SqlCommand(price, con);
        //string Quantity = "select Quantity from AddToCart where Email = @id";
        //cmd = new SqlCommand(Quantity, con);
        //string Size = "select Size from AddToCart where Email =@id";
        //cmd = new SqlCommand(Size, con);
        //string TotalPrice = "select TotalPrice from AddToCart where Email = @id";
        //cmd = new SqlCommand(TotalPrice, con);
        //cmd.Parameters.Add(new SqlParameter("@id", id));
        SqlDataAdapter ca = new SqlDataAdapter(cmd);

        //dr["ProductID"] = productID.ToString();
        //dr["Quantity"] = Quantity.ToString();
        //dr["price"] = price.ToString();
        //dr["Size"] = Size.ToString();
        //dr["TotalPrice"] = TotalPrice.ToString();



        //  dt1.Rows.Add(dr);
        DataTable dt1 = new DataTable();
        ca.Fill(dt1);
      //Grid2.DataSource = dt1;
        Grid2.DataBind();

    }



 }