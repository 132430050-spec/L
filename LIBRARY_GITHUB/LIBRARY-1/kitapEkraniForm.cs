using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LIBRARY_1
{
    public partial class kitapEkraniForm : Form

    {
        private string baglantiString = "Server=172.21.54.253;Database=26_132430050;User ID =26_132430050;Pwd=İnif123.;";
        public string uyeRolu ;
        public kitapEkraniForm(string rol)
        {
            InitializeComponent();
            uyeRolu= rol;

        }

        private void kitapEkraniForm_Load(object sender, EventArgs e)
        {
            if (uyeRolu == "yonetici")
            {
                // YÖNETİCİ: Hepsini görür
                islemler1_groupBox1.Visible = true;
                islemler2_groupBox2.Visible = true;

            }
            else if ((uyeRolu == "gorevli"))
            {
                // GÖREVLİ: Sadece groupBox1 görünür
                islemler1_groupBox1.Visible = true;
                islemler2_groupBox2.Visible = false;

            }
            else if ((uyeRolu == "uye"))
            {
                // ÜYE: Hiçbir grup görünmez
                islemler1_groupBox1.Visible = false;
                islemler2_groupBox2.Visible = false;

            }




        }

        private void oduncAlma_button2_Click(object sender, EventArgs e)
        {
            oducAlmaEkranıForm oduncForm = new oducAlmaEkranıForm();
            oduncForm.Show();

        }

        private void uyeBilgisi_button1_Click(object sender, EventArgs e)
        {
            uyeBilgisiForm uyeForm = new uyeBilgisiForm();
            uyeForm.Show();
        }

        private void edebiDönemler_button5_Click(object sender, EventArgs e)
        {
            edebiDonemlerForm edbform = new edebiDonemlerForm();
            edbform.Show();
        }

        private void kitapListesi_button4_Click(object sender, EventArgs e)
        {
            kitapListesiForm listeform = new kitapListesiForm();
            listeform.Show();
        }

        private void raporlama_button3_Click(object sender, EventArgs e)
        {
            raporlamaForm raporform = new raporlamaForm();
            raporform.Show();
        }
    }
}

