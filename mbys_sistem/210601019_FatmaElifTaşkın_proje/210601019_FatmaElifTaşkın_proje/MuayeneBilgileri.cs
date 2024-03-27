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
    public partial class MuayeneBilgileri : Form
    {
        public MuayeneBilgileri()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=MBYS;User Id=postgres;Password=1234");
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
                MuayeneDetayları_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }
        private void Muayeneolustur_button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut_ekle = new NpgsqlCommand();

                komut_ekle.Connection = baglanti;
                komut_ekle.Parameters.AddWithValue("@tckimlik", MuayeneTc_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(MuayeneTarihi_dateTimePicker1.Value));
                komut_ekle.Parameters.AddWithValue("@sikayet", MuayeneSikayet_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@teşhis",MuayeneTeşhis_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@ReceteNo", Convert.ToInt32(MuayeneReceteNumarasi_textBox.Text));



                if (MuayeneTc_textBox.Text == null && MuayeneSikayet_textBox.Text == null && MuayeneTeşhis_textBox.Text == null && MuayeneReceteNumarasi_textBox.Text == null)
                {
                    MessageBox.Show("Girilen Bilgiler Eksiktir!");
                }


                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into muayenebilgileri(tckimlik, tarih, sikayet, teşhis, receteno) values(@tckimlik,@tarih, @sikayet, @teşhis, @ReceteNo) order by tarih";



                NpgsqlDataReader dr = komut_ekle.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    MuayeneDetayları_dataGridView.DataSource = dt;
                }
                komut_ekle.Dispose();
                baglanti.Close();
                verileri_goster("select * from muayenebilgileri");


            }

            catch (NpgsqlException ex)
            {
                if (ex.Message.Contains("unique"))
                {
                    MessageBox.Show("Girilen Tc ve Muayene Tarihi vaya Reçete Numarası önceden girilmiş!");
                }
                else if(ex.Message.Contains("foreign key"))
                {
                    MessageBox.Show("Girilen Kimlik Numarasına Ait Hasta Bilgisi Bulanamamıştır!");
                }
                else
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void MuayeneBilgileri_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from muayenebilgileri");
        }
    }
}

