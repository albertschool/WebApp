using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApp.Webforms
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(bool)Session["Login"])
            {
                topnav.Style.Add("display", "none");
                btn.Style.Add("display", "none");
            }
            else
            {
                topnav.Style.Add("display", "block");
                btn.Style.Add("display", "block");
                if (!(bool)Session["Admin"])
                {
                    topnav5.Style.Add("display", "none");
                }
            }
        }

        public void btn_logout(object sender, EventArgs e)
        {
            Session["Login"] = false;
            Session["Admin"] = false;
            Session["userName"] = "Visitor";
            Response.Redirect("PageRegLog.aspx");
        }
    }
}