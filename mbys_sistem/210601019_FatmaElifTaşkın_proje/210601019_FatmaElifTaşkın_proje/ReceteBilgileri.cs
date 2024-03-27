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
    public partial class ReceteBilgileri : Form
    {
        public ReceteBilgileri()
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
              ReceteBilgileri_dataGridView1.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }

        public void verileri_goster2(string txt)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand();
            komut1.Connection = baglanti;
            komut1.CommandType = CommandType.Text;
            komut1.CommandText = txt;
            NpgsqlDataReader dr = komut1.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
               İlacBilgileri_dataGridView.DataSource = dt;
            }
            komut1.Dispose();
            baglanti.Close();
        }
        private void Receteolustur_button_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                NpgsqlCommand komut_ekle = new NpgsqlCommand();
                komut_ekle.Connection = baglanti;
                komut_ekle.Parameters.AddWithValue("@tckimlik", ReceteHastaTc_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@tanı", ReceteTanı_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@ad", ReceteHastaAdi_textBox1.Text);
                komut_ekle.Parameters.AddWithValue("@soyad", ReceteHastaSoyad_textBox.Text);
                komut_ekle.Parameters.AddWithValue("@receteno", Convert.ToInt32(ReceteNo_textBox.Text));
                komut_ekle.Parameters.AddWithValue("@barkodno1", Convert.ToInt32(Receteilacnumarasi1_textBox.Text));
                komut_ekle.Parameters.AddWithValue("@ilacsayisi1", Convert.ToInt32(İlacSayisi1_comboBox.Text));

                komut_ekle.Parameters.AddWithValue("@barkodno2", Convert.ToInt32(Receteilacnumarasi2_textBox.Text));
                komut_ekle.Parameters.AddWithValue("@ilacsayisi2", Convert.ToInt32(İlacSayisi2_comboBox.Text));

                komut_ekle.Parameters.AddWithValue("@barkodno3", Convert.ToInt32(ReceteİlacNo_textBox.Text));
                komut_ekle.Parameters.AddWithValue("@ilacsayisi3", Convert.ToInt32(İlacSayisi3_comboBox.Text));

                komut_ekle.Parameters.AddWithValue("@barkodno4", Convert.ToInt32(Receteilacnumarasi4_textBox.Text));
                komut_ekle.Parameters.AddWithValue("@ilacsayisi4", Convert.ToInt32(İlacSayisi4_comboBox.Text));

                komut_ekle.Parameters.AddWithValue("@barkodno5", Convert.ToInt32(Receteilacnumarasi5_textBox.Text));
                komut_ekle.Parameters.AddWithValue("@ilacsayisi5", Convert.ToInt32(İlacsayisi5_comboBox.Text));

                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into recetebilgileri(tckimlik,tanı,receteno,ad,soyad,barkodno1,ilacsayisi1,barkodno2,ilacsayisi2,barkodno3,ilacsayisi3,barkodno4,ilacsayisi4,barkodno5,ilacsayisi5) values(@tckimlik,@tanı,@receteno,@ad,@soyad,@barkodno1,@ilacsayisi1,@barkodno2,@ilacsayisi2,@barkodno3,@ilacsayisi3,@barkodno4,@ilacsayisi4,@barkodno5,@ilacsayisi5)";



                if (ReceteHastaAdi_textBox1.Text == null && ReceteHastaSoyad_textBox.Text == null && ReceteHastaTc_textBox.Text == null && ReceteTanı_textBox.Text == null && (
                  Receteilacnumarasi1_textBox.Text == null || Receteilacnumarasi2_textBox.Text == null || Receteilacnumarasi4_textBox.Text == null ||
                  Receteilacnumarasi5_textBox.Text == null || ReceteİlacNo_textBox.Text == null))
                {
                    MessageBox.Show("Girilen Bilgiler Eksiktir!");
                }



                if (Receteilacnumarasi1_textBox.Text == Receteilacnumarasi2_textBox.Text && Receteilacnumarasi2_textBox.Text == Receteilacnumarasi4_textBox.Text && Receteilacnumarasi4_textBox.Text == Receteilacnumarasi5_textBox.Text && Receteilacnumarasi5_textBox.Text == ReceteİlacNo_textBox.Text)
                {
                    MessageBox.Show("Her kutuya Farklı İlaç adı Girilmelidir");
                }


                if (ReceteHastaAdi_textBox1.Text == null && ReceteHastaTc_textBox.Text == null && ReceteHastaSoyad_textBox.Text == null && ReceteTanı_textBox.Text == null && ReceteNo_textBox.Text == null && Receteilacnumarasi1_textBox.Text == null && İlacSayisi1_comboBox.Text == null)
                {
                    MessageBox.Show("Girilen Bilgiler Eksiktir!");
                }

                
                else
                {
                    NpgsqlDataReader dr = komut_ekle.ExecuteReader();
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        ReceteBilgileri_dataGridView1.DataSource = dt;
                    }
                    komut_ekle.Dispose();
                    baglanti.Close();

                    verileri_goster("select * from recetebilgileri");
                }
            }

            catch (NpgsqlException ex)
            {
                if (ex.Message.Contains("unique"))
                {
                    MessageBox.Show("Girilen Tc ve Muayene Tarihi vaya Reçete Numarası önceden girilmiş!");
                }
                else if (ex.Message.Contains("barkodno"))
                {
                    MessageBox.Show("Girilen Barkod Numarasında ilaç Kaydı Yoktur!");
                }
                else if (ex.Message.Contains("foreign key"))
                {
                    MessageBox.Show("Girilen Kimlik Numarasına veya Reçete Numarasına Ait Hasta Bilgisi Bulanamamıştır!");
                }
                else
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void ReceteBilgileri_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from recetebilgileri");
            verileri_goster2("select * from İlacbilgileri");
        }

        private void İlacBilgileri_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
