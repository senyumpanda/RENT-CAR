using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RENT_CAR.src.bag2
{
    public partial class Admin_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbl_login_Click(object sender, EventArgs e)
        {
            try
            {
                string _username = username.Text.ToString();
                string _pass = pass.Text.ToString();

                if( _username == "admin" && _pass == "admin" )
                {
                    Session["admin"] = _username;
                    Response.Redirect("Dashboard1.aspx", true);
                }
                else
                {
                    Response.Write("<script>alert('Gagal Login')</script>");
                }
            }
            catch (Exception ex) { }
        }
    }
}