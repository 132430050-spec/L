namespace LIBRARY_1
{
    partial class kategoriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kategoriForm));
            kategoriBazli_dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)kategoriBazli_dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kategoriBazli_dataGridView1
            // 
            kategoriBazli_dataGridView1.BackgroundColor = Color.DarkKhaki;
            kategoriBazli_dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kategoriBazli_dataGridView1.Location = new Point(12, 49);
            kategoriBazli_dataGridView1.Name = "kategoriBazli_dataGridView1";
            kategoriBazli_dataGridView1.RowHeadersWidth = 51;
            kategoriBazli_dataGridView1.Size = new Size(636, 434);
            kategoriBazli_dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(691, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 370);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // kategoriForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(1185, 519);
            Controls.Add(pictureBox1);
            Controls.Add(kategoriBazli_dataGridView1);
            Name = "kategoriForm";
            Text = "kategoriForm";
            Load += kategoriForm_Load;
            ((System.ComponentModel.ISupportInitialize)kategoriBazli_dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView kategoriBazli_dataGridView1;
        private PictureBox pictureBox1;
    }
}