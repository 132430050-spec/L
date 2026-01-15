using System;
using System.Windows.Forms;
using LIBRARY_1.BLL; // BLL katmanı referansı

namespace LIBRARY_1
{
    public partial class aktifUyeForm : Form
    {
        // Rapor iş mantığı sınıfından bir nesne türetiyoruz
        private RaporBLL _raporBll = new RaporBLL();

        public aktifUyeForm()
        {
            InitializeComponent();
        }

        private void aktifUyeForm_Load(object sender, EventArgs e)
        {
            // Grid ayarları
            aktifUye_dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            aktifUye_dataGridView1.ReadOnly = true;
            aktifUye_dataGridView1.AllowUserToAddRows = false;

            try
            {
                // Veriyi BLL üzerinden çekiyoruz
                aktifUye_dataGridView1.DataSource = _raporBll.AktifUyeleriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aktif üyeler listelenirken hata oluştu: " + ex.Message);
            }
        }
    }
}