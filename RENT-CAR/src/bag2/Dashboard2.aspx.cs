using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using Npgsql;
using System.Text;

namespace RENT_CAR.src.bag2
{
    public partial class Dashboard2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["admin"] == null)
            {
                Response.Redirect("Admin_Login.aspx", true);
            }
            else
            {
                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection())
                    {
                        connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksi"].ToString();
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT id_rincian_mobil, nama_kendaraan, nomor_polisi, warna_mobil FROM rincian_mobil ORDER BY id_rincian_mobil ASC;";
                        cmd.CommandType = CommandType.Text;
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cmd.Dispose();

                        StringBuilder sb = new StringBuilder();

                        sb.Append("<table class='table table-striped table-hover mx-auto'>");
                        sb.Append("<thead class='thead-dark'>");
                        sb.Append("<tr>");

                        sb.Append("<th scope='col'>Nama Kendaraan</th>");
                        sb.Append("<th scope='col'>Plat Nomor</th>");
                        sb.Append("<th scope='col'>Warna</th>");
                        sb.Append("<th scope='col'>Keterangan</th>");

                        sb.Append("</tr>");
                        sb.Append("</thead>");


                        sb.Append("<tbody>");
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            sb.Append("<tr>");
                            sb.Append("<td>" + dt.Rows[i][1] + "</td>");
                            sb.Append("<td>" + dt.Rows[i][2] + "</td>");
                            sb.Append("<td>" + dt.Rows[i][3] + "</td>");
                            sb.Append("<td>");
                            sb.Append("<div class='d-flex justify-content-between align-items-center w-75 text-dark' style='text-decoration: underline;'>");
                            sb.Append("<a href='/src/bag2/Rincian_Mobil.aspx?mobil=" + dt.Rows[i][0] + "' class='p-1 text-dark mr-3'>Cek detail</a>");
                            sb.Append("</div>");
                            sb.Append("</td>");
                            sb.Append("</tr>");
                        }
                        sb.Append("</tbody>");
                        sb.Append("</table");

                        data_kendaraan.Controls.Add(new LiteralControl(sb.ToString()));

                        connection.Close();
                    }
                }
                catch (Exception ex) { }
            }
            
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("../bag1/Beranda.aspx");
        }

    }
}