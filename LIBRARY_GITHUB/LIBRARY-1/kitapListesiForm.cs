using System;
using System.Windows.Forms;
using LIBRARY_1.BLL; // BLL katmanını dahil ettik

namespace LIBRARY_1
{
    public partial class kitapListesiForm : Form
    {
        // BLL nesnemizi oluşturuyoruz
        private KitapBLL _kitapBll = new KitapBLL();

        public kitapListesiForm()
        {
            InitializeComponent();
        }

        private void kitapListesiForm_Load(object sender, EventArgs e)
        {
            // Grid Tasarım Ayarları
            kitapListesi_dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kitapListesi_dataGridView1.ReadOnly = true;
            kitapListesi_dataGridView1.AllowUserToAddRows = false;

            VerileriYukle();
        }

        private void VerileriYukle()
        {
            try
            {
                // Veriyi doğrudan BLL'den talep ediyoruz
                kitapListesi_dataGridView1.DataSource = _kitapBll.KitaplariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap listesi yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}