namespace LIBRARY_1
{
    partial class raporlamaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(raporlamaForm));
            enCokTercih_button1 = new Button();
            uyeAktifligi_button2 = new Button();
            tarihiGeciken_button3 = new Button();
            kategoriBazlı_button4 = new Button();
            SuspendLayout();
            // 
            // enCokTercih_button1
            // 
            enCokTercih_button1.BackColor = Color.OliveDrab;
            enCokTercih_button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            enCokTercih_button1.Location = new Point(154, 153);
            enCokTercih_button1.Name = "enCokTercih_button1";
            enCokTercih_button1.Size = new Size(172, 65);
            enCokTercih_button1.TabIndex = 0;
            enCokTercih_button1.Text = "En Çok Tercih Edilen Kitaplar Listesi";
            enCokTercih_button1.UseVisualStyleBackColor = false;
            enCokTercih_button1.Click += enCokTercih_button1_Click;
            // 
            // uyeAktifligi_button2
            // 
            uyeAktifligi_button2.BackColor = Color.OliveDrab;
            uyeAktifligi_button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            uyeAktifligi_button2.Location = new Point(165, 394);
            uyeAktifligi_button2.Name = "uyeAktifligi_button2";
            uyeAktifligi_button2.Size = new Size(143, 56);
            uyeAktifligi_button2.TabIndex = 1;
            uyeAktifligi_button2.Text = "Aktif Üye Lİstesi";
            uyeAktifligi_button2.UseVisualStyleBackColor = false;
            uyeAktifligi_button2.Click += uyeAktifligi_button2_Click;
            // 
            // tarihiGeciken_button3
            // 
            tarihiGeciken_button3.BackColor = Color.OliveDrab;
            tarihiGeciken_button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tarihiGeciken_button3.Location = new Point(498, 153);
            tarihiGeciken_button3.Name = "tarihiGeciken_button3";
            tarihiGeciken_button3.Size = new Size(148, 65);
            tarihiGeciken_button3.TabIndex = 2;
            tarihiGeciken_button3.Text = "Teslim Tarihi Geciken Kitaplar";
            tarihiGeciken_button3.UseVisualStyleBackColor = false;
            tarihiGeciken_button3.Click += tarihiGeciken_button3_Click;
            // 
            // kategoriBazlı_button4
            // 
            kategoriBazlı_button4.BackColor = Color.OliveDrab;
            kategoriBazlı_button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kategoriBazlı_button4.Location = new Point(498, 394);
            kategoriBazlı_button4.Name = "kategoriBazlı_button4";
            kategoriBazlı_button4.Size = new Size(150, 56);
            kategoriBazlı_button4.TabIndex = 3;
            kategoriBazlı_button4.Text = "Kategori Bazlı Kitaplar";
            kategoriBazlı_button4.UseVisualStyleBackColor = false;
            kategoriBazlı_button4.Click += kategoriBazlı_button4_Click;
            // 
            // raporlamaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 514);
            Controls.Add(uyeAktifligi_button2);
            Controls.Add(enCokTercih_button1);
            Controls.Add(tarihiGeciken_button3);
            Controls.Add(kategoriBazlı_button4);
            Name = "raporlamaForm";
            Text = "raporlamaForm";
            Load += raporlamaForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button enCokTercih_button1;
        private Button uyeAktifligi_button2;
        private Button tarihiGeciken_button3;
        private Button kategoriBazlı_button4;
    }
}