namespace LIBRARY_1
{
    partial class oducAlmaEkranıForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oducAlmaEkranıForm));
            oduncAlma_dataGridView1 = new DataGridView();
            kitapAdı_label1 = new Label();
            kitapAdi_textBox1 = new TextBox();
            oduncVer_button1 = new Button();
            label1 = new Label();
            uyeAdSoyad_textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)oduncAlma_dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // oduncAlma_dataGridView1
            // 
            oduncAlma_dataGridView1.BackgroundColor = Color.DarkKhaki;
            oduncAlma_dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            oduncAlma_dataGridView1.Location = new Point(277, 43);
            oduncAlma_dataGridView1.Name = "oduncAlma_dataGridView1";
            oduncAlma_dataGridView1.RowHeadersWidth = 51;
            oduncAlma_dataGridView1.Size = new Size(511, 381);
            oduncAlma_dataGridView1.TabIndex = 0;
            oduncAlma_dataGridView1.CellContentClick += oduncAlma_dataGridView1_CellContentClick;
            // 
            // kitapAdı_label1
            // 
            kitapAdı_label1.AutoSize = true;
            kitapAdı_label1.BackColor = Color.FromArgb(255, 255, 192);
            kitapAdı_label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kitapAdı_label1.Location = new Point(36, 167);
            kitapAdı_label1.Name = "kitapAdı_label1";
            kitapAdı_label1.Size = new Size(78, 20);
            kitapAdı_label1.TabIndex = 1;
            kitapAdı_label1.Text = "Kitap Adı:";
            // 
            // kitapAdi_textBox1
            // 
            kitapAdi_textBox1.Location = new Point(120, 167);
            kitapAdi_textBox1.Name = "kitapAdi_textBox1";
            kitapAdi_textBox1.Size = new Size(125, 27);
            kitapAdi_textBox1.TabIndex = 3;
            // 
            // oduncVer_button1
            // 
            oduncVer_button1.BackColor = Color.OliveDrab;
            oduncVer_button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            oduncVer_button1.Location = new Point(136, 253);
            oduncVer_button1.Name = "oduncVer_button1";
            oduncVer_button1.Size = new Size(94, 29);
            oduncVer_button1.TabIndex = 5;
            oduncVer_button1.Text = "Ödünç Ver";
            oduncVer_button1.UseVisualStyleBackColor = false;
            oduncVer_button1.Click += oduncVer_button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(2, 220);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 6;
            label1.Text = "Üye Ad-Soyad:";
            // 
            // uyeAdSoyad_textBox1
            // 
            uyeAdSoyad_textBox1.Location = new Point(120, 220);
            uyeAdSoyad_textBox1.Name = "uyeAdSoyad_textBox1";
            uyeAdSoyad_textBox1.Size = new Size(125, 27);
            uyeAdSoyad_textBox1.TabIndex = 7;
            // 
            // oducAlmaEkranıForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(uyeAdSoyad_textBox1);
            Controls.Add(label1);
            Controls.Add(oduncVer_button1);
            Controls.Add(kitapAdi_textBox1);
            Controls.Add(kitapAdı_label1);
            Controls.Add(oduncAlma_dataGridView1);
            Name = "oducAlmaEkranıForm";
            Text = "oducAlmaEkranıForm";
            Load += oducAlmaEkranıForm_Load;
            ((System.ComponentModel.ISupportInitialize)oduncAlma_dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView oduncAlma_dataGridView1;
        private Label kitapAdı_label1;
        private TextBox kitapAdi_textBox1;
        private Button oduncVer_button1;
        private Label label1;
        private TextBox uyeAdSoyad_textBox1;
    }
}