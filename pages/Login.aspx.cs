using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Login : System.Web.UI.Page
{
    public string msg;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.Form["submit"] != null)
        {
            if (Request.Form["userName"] != null)
            {
                
                string dbPath = this.MapPath("../App_Data/Database.mdf");
                DAL dal = new DAL(dbPath);

                string sqlQuery = "SELECT * FROM users WHERE usr_userName = '" + Request.Form["userName"].ToString() + "' AND usr_pswd = '" + Request.Form["passwd"].ToString() + "'";
                DataSet ds = dal.GetDataSet(sqlQuery);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["userName"] = Request.Form["userName"];
                    DataRow row = ds.Tables[0].Rows[0];
                    Session["isAdmin"] = row["usr_isAdmin"].ToString();
                    Response.Redirect("Home Page.aspx");
                }
                else
                {
                    msg = "שם משתמש או סיסמה אינם נכונים";
                }

            }
        }
    }

}