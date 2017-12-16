using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using ASPWebForms;

namespace ASPWebForms
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Application["NoOfApplications"] = 1;
            Application["NoOfSessions"] = 0;
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start()
        {
            Application["NoOfSessions"] = (int) Application["NoOfSessions"] + 1;
        }

        void Session_End()
        {
            Application["NoOfSessions"] = (int)Application["NoOfSessions"] - 1;
        }
    }
}
