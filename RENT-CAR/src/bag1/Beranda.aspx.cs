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


namespace RENT_CAR.src.bag1
{
    public partial class Beranda : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksi"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM rincian_mobil";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        sb.Append("<div class='card-outer col-lg-4 col-md-6 col-12 mb-3'>");
                        sb.Append("<div class='card mx-auto' style='width: 18rem; overflow: hidden; border-radius: 30px;'>");
                        sb.Append("<img src='../../img/" + dt.Rows[i][0] + ".png' class='card-img-top m-auto' runat='server' alt='Mobil' style='width: 200px; height: 200px; background-position: center; background-attachment: fixed;'>");
                        sb.Append("<div class='card-body text-center pb-0'>");
                        sb.Append("<h5 class='card-title font-weight-bold'>" + dt.Rows[i][2] + "</h5>");
                        sb.Append("</div>");
                        sb.Append("<ul class='list-group list-group-flush text-center'>");
                        sb.Append("<li class='list-group-item'>Max " + dt.Rows[i][4] + " orang</li>");
                        sb.Append("<li class='list-group-item'>" + dt.Rows[i][5] + " km/l</li>");
                        sb.Append("<li class='list-group-item'>" + dt.Rows[i][6] + " /6jam</li>");
                        sb.Append("<li class='list-group-item'>" + dt.Rows[i][7] + " /12jam</li>");
                        sb.Append("<li class='list-group-item'>" + dt.Rows[i][8] + " /hari</li>");
                        sb.Append("</ul>");
                        sb.Append("<div class='card-body text-center'>");
                        sb.Append("<a href='../bag4/Data_Diri_Customer.aspx?mobil=" + dt.Rows[i][0] + "' class='btn btn-success rounded-pill w-100 px-5 py-2' onclick='coba'>Sewa</a>");
                        sb.Append("</div>");
                        sb.Append("</div>");
                        sb.Append("</div>");

                        if (i == (dt.Rows.Count - 1))
                        {
                            break;
                        }

                    }

                    data_mobil.Controls.Add(new LiteralControl(sb.ToString()));

                    connection.Close();

                }
            }
            catch (Exception ex) { }

        }

    }
}