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
    public partial class Tambah_Mobil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["admin"] == null)
            {
                Response.Redirect("Admin_Login.aspx", true);
            }
        }

        protected void tbl_tambah_data_Click(object sender, EventArgs e)
        {
            try
            {
                string _nama_kendaraan = nama_kendaraan.Text.ToString();
                string _no_polisi = no_polisi.Text.ToString();
                string _warna_mobil = warna_mobil.Text.ToString();
                int _jml_penumpang = Convert.ToInt32(jumlah_penumpang.Text.ToString());
                int _bahan_bakar = Convert.ToInt32(bahan_bakar.Text.ToString());
                double _harga_6 = Convert.ToDouble(harga_6.Text.ToString());
                double _harga_12 = Convert.ToDouble(harga_12.Text.ToString());
                double _harga_24 = Convert.ToDouble(harga_24.Text.ToString());

                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksi"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM rincian_mobil;";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();
                    double baris_baru = dt.Rows.Count + 1;

                    cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO rincian_mobil VALUES(@ID, @warna, @nama, @no_polisi, @jml_penumpang, @bahan_bakar, @harga_6, @harga_12, @harga_24)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ID", baris_baru));
                    cmd.Parameters.Add(new NpgsqlParameter("@warna", _warna_mobil));
                    cmd.Parameters.Add(new NpgsqlParameter("@nama", _nama_kendaraan));
                    cmd.Parameters.Add(new NpgsqlParameter("@no_polisi", _no_polisi));
                    cmd.Parameters.Add(new NpgsqlParameter("@jml_penumpang", _jml_penumpang));
                    cmd.Parameters.Add(new NpgsqlParameter("@bahan_bakar", _bahan_bakar));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_6", _harga_6));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_12", _harga_12));
                    cmd.Parameters.Add(new NpgsqlParameter("@harga_24", _harga_24));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();

                    Response.Redirect("Dashboard2.aspx");
                }
            }
            catch (Exception ex) { };
        }
    }
}