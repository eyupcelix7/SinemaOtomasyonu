namespace SinemaOtomasyonu.UI.Forms
{
    partial class FormFilmSil
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
            dgvFilmler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFilmler).BeginInit();
            SuspendLayout();
            // 
            // dgvFilmler
            // 
            dgvFilmler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmler.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvFilmler.Location = new System.Drawing.Point(0, 0);
            dgvFilmler.Name = "dgvFilmler";
            dgvFilmler.ReadOnly = true;
            dgvFilmler.Size = new System.Drawing.Size(800, 450);
            dgvFilmler.TabIndex = 0;
            dgvFilmler.CellDoubleClick += dgvFilmler_CellDoubleClick;
            // 
            // FormFilmSil
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvFilmler);
            Name = "FormFilmSil";
            Text = "Film Sil";
            Load += FormFilmSil_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilmler;
    }
}