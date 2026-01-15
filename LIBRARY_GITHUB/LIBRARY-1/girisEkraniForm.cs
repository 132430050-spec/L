using System;
using System.Windows.Forms;
using LIBRARY_1.BLL; // BLL katmanýný dahil ettik

namespace LIBRARY_1
{
    public partial class girisEkraniForm : Form
    {
        private KullaniciBLL _kullaniciBll = new KullaniciBLL();

        public girisEkraniForm()
        {
            InitializeComponent();
        }

        private void giris_button1_Click(object sender, EventArgs e)
        {
            string ad = kullaniciAditextBox1.Text.Trim();
            string sifre = sifretextBox2.Text.Trim();

            try
            {
                // BLL üzerinden kullanýcýyý doðruluyoruz
                string rol = _kullaniciBll.KullaniciDogrula(ad, sifre);

                if (!string.IsNullOrEmpty(rol))
                {
                    sonuc_label1.Text = "Giriþ Baþarýlý";
                    sonuc_label1.ForeColor = System.Drawing.Color.Green;

                    // Rol bilgisini ana forma göndererek açýyoruz
                    kitapEkraniForm kitapForm = new kitapEkraniForm(rol);
                    kitapForm.Show();
                    this.Hide();
                }
                else
                {
                    sonuc_label1.Text = "Giriþ Baþarýsýz: Hatalý bilgiler.";
                    sonuc_label1.ForeColor = System.Drawing.Color.Red;
                    sifretextBox2.Clear();
                }
            }
            catch (Exception ex)
            {
                // BLL'den fýrlatýlan "boþ býrakýlamaz" gibi hatalarý yakalar
                MessageBox.Show(ex.Message, "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}