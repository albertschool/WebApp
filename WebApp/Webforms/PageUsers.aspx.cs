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
    public partial class PageUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(bool)Session["Login"])
            {
                Response.Redirect("PageLanding.aspx");
            }

            string SQLStr = "SELECT * FROM Users";
            DataSet ds = RetrieveUsersTable(SQLStr);
            DataTable dt = ds.Tables["users"];
            string table = BuildUsersTable(dt);
            tableDiv.InnerHtml = table;

            //if (!IsPostBack)
            //{
            //    string SQLStr = "SELECT * FROM Users";
            //    DataSet ds = RetrieveUsersTable(SQLStr);
            //    DataTable dt = ds.Tables["users"];
            //    string table = BuildUsersTable(dt);
            //    tableDiv.InnerHtml = table;
            //}
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

        private string BuildUsersTable(DataTable dt)
        {
            string str = "<table class='usersTable' align='center'>";
            str += "<tr>";
            foreach (DataColumn column in dt.Columns)
            {
                str += "<th><strong>" + column.ColumnName + "</strong></th>";
            }
            str += "</tr>";
            foreach (DataRow row in dt.Rows)
            {
                str += "<tr>";
                foreach (DataColumn column in dt.Columns)
                {
                    str += "<td>" + row[column] + "</td>";
                }
                str += "</tr>";
            }
            str += "</table>";
            return str;
        }

    }
}