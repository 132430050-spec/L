namespace LIBRARY_1
{
    partial class gecikenKitapForm
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
            gecikenKitap_dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gecikenKitap_dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gecikenKitap_dataGridView1
            // 
            gecikenKitap_dataGridView1.BackgroundColor = Color.DarkKhaki;
            gecikenKitap_dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gecikenKitap_dataGridView1.Location = new Point(56, 38);
            gecikenKitap_dataGridView1.Name = "gecikenKitap_dataGridView1";
            gecikenKitap_dataGridView1.RowHeadersWidth = 51;
            gecikenKitap_dataGridView1.Size = new Size(677, 371);
            gecikenKitap_dataGridView1.TabIndex = 0;
            // 
            // gecikenKitapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(gecikenKitap_dataGridView1);
            Name = "gecikenKitapForm";
            Text = "gecikenKitapForm";
            Load += gecikenKitapForm_Load;
            ((System.ComponentModel.ISupportInitialize)gecikenKitap_dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gecikenKitap_dataGridView1;
    }
}