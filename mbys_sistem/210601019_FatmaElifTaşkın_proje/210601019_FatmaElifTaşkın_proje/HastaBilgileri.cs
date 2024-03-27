using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace _210601019_FatmaElifTaşkın_proje
{
    public partial class HastaBilgileri : Form
    {
        public HastaBilgileri()
        {
            InitializeComponent();
        }


        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=MBYS; User Id=postgres;Password=1234");

        public void verileri_goster(string txt)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                hastabilgi_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hastabilgiolustur_button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut_ekle = new NpgsqlCommand();

                komut_ekle.Connection = baglanti;
                komut_ekle.Parameters.AddWithValue("@ad", hastabilgiisim_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@soyad", hastabilgisoyisim_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@tckimlik", hastabilgitc_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@dogumtarihi", Convert.ToDateTime(hastabilgidogumtarihi_dateTimePicker.Value));
                komut_ekle.Parameters.AddWithValue("@dogumyeri", hastabilgidgmyeri_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@yer", hastabilgikonum_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@medenidurum", hastabilgimedenidrm_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@adres", hastabilgiadres_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@telefon", hastabilgigsm_textBox.Text);



                if (hastabilgiisim_textBox.Text == null && hastabilgisoyisim_textBox.Text == null && hastabilgitc_textBox.Text == null && hastabilgidgmyeri_textBox.Text == null &&
                 hastabilgikonum_textBox.Text == null && hastabilgimedenidrm_textBox.Text == null && hastabilgiadres_textBox.Text == null &&
                 hastabilgigsm_textBox.Text == null)
                {
                    MessageBox.Show("Girilen Bilgiler Eksiktir!");
                }



                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into hastabilgileri(ad,soyad,tckimlik,dogumtarihi,dogumyeri,yer,medenidurum,adres,telefon) values(@ad,@soyad,@tckimlik,@dogumtarihi,@dogumyeri,@yer,@medenidurum,@adres,@telefon)";



                NpgsqlDataReader dr = komut_ekle.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    hastabilgi_dataGridView.DataSource = dt;
                }

                komut_ekle.Dispose();
                baglanti.Close();
                verileri_goster("select * from hastabilgileri");
            }

            catch (NpgsqlException ex)
            {
                if (ex.Message.Contains("unique"))
                {
                    MessageBox.Show("Girilen Hasta Kaydı Sistemde Zaten Mevcuttur");
                }
            }
        }

        private void HastaBilgileri_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from hastabilgileri");
        }
    }
}
