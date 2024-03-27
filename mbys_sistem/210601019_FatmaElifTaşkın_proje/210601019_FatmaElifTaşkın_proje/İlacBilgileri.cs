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
    public partial class İlacBilgileri : Form
    {
        public İlacBilgileri()
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
               IlavBilgileri_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }
        private void İlacBilgileriListele_button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();

            komut_ekle.Connection = baglanti;
            komut_ekle.Parameters.AddWithValue("@ad", İlacAd_textBox.Text);
            komut_ekle.Parameters.AddWithValue("@barkodno", Convert.ToInt32( İlacBarkodNo_textBox.Text));
            komut_ekle.Parameters.AddWithValue("@tip", İlacTip_textBox.Text);




            if (İlacTip_textBox.Text == null && İlacAd_textBox.Text == null && İlacBarkodNo_textBox.Text == null)
            {
                MessageBox.Show("Girilen Bilgiler Eksiktir!");
            }


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into İlacbilgileri(ad,tip,barkodno) values(@ad,@tip,@barkodno)";



            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                IlavBilgileri_dataGridView.DataSource = dt;
            }
            komut_ekle.Dispose();
            baglanti.Close();
            verileri_goster("select * from İlacbilgileri");

        }

        private void İlacBilgileri_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from İlacbilgileri");
        }
    }
}
