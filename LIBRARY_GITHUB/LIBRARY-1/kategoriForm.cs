using System;
using System.Windows.Forms;
using LIBRARY_1.BLL;

namespace LIBRARY_1
{
    public partial class kategoriForm : Form
    {
        private RaporBLL _raporBll = new RaporBLL();

        public kategoriForm()
        {
            InitializeComponent();
        }

        private void kategoriForm_Load(object sender, EventArgs e)
        {
            kategoriBazli_dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kategoriBazli_dataGridView1.ReadOnly = true;
            kategoriBazli_dataGridView1.AllowUserToAddRows = false;

            try
            {
                // Kategori verileri BLL'den çekiliyor
                kategoriBazli_dataGridView1.DataSource = _raporBll.KategoriRaporuGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori raporu yüklenemedi: " + ex.Message);
            }
        }
    }
}