namespace LIBRARY_1
{
    partial class aktifUyeForm
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
            aktifUye_dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)aktifUye_dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // aktifUye_dataGridView1
            // 
            aktifUye_dataGridView1.BackgroundColor = Color.DarkKhaki;
            aktifUye_dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            aktifUye_dataGridView1.Location = new Point(52, 55);
            aktifUye_dataGridView1.Name = "aktifUye_dataGridView1";
            aktifUye_dataGridView1.RowHeadersWidth = 51;
            aktifUye_dataGridView1.Size = new Size(697, 360);
            aktifUye_dataGridView1.TabIndex = 0;
            // 
            // aktifUyeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(aktifUye_dataGridView1);
            Name = "aktifUyeForm";
            Text = "aktifUyeForm";
            Load += aktifUyeForm_Load;
            ((System.ComponentModel.ISupportInitialize)aktifUye_dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView aktifUye_dataGridView1;
    }
}