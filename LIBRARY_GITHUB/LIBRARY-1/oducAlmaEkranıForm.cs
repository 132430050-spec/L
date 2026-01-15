using System;
using System.Windows.Forms;
using LIBRARY_1.BLL; // BLL katmanını bağladık

namespace LIBRARY_1
{
    public partial class oducAlmaEkranıForm : Form
    {
        private OduncBLL _bll = new OduncBLL();

        public oducAlmaEkranıForm()
        {
            InitializeComponent();
        }

        private void VerileriYukle()
        {
            try
            {
                oduncAlma_dataGridView1.DataSource = _bll.OduncListesi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void oducAlmaEkranıForm_Load(object sender, EventArgs e)
        {
            VerileriYukle();
            // Buton sütunu kontrolü
            if (oduncAlma_dataGridView1.Columns["İade Al"] == null)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "İade Al";
                btn.HeaderText = "İade İşlemi";
                btn.Text = "Teslim Al";
                btn.UseColumnTextForButtonValue = true;
                oduncAlma_dataGridView1.Columns.Add(btn);
            }
        }

        private void oduncVer_button1_Click(object sender, EventArgs e)
        {
            if (_bll.YeniOduncVer(uyeAdSoyad_textBox1.Text, kitapAdi_textBox1.Text))
            {
                MessageBox.Show("Kitap başarıyla verildi.");
                VerileriYukle();
            }
            else
            {
                MessageBox.Show("Lütfen alanları kontrol edin.");
            }
        }

        private void oduncAlma_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && oduncAlma_dataGridView1.Columns[e.ColumnIndex].Name == "İade Al")
            {
                var cellValue = oduncAlma_dataGridView1.Rows[e.RowIndex].Cells["İşlem No"].Value;
                if (cellValue != null)
                {
                    if (MessageBox.Show("Teslim alıyor musunuz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (_bll.KitapIadeAl(Convert.ToInt32(cellValue)))
                        {
                            MessageBox.Show("İade tarihi güncellendi.");
                            VerileriYukle();
                        }
                    }
                }
            }
        }
    }
}