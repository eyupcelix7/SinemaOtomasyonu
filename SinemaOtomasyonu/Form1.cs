using SinemaOtomasyonu.DataAccess;
using SinemaOtomasyonu.DataAccess.Services;
using SinemaOtomasyonu.Entities.Models;
using SinemaOtomasyonu.UI;
using SinemaOtomasyonu.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SinemaContext>());
            using (var db = new SinemaContext())
            {
                db.Database.Initialize(force: true);
            }
        }

        private void btnFilmListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormFilmListesi form = new FormFilmListesi();
            form.MdiParent = this;
            form.Show();
        }

        private void btnFilmEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormFilmEkle form = new FormFilmEkle();
            form.MdiParent = this;
            form.Show();
        }

        private void btnFilmDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormFilmGuncelle form = new FormFilmGuncelle();
            form.MdiParent = this;
            form.Show();
        }

        private void btnFilmSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormFilmSil form = new FormFilmSil();
            form.MdiParent = this;
            form.Show();
        }
    }
}
