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
    public partial class İlacHastaBilgileri : Form
    {
        public İlacHastaBilgileri()
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
                İlacHastaAna_dataGridView.DataSource = dt;
               
            }
            komut.Dispose();
            baglanti.Close();
        }
        private void İlacHastaBilgileri_Load(object sender, EventArgs e)
        {
            verileri_goster("select tckimlik,barkodno1,barkodno2,barkodno3,barkodno4,barkodno5 from recetebilgileri");
        }
    }
}
