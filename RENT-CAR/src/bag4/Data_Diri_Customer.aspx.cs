using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using Npgsql;

namespace RENT_CAR.src.bag4
{
    public partial class Data_Diri_Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string _id_mobil = Request.QueryString["mobil"].ToString();

        }

        protected void konfirmasi_Click(object sender, EventArgs e)
        {
            try
            {
                int _id_user_baru = 0;
                int _id_pembukuan_baru = 0;
                string _id_mobil = Request.QueryString["mobil"].ToString();
                string _nama_lengkap = nama_lengkap.Text.ToString();
                string _no_telepon = no_telepon.Text.ToString();
                string _nik = nik.Text.ToString();
                string _alamat = alamat.Text.ToString();
                string _durasi_sewa = sewa.Text.ToString();
                DateTime _date = DateTime.Now;

                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksi"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;

                    // PELANGGAN
                    cmd.CommandText = "SELECT * FROM pelanggan";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    _id_user_baru = dt.Rows.Count + 1;

                    cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO pelanggan VALUES(@ID, @nama, @no_telp, @nik, @alamat, @durasi)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", _id_user_baru));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama", _nama_lengkap));
                    cmd.Parameters.Add(new NpgsqlParameter("@no_telp", _no_telepon));
                    cmd.Parameters.Add(new NpgsqlParameter("@nik", _nik));
                    cmd.Parameters.Add(new NpgsqlParameter("@alamat", _alamat));
                    cmd.Parameters.Add(new NpgsqlParameter("@durasi", Convert.ToInt32(_durasi_sewa)));
                    cmd.ExecuteNonQuery();


                    // PEMBUKUAN
                    cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM pembukuan";
                    cmd.CommandType = CommandType.Text;
                    da = new NpgsqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    _id_pembukuan_baru = dt.Rows.Count + 1;

                    cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO pembukuan VALUES(@ID, @id_mobil, @id_user, @tanggal_sewa, @tanggal_kembali, @status)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", _id_pembukuan_baru));
                    cmd.Parameters.Add(new NpgsqlParameter("@id_mobil", Convert.ToInt32(_id_mobil)));
                    cmd.Parameters.Add(new NpgsqlParameter("@id_user", _id_user_baru));
                    cmd.Parameters.Add(new NpgsqlParameter("@tanggal_sewa", _date.ToString("yyyy-MM-dd")));
                    cmd.Parameters.Add(new NpgsqlParameter("@tanggal_kembali", ""));
                    cmd.Parameters.Add(new NpgsqlParameter("@status", -1));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    connection.Close();

                    //Response.Write("<script>alert('Sewa Sukses')</script>");
                    Response.Redirect("../bag5/Checkout.aspx?mobil=" + _id_mobil.ToString() + "&user=" + _id_user_baru);
                }
            }
            catch (Exception ex) {
                Response.Write("<script>alert('Sewa Gagal')</script>");
            }
        }
    }
}