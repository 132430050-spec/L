using System;
using System.Windows.Forms;
using LIBRARY_1.BLL; // BLL'i bağladık

namespace LIBRARY_1
{
    public partial class uyeBilgisiForm : Form
    {
        private UyeBLL _uyeBll = new UyeBLL();

        public uyeBilgisiForm()
        {
            InitializeComponent();
        }

        private void VerileriYukle()
        {
            try
            {
                uyeBilgisi_dataGridView1.DataSource = _uyeBll.UyeListesi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void uyeBilgisiForm_Load(object sender, EventArgs e)
        {
            VerileriYukle();

            // Butonları ekleme (Eğer tasarımda yoksa)
            if (uyeBilgisi_dataGridView1.Columns["btnSil"] == null)
            {
                DataGridViewButtonColumn btnSil = new DataGridViewButtonColumn();
                btnSil.HeaderText = "Sil";
                btnSil.Name = "btnSil";
                btnSil.Text = "Sil";
                btnSil.UseColumnTextForButtonValue = true;
                uyeBilgisi_dataGridView1.Columns.Add(btnSil);

                DataGridViewButtonColumn btnDuzenle = new DataGridViewButtonColumn();
                btnDuzenle.HeaderText = "Düzenle";
                btnDuzenle.Name = "btnDuzenle";
                btnDuzenle.Text = "Düzenle";
                btnDuzenle.UseColumnTextForButtonValue = true;
                uyeBilgisi_dataGridView1.Columns.Add(btnDuzenle);
            }
        }

        private void uyeEkle_button1_Click(object sender, EventArgs e)
        {
            if (_uyeBll.YeniUyeEkle(adSoyad_textBox1.Text, tel_textBox2.Text))
            {
                MessageBox.Show("Üye başarıyla eklendi.");
                adSoyad_textBox1.Clear();
                tel_textBox2.Clear();
                VerileriYukle();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
        }

        private void uyeBilgisi_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // SİLME İŞLEMİ
            if (uyeBilgisi_dataGridView1.Columns[e.ColumnIndex].Name == "btnSil")
            {
                if (MessageBox.Show("Bu üyeyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(uyeBilgisi_dataGridView1.Rows[e.RowIndex].Cells["Üye ID"].Value);
                    if (_uyeBll.UyeSil(id))
                    {
                        MessageBox.Show("Üye silindi.");
                        VerileriYukle();
                    }
                }
            }

            // DÜZENLEME BİLGİSİ
            if (uyeBilgisi_dataGridView1.Columns[e.ColumnIndex].Name == "btnDuzenle")
            {
                MessageBox.Show("Bu satırı doğrudan tablo üzerinde değiştirebilirsiniz.", "Bilgi");
                uyeBilgisi_dataGridView1.Rows[e.RowIndex].ReadOnly = false;
            }
        }
    }
}