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

namespace RENT_CAR.src.bag5
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string _id_mobil = Request.QueryString["mobil"].ToString();
                string _id_pelanggan = Request.QueryString["user"].ToString();
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["koneksi"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT nama_lengkap, no_telepon, nik, alamat, nama_kendaraan, jumlah_penumpang, konsumsi_bahan_bakar, durasi_sewa FROM pembukuan as p JOIN mobil as m ON p.mobil_id = m.id_mobil JOIN pelanggan as pe ON p.pelanggan_id = pe.id_pelanggan JOIN rincian_mobil as rm ON m.rincian_mobil_id = rm.id_rincian_mobil WHERE id_pelanggan = " + _id_pelanggan + ";";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmd.Dispose();

                    nama_lengkap.Text = dt.Rows[0][0].ToString();
                    no_telp.Text = dt.Rows[0][1].ToString();
                    nik.Text = dt.Rows[0][2].ToString();
                    alamat.Text = dt.Rows[0][3].ToString();
                    nama_mobil.Text = dt.Rows[0][4].ToString();
                    jml_penumpang.Text = dt.Rows[0][5].ToString() + " orang";
                    bahan_bakar.Text = dt.Rows[0][6].ToString() + "km/l";
                    durasi_sewa.Text = dt.Rows[0][7].ToString() + " hari";

                    connection.Close();

                }
            }
            catch (Exception ex) { }
        }

        protected void hub_admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://api.whatsapp.com/send?phone=088228362294&text=hi%0Ajoss&source=&data=");
        }
    }
}