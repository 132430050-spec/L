namespace LIBRARY_1
{
    partial class kitapEkraniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitapEkraniForm));
            uyeBilgisi_button1 = new Button();
            oduncAlma_button2 = new Button();
            raporlama_button3 = new Button();
            kitapListesi_button4 = new Button();
            islemler1_groupBox1 = new GroupBox();
            islemler2_groupBox2 = new GroupBox();
            edebiDönemler_button5 = new Button();
            islemler1_groupBox1.SuspendLayout();
            islemler2_groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // uyeBilgisi_button1
            // 
            uyeBilgisi_button1.BackColor = Color.OliveDrab;
            uyeBilgisi_button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            uyeBilgisi_button1.Location = new Point(126, 32);
            uyeBilgisi_button1.Name = "uyeBilgisi_button1";
            uyeBilgisi_button1.Size = new Size(129, 48);
            uyeBilgisi_button1.TabIndex = 0;
            uyeBilgisi_button1.Text = "Üye Bilgisi";
            uyeBilgisi_button1.UseVisualStyleBackColor = false;
            uyeBilgisi_button1.Click += uyeBilgisi_button1_Click;
            // 
            // oduncAlma_button2
            // 
            oduncAlma_button2.BackColor = Color.OliveDrab;
            oduncAlma_button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            oduncAlma_button2.Location = new Point(6, 32);
            oduncAlma_button2.Name = "oduncAlma_button2";
            oduncAlma_button2.Size = new Size(114, 48);
            oduncAlma_button2.TabIndex = 1;
            oduncAlma_button2.Text = "Ödünç Alma";
            oduncAlma_button2.UseVisualStyleBackColor = false;
            oduncAlma_button2.Click += oduncAlma_button2_Click;
            // 
            // raporlama_button3
            // 
            raporlama_button3.BackColor = Color.OliveDrab;
            raporlama_button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            raporlama_button3.Location = new Point(19, 32);
            raporlama_button3.Name = "raporlama_button3";
            raporlama_button3.Size = new Size(113, 48);
            raporlama_button3.TabIndex = 2;
            raporlama_button3.Text = "Raporlama";
            raporlama_button3.UseVisualStyleBackColor = false;
            raporlama_button3.Click += raporlama_button3_Click;
            // 
            // kitapListesi_button4
            // 
            kitapListesi_button4.BackColor = Color.OliveDrab;
            kitapListesi_button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kitapListesi_button4.Location = new Point(133, 105);
            kitapListesi_button4.Name = "kitapListesi_button4";
            kitapListesi_button4.Size = new Size(148, 48);
            kitapListesi_button4.TabIndex = 3;
            kitapListesi_button4.Text = "Kitap Listesi";
            kitapListesi_button4.UseVisualStyleBackColor = false;
            kitapListesi_button4.Click += kitapListesi_button4_Click;
            // 
            // islemler1_groupBox1
            // 
            islemler1_groupBox1.BackColor = Color.OliveDrab;
            islemler1_groupBox1.Controls.Add(uyeBilgisi_button1);
            islemler1_groupBox1.Controls.Add(oduncAlma_button2);
            islemler1_groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            islemler1_groupBox1.Location = new Point(218, 204);
            islemler1_groupBox1.Name = "islemler1_groupBox1";
            islemler1_groupBox1.Size = new Size(266, 90);
            islemler1_groupBox1.TabIndex = 5;
            islemler1_groupBox1.TabStop = false;
            islemler1_groupBox1.Text = "İŞLEMLER";
            // 
            // islemler2_groupBox2
            // 
            islemler2_groupBox2.BackColor = Color.OliveDrab;
            islemler2_groupBox2.Controls.Add(raporlama_button3);
            islemler2_groupBox2.Location = new Point(490, 204);
            islemler2_groupBox2.Name = "islemler2_groupBox2";
            islemler2_groupBox2.Size = new Size(158, 90);
            islemler2_groupBox2.TabIndex = 6;
            islemler2_groupBox2.TabStop = false;
            // 
            // edebiDönemler_button5
            // 
            edebiDönemler_button5.BackColor = Color.OliveDrab;
            edebiDönemler_button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            edebiDönemler_button5.Location = new Point(659, 403);
            edebiDönemler_button5.Name = "edebiDönemler_button5";
            edebiDönemler_button5.Size = new Size(179, 86);
            edebiDönemler_button5.TabIndex = 4;
            edebiDönemler_button5.Text = "Edebi Dönemler";
            edebiDönemler_button5.UseVisualStyleBackColor = false;
            edebiDönemler_button5.Click += edebiDönemler_button5_Click;
            // 
            // kitapEkraniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(908, 532);
            Controls.Add(islemler1_groupBox1);
            Controls.Add(islemler2_groupBox2);
            Controls.Add(kitapListesi_button4);
            Controls.Add(edebiDönemler_button5);
            Name = "kitapEkraniForm";
            Text = "kitapEkraniForm";
            Load += kitapEkraniForm_Load;
            islemler1_groupBox1.ResumeLayout(false);
            islemler2_groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button uyeBilgisi_button1;
        private Button oduncAlma_button2;
        private Button raporlama_button3;
        private Button kitapListesi_button4;
        private GroupBox islemler1_groupBox1;
        private GroupBox islemler2_groupBox2;
        private Button edebiDönemler_button5;
    }
}