using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["aName1"] = "al1208";
            Application["aPass1"] = "a1234567";
            Application["uName1"] = "ef0609";
            Application["uPass1"] = "a0123456";

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Login"] = false;
            Session["Admin"] = false;
            Session["userName"] = "Visitor";
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}