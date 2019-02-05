using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Timers;

public partial class homepage : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
      
    }


    protected void AdRotator1_AdCreated(object sender, AdCreatedEventArgs e)
    {

    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("womenswear.aspx");
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("menswear.aspx");
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {

        Response.Redirect("Accessories.aspx");
    }

   
}