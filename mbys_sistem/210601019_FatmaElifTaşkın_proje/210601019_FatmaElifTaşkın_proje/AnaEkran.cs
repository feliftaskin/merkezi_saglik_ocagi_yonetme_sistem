using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210601019_FatmaElifTaşkın_proje
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void HastaBilgileriGoruntule_button_Click(object sender, EventArgs e)
        {
            HastaBilgileri hastaBilgileri = new HastaBilgileri();
            hastaBilgileri.ShowDialog();

        }

        private void MuayeneBilgileriGoruntule_button_Click(object sender, EventArgs e)
        {
            MuayeneBilgileri muayeneBilgileri = new MuayeneBilgileri();
            muayeneBilgileri.ShowDialog();
        }

        private void ReceteOlustur_button_Click(object sender, EventArgs e)
        {
            ReceteBilgileri receteBilgileri = new ReceteBilgileri();
            receteBilgileri.ShowDialog();
        }

        private void İlacBilgileri_button_Click(object sender, EventArgs e)
        {
            İlacBilgileri ilacBilgileri = new İlacBilgileri();
            ilacBilgileri.ShowDialog();
        }

        private void İlac_Hasta_button_Click(object sender, EventArgs e)
        {
            İlacHastaBilgileri ilacHastaBilgileri = new İlacHastaBilgileri();
            ilacHastaBilgileri.ShowDialog();
        }
    }
}
