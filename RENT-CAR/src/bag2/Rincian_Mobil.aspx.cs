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
    public partial class Rincian_Mobil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                string id_rincian_mobil = Request.QueryString["mobil"].ToString();
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksi"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM rincian_mobil WHERE id_rincian_mobil = " + id_rincian_mobil + ";";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();

                    StringBuilder sb = new StringBuilder();

                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        sb.Append("<div class='col-12 text-center'>");
                        sb.Append("<h2>Data Kendaraan</h2>");
                        sb.Append("</div>");
                        sb.Append("<div class='col-6 data-diri'>");
                        sb.Append("<div class='nama-kendaraan'>");
                        sb.Append("<small>Nama Kendaraan</small>");
                        sb.Append("<p>" + dt.Rows[i][2] +"</p>");
                        sb.Append("</div>");
                        sb.Append("<div class='plat-nomor'>");
                        sb.Append("<small>Nomor Polisi</small>");
                        sb.Append("<p>" + dt.Rows[i][3] + "</p>");
                        sb.Append("</div>");
                        sb.Append("<div class='warna'>");
                        sb.Append("<small>Warna</small>");
                        sb.Append("<p>" + dt.Rows[i][1] + "</p>");
                        sb.Append("</div>");
                        sb.Append("<div class='jml-penumpang'>");
                        sb.Append("<small>Jumlah Penumpang</small>");
                        sb.Append("<p>Maks " + dt.Rows[i][4] + " Orang</p>");
                        sb.Append("</div>");
                        sb.Append("</div>");

                        sb.Append("<div class='col-6 barang-sewa'>");
                        sb.Append("<div class='bahan-bakar'>");
                        sb.Append("<small>Konsumsi Bahan Bakar</small>");
                        sb.Append("<p>" + dt.Rows[i][5] + "km/l</p>");
                        sb.Append("</div>");
                        sb.Append("<div class='sewa-6'>");
                        sb.Append("<small>Harga Sewa /6 jam</small>");
                        sb.Append("<p>Rp " + dt.Rows[i][6] + "</p>");
                        sb.Append("</div>");
                        sb.Append("<div class='sewa-12'>");
                        sb.Append("<small>Harga Sewa /12 jam</small>");
                        sb.Append("<p>Rp " + dt.Rows[i][7] + "</p>");
                        sb.Append("</div>");
                        sb.Append("<div class='sewa-24'>");
                        sb.Append("<small>Harga Sewa /1 Hari</small>");
                        sb.Append("<p>Rp " + dt.Rows[i][8] + "</p>");
                        sb.Append("</div>");
                        sb.Append("</div>");
                    }

                    rincian_mobil.Controls.Add(new LiteralControl(sb.ToString()));

                    sb = new StringBuilder();
                    sb.Append("<button type='button' class='btn btn-success w-100'>");
                    sb.Append("<a href='Ubah_Mobil.aspx?data=" + dt.Rows[0][0] + "'>Ubah</a>");
                    sb.Append("</button>");

                    ubah_data_mobil.Controls.Add(new LiteralControl(sb.ToString()));

                    connection.Close();

                }
            }
            catch (Exception ex) { }

        }

        protected void tbl_hapus_data_Click(object sender, EventArgs e)
        {
            try
            {
                string id_rincian_mobil = Request.QueryString["mobil"].ToString();
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksi"].ToString();
                    connection.Open();

                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM rincian_mobil WHERE id_rincian_mobil = " + id_rincian_mobil + ";";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();

                    connection.Close();

                    Response.Redirect("Dashboard2.aspx");
                }
            }
            catch (Exception ex) { }
        }
    }
}