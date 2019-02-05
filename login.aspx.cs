using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // ClientScript.RegisterStartupScript(this.GetType(), "my alert message", "alert('Registered Successfully!!!');", true);

    }

    protected void Button2_Click(object sender, EventArgs e)
   {
        Response.Redirect("Register.aspx");

   }

    protected void Button3_Click(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["october14ConnectionString"].ConnectionString);
        con.Open();

        string userchk = "select email, password from CUSTOMER where email ='" + TextBox2.Text + "'and password='" + TextBox3.Text + "'";
        SqlCommand cmd = new SqlCommand(userchk, con);
        cmd.CommandType = CommandType.Text;
        Session["Name"] = TextBox2.Text.ToString();
        // cmd.Parameters.AddWithValue("@email", TextBox2.Text);
        //cmd.Parameters.AddWithValue("@password", TextBox3.Text);
        if (TextBox2.Text=="" || TextBox3.Text=="")
        {

            ClientScript.RegisterStartupScript(this.GetType(), "my alert message", "alert('Invalid Username or  password');", true);


        }
        else
        {
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())                         //I'M WRONG FROM HERE ONWARDS.
            {
                Response.Redirect("homepage.aspx");
            }

            con.Close();
            dr.Close();
        }
    }
   
    
}