namespace LIBRARY_1
{
    partial class girisEkraniForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisEkraniForm));
            kullaniciAdi_label1 = new Label();
            sifre_label2 = new Label();
            kullaniciAditextBox1 = new TextBox();
            sifretextBox2 = new TextBox();
            giris_button1 = new Button();
            sonuc_label1 = new Label();
            SuspendLayout();
            // 
            // kullaniciAdi_label1
            // 
            kullaniciAdi_label1.AutoSize = true;
            kullaniciAdi_label1.BackColor = Color.FromArgb(255, 255, 192);
            kullaniciAdi_label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kullaniciAdi_label1.Location = new Point(249, 337);
            kullaniciAdi_label1.Name = "kullaniciAdi_label1";
            kullaniciAdi_label1.Size = new Size(100, 20);
            kullaniciAdi_label1.TabIndex = 0;
            kullaniciAdi_label1.Text = "Kullanıcı Adı:";
            // 
            // sifre_label2
            // 
            sifre_label2.AutoSize = true;
            sifre_label2.BackColor = Color.FromArgb(255, 255, 192);
            sifre_label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sifre_label2.Location = new Point(304, 373);
            sifre_label2.Name = "sifre_label2";
            sifre_label2.Size = new Size(45, 20);
            sifre_label2.TabIndex = 1;
            sifre_label2.Text = "Şifre:";
            // 
            // kullaniciAditextBox1
            // 
            kullaniciAditextBox1.Location = new Point(366, 334);
            kullaniciAditextBox1.Name = "kullaniciAditextBox1";
            kullaniciAditextBox1.Size = new Size(125, 27);
            kullaniciAditextBox1.TabIndex = 2;
            // 
            // sifretextBox2
            // 
            sifretextBox2.Location = new Point(366, 373);
            sifretextBox2.Name = "sifretextBox2";
            sifretextBox2.PasswordChar = '*';
            sifretextBox2.Size = new Size(125, 27);
            sifretextBox2.TabIndex = 3;
            // 
            // giris_button1
            // 
            giris_button1.BackColor = Color.OliveDrab;
            giris_button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            giris_button1.Location = new Point(384, 419);
            giris_button1.Name = "giris_button1";
            giris_button1.Size = new Size(94, 29);
            giris_button1.TabIndex = 4;
            giris_button1.Text = "Giriş";
            giris_button1.UseVisualStyleBackColor = false;
            giris_button1.Click += giris_button1_Click;
            // 
            // sonuc_label1
            // 
            sonuc_label1.AutoSize = true;
            sonuc_label1.Location = new Point(260, 265);
            sonuc_label1.Name = "sonuc_label1";
            sonuc_label1.Size = new Size(0, 20);
            sonuc_label1.TabIndex = 5;
            // 
            // girisEkraniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 534);
            Controls.Add(giris_button1);
            Controls.Add(sifretextBox2);
            Controls.Add(sifre_label2);
            Controls.Add(kullaniciAditextBox1);
            Controls.Add(kullaniciAdi_label1);
            Controls.Add(sonuc_label1);
            DoubleBuffered = true;
            Name = "girisEkraniForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kullaniciAdi_label1;
        private Label sifre_label2;
        private TextBox kullaniciAditextBox1;
        private TextBox sifretextBox2;
        private Button giris_button1;
        private Label sonuc_label1;
    }
}
