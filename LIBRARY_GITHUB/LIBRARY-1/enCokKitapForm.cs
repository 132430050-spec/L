using System;
using System.Windows.Forms;
using LIBRARY_1.BLL;

namespace LIBRARY_1
{
    public partial class enCokKitapForm : Form
    {
        private RaporBLL _raporBll = new RaporBLL();

        public enCokKitapForm()
        {
            InitializeComponent();
        }

        private void enCokKitapForm_Load(object sender, EventArgs e)
        {
            enCokTercih_dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            enCokTercih_dataGridView1.ReadOnly = true;
            enCokTercih_dataGridView1.AllowUserToAddRows = false;

            try
            {
                // En çok tercih edilenler listesi BLL'den geliyor
                enCokTercih_dataGridView1.DataSource = _raporBll.EnCokTercihEdilenleriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstatistikler yüklenemedi: " + ex.Message);
            }
        }
    }
}