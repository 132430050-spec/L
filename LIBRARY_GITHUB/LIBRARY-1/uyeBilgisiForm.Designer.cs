namespace LIBRARY_1
{
    partial class uyeBilgisiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeBilgisiForm));
            uyeBilgisi_dataGridView1 = new DataGridView();
            uyeEkle_button1 = new Button();
            adSoyad_textBox1 = new TextBox();
            tel_textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)uyeBilgisi_dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uyeBilgisi_dataGridView1
            // 
            uyeBilgisi_dataGridView1.BackgroundColor = Color.DarkKhaki;
            uyeBilgisi_dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uyeBilgisi_dataGridView1.Location = new Point(56, 22);
            uyeBilgisi_dataGridView1.Name = "uyeBilgisi_dataGridView1";
            uyeBilgisi_dataGridView1.RowHeadersWidth = 51;
            uyeBilgisi_dataGridView1.Size = new Size(655, 231);
            uyeBilgisi_dataGridView1.TabIndex = 0;
            uyeBilgisi_dataGridView1.CellContentClick += uyeBilgisi_dataGridView1_CellContentClick;
            // 
            // uyeEkle_button1
            // 
            uyeEkle_button1.BackColor = Color.OliveDrab;
            uyeEkle_button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            uyeEkle_button1.Location = new Point(345, 487);
            uyeEkle_button1.Name = "uyeEkle_button1";
            uyeEkle_button1.Size = new Size(94, 29);
            uyeEkle_button1.TabIndex = 1;
            uyeEkle_button1.Text = "Üye Ekle";
            uyeEkle_button1.UseVisualStyleBackColor = false;
            uyeEkle_button1.Click += uyeEkle_button1_Click;
            // 
            // adSoyad_textBox1
            // 
            adSoyad_textBox1.Cursor = Cursors.AppStarting;
            adSoyad_textBox1.Location = new Point(326, 390);
            adSoyad_textBox1.Name = "adSoyad_textBox1";
            adSoyad_textBox1.Size = new Size(125, 27);
            adSoyad_textBox1.TabIndex = 2;
            // 
            // tel_textBox2
            // 
            tel_textBox2.Location = new Point(326, 443);
            tel_textBox2.Name = "tel_textBox2";
            tel_textBox2.Size = new Size(125, 27);
            tel_textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(217, 397);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 4;
            label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(265, 443);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 5;
            label2.Text = "Tel:";
            // 
            // uyeBilgisiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 539);
            Controls.Add(uyeEkle_button1);
            Controls.Add(tel_textBox2);
            Controls.Add(adSoyad_textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(uyeBilgisi_dataGridView1);
            DoubleBuffered = true;
            Name = "uyeBilgisiForm";
            Text = "uyeBilgisiForm";
            Load += uyeBilgisiForm_Load;
            ((System.ComponentModel.ISupportInitialize)uyeBilgisi_dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView uyeBilgisi_dataGridView1;
        private Button uyeEkle_button1;
        private TextBox adSoyad_textBox1;
        private TextBox tel_textBox2;
        private Label label1;
        private Label label2;
    }
}