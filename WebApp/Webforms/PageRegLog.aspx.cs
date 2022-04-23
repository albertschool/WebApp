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
    public partial class PageRegLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitView();

            if (Request.Form["submit"] != null)
            {
                if (btnLogin.Value == "Register")
                {
                    string SQLStr = $"SELECT * FROM Users " +
                        $"WHERE userName='{Request.Form["userName"]}' AND password='{Request.Form["password"]}'";
                    DataSet ds = RetrieveUsersTable(SQLStr);
                    if (ds.Tables["users"].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["fName"].ToString() == "NULL")
                        {
                            Session["userName"] = Request.Form["userName"];
                        }
                        else
                        {
                            Session["userName"] = ds.Tables[0].Rows[0]["fName"];
                        }
                        Session["Login"] = true;
                        Session["Admin"] = ds.Tables[0].Rows[0]["Admin"];
                        Response.Redirect("PageMain.aspx");
                    }
                    else
                    {
                        msgRslt.InnerHtml = "Not a registered user - Please Register";
                        SetRegister();
                    }
                }
                else
                {
                    string SQLStr = $"SELECT * FROM Users " +
                        $"WHERE userName='{Request.Form["userName"]}'";
                    DataSet ds = RetrieveUsersTable(SQLStr);
                    if (ds.Tables["users"].Rows.Count == 0)
                    {
                        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                        SQLStr = $"SELECT * FROM Users WHERE 0=1";
                        SqlConnection con = new SqlConnection(conStr);
                        SqlCommand cmd = new SqlCommand(SQLStr, con);
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        adp.Fill(ds, "users");

                        DataRow dr = ds.Tables["users"].NewRow();
                        dr["userName"] = Request.Form["userName"];
                        dr["password"] = Request.Form["password"];
                        dr["Admin"] = false;
                        dr["fName"] = Request.Form["fName"];
                        dr["lName"] = Request.Form["lName"];
                        dr["phone"] = Request.Form["phone"];
                        dr["email"] = Request.Form["email"];
                        dr["gender"] = Request.Form["gender"];
                        ds.Tables["users"].Rows.Add(dr);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adp);
                        adp.Update(ds, "users");
                        if (Request.Form["fName"] == null)
                        {
                            Session["userName"] = Request.Form["userName"];
                        }
                        else
                        {
                            Session["userName"] = Request.Form["fName"];
                        }
                        Session["Login"] = true;
                        Session["Admin"] = ds.Tables[0].Rows[0]["Admin"];
                        Response.Redirect("PageMain.aspx");
                    }
                    else
                    {
                        msgRslt.InnerHtml = "Username already taken - Please choose another";
                        SetRegister();
                    }
                }
            }
        }

        public void logOrReg(object sender, EventArgs e)
        {
            if (btnLogin.Value == "Register")
            {
                SetRegister();
            }
            else
            {
                SetLogin();
            }
        }

        public void InitView()
        {
            reg1.Visible = false;
            reg2.Visible = false;
            reg3.Visible = false;
            reg4.Visible = false;
            reg5.Visible = false;
            reg6.Visible = false;
        }

        public void SetRegister()
        {
            reg1.Visible = true;
            reg2.Visible = true;
            reg3.Visible = true;
            reg4.Visible = true;
            reg5.Visible = true;
            reg6.Visible = true;
            btnLogin.Value = "Login";
        }

        public void SetLogin()
        {
            reg1.Visible = false;
            reg2.Visible = false;
            reg3.Visible = false;
            reg4.Visible = false;
            reg5.Visible = false;
            reg6.Visible = false;
            btnLogin.Value = "Register";
        }

        public DataSet RetrieveUsersTable(String SQLStr)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(SQLStr, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "users");
            return ds;
        }

    }
}