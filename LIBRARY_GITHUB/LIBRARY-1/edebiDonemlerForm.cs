using System;
using System.Drawing;
using System.Windows.Forms;
using LIBRARY_1.BLL;    // BLL katmanını dahil ettik
using LIBRARY_1.Entity; // Nesneyi tanımak için

namespace LIBRARY_1
{
    public partial class edebiDonemlerForm : Form
    {
        private DonemBLL _donemBll = new DonemBLL();

        public edebiDonemlerForm()
        {
            InitializeComponent();
        }

        private void edebiDonemlerForm_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            richTextBox1.Clear();

            try
            {
                // Veriyi BLL üzerinden çekiyoruz
                Donem dr = _donemBll.RastgeleDonemGetir();

                if (dr != null)
                {
                    // --- DÖNEM BAŞLIĞI VE TARİHLER ---
                    richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
                    richTextBox1.AppendText("Dönem Adı: " + dr.DonemAdi + "\n");

                    richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
                    richTextBox1.AppendText("Başlangıç Tarihi: " + dr.BaslangicTarihi + "\n");
                    richTextBox1.AppendText("Bitiş Tarihi: " + dr.BitisTarihi + "\n\n");

                    // --- GENEL BİLGİ ---
                    richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
                    richTextBox1.AppendText("Genel Bilgi:\n");
                    richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
                    richTextBox1.AppendText(dr.GenelBilgi + "\n\n");

                    // --- YAZARLAR ---
                    richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
                    richTextBox1.AppendText("Yazarlar:\n");
                    richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
                    richTextBox1.AppendText(dr.Yazarlar + "\n");

                    // --- AYRAÇ ---
                    richTextBox1.AppendText("\n------------------------------------------------------------\n\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edebi dönem bilgisi yüklenirken hata oluştu: " + ex.Message);
            }
        }
    }
}