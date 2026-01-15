using System;
using System.Windows.Forms;
using LIBRARY_1.BLL;

namespace LIBRARY_1
{
    public partial class gecikenKitapForm : Form
    {
        private RaporBLL _raporBll = new RaporBLL();

        public gecikenKitapForm()
        {
            InitializeComponent();
        }

        private void gecikenKitapForm_Load(object sender, EventArgs e)
        {
            gecikenKitap_dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gecikenKitap_dataGridView1.ReadOnly = true;
            gecikenKitap_dataGridView1.AllowUserToAddRows = false;

            try
            {
                // Gecikme raporunu BLL'den alıyoruz
                gecikenKitap_dataGridView1.DataSource = _raporBll.GecikenleriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gecikme listesi yüklenirken hata: " + ex.Message);
            }
        }
    }
}