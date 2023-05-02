namespace Evaluation_Manager
{
    partial class FrmStudents
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
            this.dgvStudents1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents1
            // 
            this.dgvStudents1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents1.Location = new System.Drawing.Point(0, 0);
            this.dgvStudents1.Name = "dgvStudents1";
            this.dgvStudents1.Size = new System.Drawing.Size(558, 228);
            this.dgvStudents1.TabIndex = 0;
            // 
            // FrmStudents
            // 
            this.ClientSize = new System.Drawing.Size(559, 278);
            this.Controls.Add(this.dgvStudents1);
            this.Name = "FrmStudents";
            this.Load += new System.EventHandler(this.FrmStudents_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgvStudents1;
    }
}