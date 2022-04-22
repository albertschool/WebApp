using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Webforms
{
    public partial class PageRegLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Request.Form["userName"] == Application["aName1"].ToString() && Request.Form["password"] == Application["aPass1"].ToString())
                {
                    Session["Login"] = true;
                    Session["Admin"] = true;
                    Session["userName"] = Request.Form["userName"];
                    Response.Redirect("PageMain.aspx");
                }
                else
                {
                    msgRslt.InnerHtml = "Not a registered user - Please Register";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "CalllogOrReg", "logOrReg()", true);
                }
                if (Request.Form["userName"] == Application["uName1"].ToString() && Request.Form["password"] == Application["uPass1"].ToString())
                {
                    Session["Login"] = true;
                    Session["userName"] = Request.Form["userName"];
                    Response.Redirect("PageMain.aspx");
                }
                else
                {
                    msgRslt.InnerHtml = "Not a registered user - Please Register";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "CalllogOrReg", "logOrReg()", true);
                }
            }
        }
    }
}