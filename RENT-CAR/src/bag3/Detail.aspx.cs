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


namespace RENT_CAR.src.bag3
{
    public partial class Detail_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Admin_Login.aspx", true);
            }
            else
            {
                try
                {
                    string id_pembukuan = Request.QueryString["buku"].ToString();

                    using (NpgsqlConnection connection = new NpgsqlConnection())
                    {
                        connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksi"].ToString();
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT id_pembukuan, nama_lengkap, no_telepon, nik, alamat, nama_kendaraan, jumlah_penumpang, konsumsi_bahan_bakar,  durasi_sewa, status FROM rincian_mobil JOIN mobil ON mobil.rincian_mobil_id = rincian_mobil.id_rincian_mobil JOIN pembukuan ON pembukuan.mobil_id = mobil.id_mobil JOIN pelanggan ON pembukuan.pelanggan_id = pelanggan.id_pelanggan WHERE id_pembukuan = " + id_pembukuan + ";";
                        cmd.CommandType = CommandType.Text;
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cmd.Dispose();

                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            // Data Pelanggan yang ingin Menyewa
                            sb.Append("<div class='col-lg-6 data-diri'>");
                            sb.Append("<h2>Data Diri</h2>");
                            sb.Append("<div class='nama'>");
                            sb.Append("<small>Nama lengkap</small>");
                            sb.Append("<p>" + dt.Rows[i][1] + "</p>");
                            sb.Append("</div>");
                            sb.Append("<div class='no-telepon'>");
                            sb.Append("<small>Nomor Telepon</small>");
                            sb.Append("<p>" + dt.Rows[i][2] + "</p>");
                            sb.Append("</div>");
                            sb.Append("<div class='nik'>");
                            sb.Append("<small>NIK</small>");
                            sb.Append("<p>" + dt.Rows[i][3] + "</p>");
                            sb.Append("</div>");
                            sb.Append("<div class='alamat'>");
                            sb.Append("<small>Alamat Rumah</small>");
                            sb.Append("<p>" + dt.Rows[i][4] + "</p>");
                            sb.Append("</div>");
                            sb.Append("</div>");

                            // Data Mobil yang Disewa
                            sb.Append("<div class='col-lg-6 barang-sewa'>");
                            sb.Append("<h2>Mobil Disewa</h2>");
                            sb.Append("<div class='merk-mobil'>");
                            sb.Append("<small>Merk Mobil</small>");
                            sb.Append("<p>" + dt.Rows[i][5].ToString() + "</p>");
                            sb.Append("</div>");
                            sb.Append("<div class='jml-penumpang'>");
                            sb.Append("<small>Jumlah Penumpang</small>");
                            sb.Append("<p>" + dt.Rows[i][6].ToString() + " orang</p>");
                            sb.Append("</div>");
                            sb.Append("<div class='bahan-bakar'>");
                            sb.Append("<small>Konsumsi Bahan Bakar</small>");
                            sb.Append("<p>" + dt.Rows[i][7].ToString() + "km/l</p>");
                            sb.Append("</div>");
                            sb.Append("<div class='durasi-sewa'>");
                            sb.Append("<small>Durasi Sewa</small>");
                            sb.Append("<p>" + dt.Rows[i][8].ToString() + " hari</p>");
                            sb.Append("</div>");
                            sb.Append("</div>");
                        }

                        data_detail.Controls.Add(new LiteralControl(sb.ToString()));

                        if (dt.Rows[0][9].ToString() == "-1")
                        {
                            sb = new StringBuilder();
                            sb.Append("<button type='button' class='btn btn-danger w-100' data-toggle='modal' data-target='#hapus'>");
                            sb.Append("Batal");
                            sb.Append("</button>");
                            akses_batal.Controls.Add(new LiteralControl(sb.ToString()));

                            sb = new StringBuilder();
                            sb.Append("<button type='button' class='btn btn-success w-100' data-toggle='modal' data-target='#konfirmasi'>");
                            sb.Append("Konfirmasi");
                            sb.Append("</button>");
                            akses_konfirmasi.Controls.Add(new LiteralControl(sb.ToString()));
                        }

                        connection.Close();
                    }
                }
                catch (Exception) { }
            }
        }

        protected void tbl_hapus_Click(object sender, EventArgs e)
        {
            string id_pembukuan = Request.QueryString["buku"].ToString();
            //Response.Write("<script>alert('Hapus Sukses')</script>");
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksi"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE pembukuan SET status = 0 WHERE id_pembukuan = @ID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(id_pembukuan)));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();

                    Response.Redirect("../bag2/Dashboard1.aspx", true);
                }
            }
            catch (Exception ex) { }

        }

        protected void tbl_konfirmasi_Click(object sender, EventArgs e)
        {
            string id_pembukuan = Request.QueryString["buku"].ToString();
            //Response.Write("<script>alert('Hapus Sukses')</script>");
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksi"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE pembukuan SET status = 1 WHERE id_pembukuan = @ID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(id_pembukuan)));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();

                    Response.Redirect("../bag2/Dashboard1.aspx", true);
                }
            }
            catch (Exception ex) { }
        }

    }
}