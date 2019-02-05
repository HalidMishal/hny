using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class register : System.Web.UI.Page
{

    SqlConnection con;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
/*
        if (IsPostBack)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["october14ConnectionString"].ConnectionString);
            con.Open();
            string userchk = "select count(*) from Register where firstName ='" + TextBox2.Text + "'";
            cmd = new SqlCommand(userchk, con);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (temp == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "my alert message", "alert('This name Already Exist');", true);
                // Response.Write("This name Already Exist");
            }
            con.Close();
        }*/

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        try
        {
           
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["october14ConnectionString"].ConnectionString);
            con.Open();
            //string insertQuery = "insert into Register(firstName,lastName,phone,email,password) values (@firstName,@lastName,@phone,@email,@password)";
            // cmd = new SqlCommand(insertQuery, con);
            //cmd.Parameters.AddWithValue("@firstName", TextBox2.Text);
            //cmd.Parameters.AddWithValue("@lastName", TextBox3.Text);
            //cmd.Parameters.AddWithValue("@phone", TextBox7.Text);
            //cmd.Parameters.AddWithValue("@email", TextBox5.Text);
            //cmd.Parameters.AddWithValue("@password", TextBox6.Text);
            //cmd.ExecuteNonQuery();

            if (TextBox2.Text == "" || TextBox3.Text == "" || TextBox7.Text == "" || TextBox5.Text == "" || TextBox6.Text == "")
            {
                // Label12.Text = "Please Fill All the Fields !!!!!";
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Please fill all Fields');</script>");
                ClientScript.RegisterStartupScript(this.GetType(), "my alert message", "alert('Please Fill All Fields');", true);
                // Response.Write("Fields cannot be blank");
            }         
            


            else
            {


                string insertQuery = "insert into CUSTOMER(firstName,lastName,phone,email,password) values (@firstName,@lastName,@phone,@email,@password)";

                /*  string EmaiId = TextBox5.Text.Trim();

                  SqlCommand cmd = new SqlCommand("SELECT EmailAddress FROM tblEmployee WHERE EmailAddress ='" + EmaiId + "'", con);
                  con.Open();
                  SqlDataReader idr = cmd.ExecuteReader();
                  if (idr.HasRows)
                  {
                      ClientScript.RegisterStartupScript(this.GetType(), "my alert message", "alert( 'Email address already exists')",true);
                      TextBox5.Focus();
                  }
                  else
                  {
                      ClientScript.RegisterStartupScript(this.GetType(), "my alert message", "alert( ' ')", true);
                  }
                  */

                cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@firstName", TextBox2.Text);
                cmd.Parameters.AddWithValue("@lastName", TextBox3.Text);
                cmd.Parameters.AddWithValue("@phone", TextBox7.Text);
                cmd.Parameters.AddWithValue("@email", TextBox5.Text);
                cmd.Parameters.AddWithValue("@password", TextBox6.Text);

                cmd.ExecuteNonQuery();
               
                
                con.Close();
                
            }
        }
        catch
        {
           // ClientScript.RegisterStartupScript(this.GetType(), "my alert message", "alert('Registered Successfully!!!');", true);
        }

        
      ClientScript.RegisterStartupScript(this.GetType(), "my alert message", "alert('Registered Successfully!!!');", true);
       // TextBox2.Text = "";
       // TextBox3.Text = "";
       // TextBox5.Text = "";
       // TextBox7.Text = "";
       // TextBox6.Text = "";

       // Response.Redirect("login.aspx");

    }


    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }
}

