namespace SinemaOtomasyonu.UI.Forms.RezervasyonForms
{
    partial class FormRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRezervasyon));
            grpKoltuklar = new DevExpress.XtraEditors.GroupControl();
            flpKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
            grpSeansBilgileri = new DevExpress.XtraEditors.GroupControl();
            cboFilmSecin = new System.Windows.Forms.ComboBox();
            lblFilmSecin = new DevExpress.XtraEditors.LabelControl();
            lblMusteriSecin = new DevExpress.XtraEditors.LabelControl();
            lblSecilenKoltuklar = new DevExpress.XtraEditors.LabelControl();
            lblSecilenKoltuklarVal = new DevExpress.XtraEditors.LabelControl();
            cboMusteriSecin = new System.Windows.Forms.ComboBox();
            btnBiletKes = new DevExpress.XtraEditors.SimpleButton();
            lblOdenecekTutar = new DevExpress.XtraEditors.LabelControl();
            lblOdenecekTutarVal = new DevExpress.XtraEditors.LabelControl();
            grpVizyondakiFilmler = new DevExpress.XtraEditors.GroupControl();
            flpVizyondakiFilmler = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)grpKoltuklar).BeginInit();
            grpKoltuklar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grpSeansBilgileri).BeginInit();
            grpSeansBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grpVizyondakiFilmler).BeginInit();
            grpVizyondakiFilmler.SuspendLayout();
            SuspendLayout();
            // 
            // grpKoltuklar
            // 
            grpKoltuklar.Controls.Add(flpKoltuklar);
            grpKoltuklar.Dock = System.Windows.Forms.DockStyle.Top;
            grpKoltuklar.Location = new System.Drawing.Point(0, 0);
            grpKoltuklar.Name = "grpKoltuklar";
            grpKoltuklar.Size = new System.Drawing.Size(872, 192);
            grpKoltuklar.TabIndex = 0;
            grpKoltuklar.Text = "Koltuklar";
            // 
            // flpKoltuklar
            // 
            flpKoltuklar.Dock = System.Windows.Forms.DockStyle.Fill;
            flpKoltuklar.Location = new System.Drawing.Point(2, 23);
            flpKoltuklar.Name = "flpKoltuklar";
            flpKoltuklar.Size = new System.Drawing.Size(868, 167);
            flpKoltuklar.TabIndex = 0;
            // 
            // grpSeansBilgileri
            // 
            grpSeansBilgileri.Controls.Add(lblOdenecekTutarVal);
            grpSeansBilgileri.Controls.Add(lblOdenecekTutar);
            grpSeansBilgileri.Controls.Add(btnBiletKes);
            grpSeansBilgileri.Controls.Add(cboMusteriSecin);
            grpSeansBilgileri.Controls.Add(lblSecilenKoltuklarVal);
            grpSeansBilgileri.Controls.Add(lblSecilenKoltuklar);
            grpSeansBilgileri.Controls.Add(lblMusteriSecin);
            grpSeansBilgileri.Controls.Add(lblFilmSecin);
            grpSeansBilgileri.Controls.Add(cboFilmSecin);
            grpSeansBilgileri.Dock = System.Windows.Forms.DockStyle.Left;
            grpSeansBilgileri.Location = new System.Drawing.Point(0, 192);
            grpSeansBilgileri.Name = "grpSeansBilgileri";
            grpSeansBilgileri.Size = new System.Drawing.Size(298, 325);
            grpSeansBilgileri.TabIndex = 1;
            grpSeansBilgileri.Text = "Seans Bilgileri";
            // 
            // cboFilmSecin
            // 
            cboFilmSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboFilmSecin.FormattingEnabled = true;
            cboFilmSecin.Location = new System.Drawing.Point(105, 33);
            cboFilmSecin.Name = "cboFilmSecin";
            cboFilmSecin.Size = new System.Drawing.Size(121, 21);
            cboFilmSecin.TabIndex = 0;
            // 
            // lblFilmSecin
            // 
            lblFilmSecin.Location = new System.Drawing.Point(5, 36);
            lblFilmSecin.Name = "lblFilmSecin";
            lblFilmSecin.Size = new System.Drawing.Size(50, 13);
            lblFilmSecin.TabIndex = 1;
            lblFilmSecin.Text = "Film Seçin:";
            // 
            // lblMusteriSecin
            // 
            lblMusteriSecin.Location = new System.Drawing.Point(5, 63);
            lblMusteriSecin.Name = "lblMusteriSecin";
            lblMusteriSecin.Size = new System.Drawing.Size(67, 13);
            lblMusteriSecin.TabIndex = 2;
            lblMusteriSecin.Text = "Müşteri Seçin:";
            // 
            // lblSecilenKoltuklar
            // 
            lblSecilenKoltuklar.Location = new System.Drawing.Point(2, 88);
            lblSecilenKoltuklar.Name = "lblSecilenKoltuklar";
            lblSecilenKoltuklar.Size = new System.Drawing.Size(81, 13);
            lblSecilenKoltuklar.TabIndex = 3;
            lblSecilenKoltuklar.Text = "Seçilen Koltuklar:";
            // 
            // lblSecilenKoltuklarVal
            // 
            lblSecilenKoltuklarVal.Appearance.BorderColor = System.Drawing.Color.Black;
            lblSecilenKoltuklarVal.Appearance.Options.UseBorderColor = true;
            lblSecilenKoltuklarVal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblSecilenKoltuklarVal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            lblSecilenKoltuklarVal.Location = new System.Drawing.Point(105, 86);
            lblSecilenKoltuklarVal.Name = "lblSecilenKoltuklarVal";
            lblSecilenKoltuklarVal.Size = new System.Drawing.Size(121, 22);
            lblSecilenKoltuklarVal.TabIndex = 4;
            lblSecilenKoltuklarVal.Text = "1,2,3,4";
            // 
            // cboMusteriSecin
            // 
            cboMusteriSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboMusteriSecin.FormattingEnabled = true;
            cboMusteriSecin.Location = new System.Drawing.Point(105, 60);
            cboMusteriSecin.Name = "cboMusteriSecin";
            cboMusteriSecin.Size = new System.Drawing.Size(121, 21);
            cboMusteriSecin.TabIndex = 5;
            // 
            // btnBiletKes
            // 
            btnBiletKes.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            btnBiletKes.Location = new System.Drawing.Point(105, 142);
            btnBiletKes.Name = "btnBiletKes";
            btnBiletKes.Size = new System.Drawing.Size(121, 36);
            btnBiletKes.TabIndex = 7;
            btnBiletKes.Text = "Bileti Kes";
            // 
            // lblOdenecekTutar
            // 
            lblOdenecekTutar.Location = new System.Drawing.Point(2, 116);
            lblOdenecekTutar.Name = "lblOdenecekTutar";
            lblOdenecekTutar.Size = new System.Drawing.Size(81, 13);
            lblOdenecekTutar.TabIndex = 8;
            lblOdenecekTutar.Text = "Ödenecek Tutar:";
            // 
            // lblOdenecekTutarVal
            // 
            lblOdenecekTutarVal.Appearance.BorderColor = System.Drawing.Color.Black;
            lblOdenecekTutarVal.Appearance.Options.UseBorderColor = true;
            lblOdenecekTutarVal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblOdenecekTutarVal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            lblOdenecekTutarVal.Location = new System.Drawing.Point(105, 114);
            lblOdenecekTutarVal.Name = "lblOdenecekTutarVal";
            lblOdenecekTutarVal.Size = new System.Drawing.Size(121, 22);
            lblOdenecekTutarVal.TabIndex = 10;
            lblOdenecekTutarVal.Text = "400 TRY";
            // 
            // grpVizyondakiFilmler
            // 
            grpVizyondakiFilmler.Controls.Add(flpVizyondakiFilmler);
            grpVizyondakiFilmler.Dock = System.Windows.Forms.DockStyle.Right;
            grpVizyondakiFilmler.Location = new System.Drawing.Point(304, 192);
            grpVizyondakiFilmler.Name = "grpVizyondakiFilmler";
            grpVizyondakiFilmler.Size = new System.Drawing.Size(568, 325);
            grpVizyondakiFilmler.TabIndex = 2;
            grpVizyondakiFilmler.Text = "Vizyondaki Filmler";
            // 
            // flpVizyondakiFilmler
            // 
            flpVizyondakiFilmler.Dock = System.Windows.Forms.DockStyle.Fill;
            flpVizyondakiFilmler.Location = new System.Drawing.Point(2, 23);
            flpVizyondakiFilmler.Name = "flpVizyondakiFilmler";
            flpVizyondakiFilmler.Size = new System.Drawing.Size(564, 300);
            flpVizyondakiFilmler.TabIndex = 0;
            // 
            // FormRezervasyon
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(872, 517);
            Controls.Add(grpVizyondakiFilmler);
            Controls.Add(grpSeansBilgileri);
            Controls.Add(grpKoltuklar);
            Name = "FormRezervasyon";
            Text = "FormRezervasyon";
            Load += FormRezervasyon_Load;
            ((System.ComponentModel.ISupportInitialize)grpKoltuklar).EndInit();
            grpKoltuklar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grpSeansBilgileri).EndInit();
            grpSeansBilgileri.ResumeLayout(false);
            grpSeansBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grpVizyondakiFilmler).EndInit();
            grpVizyondakiFilmler.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpKoltuklar;
        private System.Windows.Forms.FlowLayoutPanel flpKoltuklar;
        private DevExpress.XtraEditors.GroupControl grpSeansBilgileri;
        private System.Windows.Forms.ComboBox cboFilmSecin;
        private System.Windows.Forms.ComboBox cboMusteriSecin;
        private DevExpress.XtraEditors.LabelControl lblSecilenKoltuklarVal;
        private DevExpress.XtraEditors.LabelControl lblSecilenKoltuklar;
        private DevExpress.XtraEditors.LabelControl lblMusteriSecin;
        private DevExpress.XtraEditors.LabelControl lblFilmSecin;
        private DevExpress.XtraEditors.LabelControl lblOdenecekTutarVal;
        private DevExpress.XtraEditors.LabelControl lblOdenecekTutar;
        private DevExpress.XtraEditors.SimpleButton btnBiletKes;
        private DevExpress.XtraEditors.GroupControl grpVizyondakiFilmler;
        private System.Windows.Forms.FlowLayoutPanel flpVizyondakiFilmler;
    }
}