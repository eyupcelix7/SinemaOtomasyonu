namespace SinemaOtomasyonu.UI.Forms.RezervasyonForms
{
    partial class FormKoltuklar
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
            flpKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpKoltuklar
            // 
            flpKoltuklar.Dock = System.Windows.Forms.DockStyle.Fill;
            flpKoltuklar.Location = new System.Drawing.Point(0, 0);
            flpKoltuklar.Name = "flpKoltuklar";
            flpKoltuklar.Size = new System.Drawing.Size(800, 450);
            flpKoltuklar.TabIndex = 0;
            // 
            // FormKoltuklar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(flpKoltuklar);
            Name = "FormKoltuklar";
            Text = "Koltuklar";
            Load += FormKoltuklar_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKoltuklar;
    }
}