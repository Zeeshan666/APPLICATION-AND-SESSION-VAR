using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text ="value of i "+ i.ToString();

        int sessionvar = Convert.ToInt32(Session["sesvar"]);
    
        Label2.Text = "value of session var is  "+sessionvar.ToString();
        sessionvar++;
        Session["sesvar"] = sessionvar;
        Label1.Text = "value of i " + i.ToString();

        int applicationvar = Convert.ToInt32(Application["appvar"]);

        Label3.Text = "value of application var is  " + applicationvar.ToString();
        applicationvar++;
        Application["appvar"] = applicationvar;


        Label4.Text = Session.SessionID;


    }
}