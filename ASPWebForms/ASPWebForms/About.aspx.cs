using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForms
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("No Of Applications " + Application["NoOfApplications"]);
            Response.Write("<br/>");
            Response.Write("No Of Sessions " + Application["NoOfSessions"]);
        }
    }
}