namespace SinemaOtomasyonu.UI.Forms.KasaForms
{
    partial class FormKasaRaporlari
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
            gridKasaGecmisi = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            lblToplamSatilanBiletler = new DevExpress.XtraEditors.LabelControl();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            lblToplamSatilanKoltuklar = new DevExpress.XtraEditors.LabelControl();
            groupControl4 = new DevExpress.XtraEditors.GroupControl();
            lblToplamKazanilanPara = new DevExpress.XtraEditors.LabelControl();
            groupControl5 = new DevExpress.XtraEditors.GroupControl();
            lblBugunKazanilanPara = new DevExpress.XtraEditors.LabelControl();
            groupControl6 = new DevExpress.XtraEditors.GroupControl();
            lblBugunSatilanKoltuklar = new DevExpress.XtraEditors.LabelControl();
            groupControl7 = new DevExpress.XtraEditors.GroupControl();
            lblBugunSatilanBiletler = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridKasaGecmisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl4).BeginInit();
            groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl5).BeginInit();
            groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl6).BeginInit();
            groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl7).BeginInit();
            groupControl7.SuspendLayout();
            SuspendLayout();
            // 
            // gridKasaGecmisi
            // 
            gridKasaGecmisi.Dock = System.Windows.Forms.DockStyle.Fill;
            gridKasaGecmisi.Location = new System.Drawing.Point(2, 23);
            gridKasaGecmisi.MainView = gridView1;
            gridKasaGecmisi.Name = "gridKasaGecmisi";
            gridKasaGecmisi.Size = new System.Drawing.Size(1094, 414);
            gridKasaGecmisi.TabIndex = 0;
            gridKasaGecmisi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridKasaGecmisi;
            gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(gridKasaGecmisi);
            groupControl1.Location = new System.Drawing.Point(0, 304);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(1098, 439);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "Tüm Kasa Geçmişi";
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(lblToplamSatilanBiletler);
            groupControl2.Location = new System.Drawing.Point(9, 12);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new System.Drawing.Size(161, 161);
            groupControl2.TabIndex = 2;
            groupControl2.Text = "Toplam Satılan Biletler";
            // 
            // lblToplamSatilanBiletler
            // 
            lblToplamSatilanBiletler.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            lblToplamSatilanBiletler.Appearance.Options.UseFont = true;
            lblToplamSatilanBiletler.Appearance.Options.UseTextOptions = true;
            lblToplamSatilanBiletler.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblToplamSatilanBiletler.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblToplamSatilanBiletler.Location = new System.Drawing.Point(5, 79);
            lblToplamSatilanBiletler.Name = "lblToplamSatilanBiletler";
            lblToplamSatilanBiletler.Size = new System.Drawing.Size(151, 35);
            lblToplamSatilanBiletler.TabIndex = 0;
            lblToplamSatilanBiletler.Text = "0";
            // 
            // groupControl3
            // 
            groupControl3.Controls.Add(lblToplamSatilanKoltuklar);
            groupControl3.Location = new System.Drawing.Point(189, 12);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new System.Drawing.Size(170, 161);
            groupControl3.TabIndex = 3;
            groupControl3.Text = "Toplam Satılan Koltuklar";
            // 
            // lblToplamSatilanKoltuklar
            // 
            lblToplamSatilanKoltuklar.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            lblToplamSatilanKoltuklar.Appearance.Options.UseFont = true;
            lblToplamSatilanKoltuklar.Appearance.Options.UseTextOptions = true;
            lblToplamSatilanKoltuklar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblToplamSatilanKoltuklar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblToplamSatilanKoltuklar.Location = new System.Drawing.Point(5, 79);
            lblToplamSatilanKoltuklar.Name = "lblToplamSatilanKoltuklar";
            lblToplamSatilanKoltuklar.Size = new System.Drawing.Size(151, 35);
            lblToplamSatilanKoltuklar.TabIndex = 0;
            lblToplamSatilanKoltuklar.Text = "0";
            // 
            // groupControl4
            // 
            groupControl4.Controls.Add(lblToplamKazanilanPara);
            groupControl4.Location = new System.Drawing.Point(378, 12);
            groupControl4.Name = "groupControl4";
            groupControl4.Size = new System.Drawing.Size(161, 161);
            groupControl4.TabIndex = 4;
            groupControl4.Text = "Toplam Kazanılan Para";
            // 
            // lblToplamKazanilanPara
            // 
            lblToplamKazanilanPara.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            lblToplamKazanilanPara.Appearance.Options.UseFont = true;
            lblToplamKazanilanPara.Appearance.Options.UseTextOptions = true;
            lblToplamKazanilanPara.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblToplamKazanilanPara.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblToplamKazanilanPara.Location = new System.Drawing.Point(5, 79);
            lblToplamKazanilanPara.Name = "lblToplamKazanilanPara";
            lblToplamKazanilanPara.Size = new System.Drawing.Size(151, 35);
            lblToplamKazanilanPara.TabIndex = 0;
            lblToplamKazanilanPara.Text = "0";
            // 
            // groupControl5
            // 
            groupControl5.Controls.Add(lblBugunKazanilanPara);
            groupControl5.Location = new System.Drawing.Point(927, 12);
            groupControl5.Name = "groupControl5";
            groupControl5.Size = new System.Drawing.Size(161, 161);
            groupControl5.TabIndex = 7;
            groupControl5.Text = "Bugün Kazanılan Para";
            // 
            // lblBugunKazanilanPara
            // 
            lblBugunKazanilanPara.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            lblBugunKazanilanPara.Appearance.Options.UseFont = true;
            lblBugunKazanilanPara.Appearance.Options.UseTextOptions = true;
            lblBugunKazanilanPara.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblBugunKazanilanPara.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblBugunKazanilanPara.Location = new System.Drawing.Point(5, 79);
            lblBugunKazanilanPara.Name = "lblBugunKazanilanPara";
            lblBugunKazanilanPara.Size = new System.Drawing.Size(151, 35);
            lblBugunKazanilanPara.TabIndex = 0;
            lblBugunKazanilanPara.Text = "0";
            // 
            // groupControl6
            // 
            groupControl6.Controls.Add(lblBugunSatilanKoltuklar);
            groupControl6.Location = new System.Drawing.Point(738, 12);
            groupControl6.Name = "groupControl6";
            groupControl6.Size = new System.Drawing.Size(170, 161);
            groupControl6.TabIndex = 6;
            groupControl6.Text = "Bugün Satılan Koltuklar";
            // 
            // lblBugunSatilanKoltuklar
            // 
            lblBugunSatilanKoltuklar.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            lblBugunSatilanKoltuklar.Appearance.Options.UseFont = true;
            lblBugunSatilanKoltuklar.Appearance.Options.UseTextOptions = true;
            lblBugunSatilanKoltuklar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblBugunSatilanKoltuklar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblBugunSatilanKoltuklar.Location = new System.Drawing.Point(5, 79);
            lblBugunSatilanKoltuklar.Name = "lblBugunSatilanKoltuklar";
            lblBugunSatilanKoltuklar.Size = new System.Drawing.Size(151, 35);
            lblBugunSatilanKoltuklar.TabIndex = 0;
            lblBugunSatilanKoltuklar.Text = "0";
            // 
            // groupControl7
            // 
            groupControl7.Controls.Add(lblBugunSatilanBiletler);
            groupControl7.Location = new System.Drawing.Point(558, 12);
            groupControl7.Name = "groupControl7";
            groupControl7.Size = new System.Drawing.Size(161, 161);
            groupControl7.TabIndex = 5;
            groupControl7.Text = "Bugün Satılan Biletler";
            // 
            // lblBugunSatilanBiletler
            // 
            lblBugunSatilanBiletler.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            lblBugunSatilanBiletler.Appearance.Options.UseFont = true;
            lblBugunSatilanBiletler.Appearance.Options.UseTextOptions = true;
            lblBugunSatilanBiletler.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblBugunSatilanBiletler.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblBugunSatilanBiletler.Location = new System.Drawing.Point(5, 79);
            lblBugunSatilanBiletler.Name = "lblBugunSatilanBiletler";
            lblBugunSatilanBiletler.Size = new System.Drawing.Size(151, 35);
            lblBugunSatilanBiletler.TabIndex = 0;
            lblBugunSatilanBiletler.Text = "0";
            // 
            // FormKasaRaporlari
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1098, 743);
            Controls.Add(groupControl5);
            Controls.Add(groupControl6);
            Controls.Add(groupControl4);
            Controls.Add(groupControl7);
            Controls.Add(groupControl3);
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Name = "FormKasaRaporlari";
            Text = "Kasa Raporları";
            Load += FormKasaRaporlari_Load;
            ((System.ComponentModel.ISupportInitialize)gridKasaGecmisi).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl4).EndInit();
            groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl5).EndInit();
            groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl6).EndInit();
            groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl7).EndInit();
            groupControl7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridKasaGecmisi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lblToplamSatilanBiletler;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl lblToplamSatilanKoltuklar;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl lblToplamKazanilanPara;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LabelControl lblBugunKazanilanPara;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.LabelControl lblBugunSatilanKoltuklar;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.LabelControl lblBugunSatilanBiletler;
    }
}