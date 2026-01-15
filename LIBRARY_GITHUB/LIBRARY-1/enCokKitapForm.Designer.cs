namespace LIBRARY_1
{
    partial class enCokKitapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enCokKitapForm));
            enCokTercih_dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)enCokTercih_dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // enCokTercih_dataGridView1
            // 
            enCokTercih_dataGridView1.BackgroundColor = Color.DarkKhaki;
            enCokTercih_dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            enCokTercih_dataGridView1.Location = new Point(32, 55);
            enCokTercih_dataGridView1.Name = "enCokTercih_dataGridView1";
            enCokTercih_dataGridView1.RowHeadersWidth = 51;
            enCokTercih_dataGridView1.Size = new Size(651, 399);
            enCokTercih_dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(723, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // enCokKitapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(1119, 518);
            Controls.Add(pictureBox1);
            Controls.Add(enCokTercih_dataGridView1);
            Name = "enCokKitapForm";
            Text = "enCokKitapForm";
            Load += enCokKitapForm_Load;
            ((System.ComponentModel.ISupportInitialize)enCokTercih_dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView enCokTercih_dataGridView1;
        private PictureBox pictureBox1;
    }
}