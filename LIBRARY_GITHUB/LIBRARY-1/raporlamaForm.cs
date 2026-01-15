using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_1
{
    public partial class raporlamaForm : Form
    {

        public raporlamaForm()
        {
            InitializeComponent();
        }

        private void enCokTercih_button1_Click(object sender, EventArgs e)
        {
            enCokKitapForm cokKitapForm = new enCokKitapForm();
            cokKitapForm.Show();
        }

        private void tarihiGeciken_button3_Click(object sender, EventArgs e)
        {
            gecikenKitapForm gecikenKitapForm = new gecikenKitapForm();
            gecikenKitapForm.Show();
        }

        private void uyeAktifligi_button2_Click(object sender, EventArgs e)
        {
            aktifUyeForm aktifUyeForm = new aktifUyeForm();
            aktifUyeForm.Show();
        }

        private void kategoriBazlı_button4_Click(object sender, EventArgs e)
        {
            kategoriForm kategoriForm = new kategoriForm();
            kategoriForm.Show();

        }

        private void raporlamaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
