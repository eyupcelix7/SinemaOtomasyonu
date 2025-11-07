using SinemaOtomasyonu.DataAccess;
using SinemaOtomasyonu.DataAccess.Services;
using SinemaOtomasyonu.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.UI.Forms.RezervasyonForms
{
    public partial class FormRezervasyon : Form
    {
        private const decimal KoltukFiyat = 115m;
        private readonly List<int> secilenKoltuklar = new List<int>();
        private KoltukService koltukService;
        private KasaService kasaService;
        private RezervasyonService rezervasyonService;
        public int gelenKoltukId;
        public FormRezervasyon()
        {
            using (var context = new SinemaContext())
            {
                new DatabaseSeeder(context).SeedKoltuklar();
            }
            InitializeComponent();
            koltukService = new KoltukService(new SinemaContext());
            kasaService = new KasaService(new SinemaContext());
            rezervasyonService = new RezervasyonService(new SinemaContext());
        }

        private void FormRezervasyon_Load(object sender, EventArgs e)
        {
            lblOdenecekTutarVal.Text = String.Empty;
            lblSecilenKoltuklarVal.Text = String.Empty;
            flpKoltuklar.Controls.Clear();
            using (var context = new SinemaContext())
            {
                KoltukListele(context);
                var musteriListesi = context.Musteriler.ToList();
                var filmListesi = context.Filmler.ToList();

                cboFilmSecin.DataSource = filmListesi;
                cboFilmSecin.ValueMember = "Id";
                cboFilmSecin.DisplayMember = "Ad";
                cboMusteriSecin.DataSource = musteriListesi;
                cboMusteriSecin.ValueMember = "Id";
                cboMusteriSecin.DisplayMember = "Ad";

                foreach (var item in filmListesi)
                {
                    GroupBox groupBox = new GroupBox();
                    groupBox.Width = 90;
                    groupBox.Height = 120;
                    groupBox.Text = item.Ad;
                    flpVizyondakiFilmler.Controls.Add(groupBox);
                }
            }
        }
        private void KoltukListele(SinemaContext context)
        {
            flpKoltuklar.Controls.Clear(); 
            var koltuklar = context.Koltuklar.ToList();
            foreach (var koltuk in koltuklar)
            {
                Button btnKoltuk = new Button();
                btnKoltuk.Text = $"No: {koltuk.KoltukNo}";
                btnKoltuk.Width = 50;
                btnKoltuk.Height = 50;
                btnKoltuk.Tag = koltuk.Id;
                btnKoltuk.BackColor = koltuk.DoluMu ? Color.Red : Color.Green;
                btnKoltuk.ForeColor = Color.White;
                btnKoltuk.Click += KoltukBtn_Click;
                flpKoltuklar.Controls.Add(btnKoltuk);
            }
        }
        private void KoltukBtn_Click(object sender, EventArgs e)
        {
            Button btnKoltuk = sender as Button;
            int koltukId = (int)btnKoltuk.Tag;

            using (var context = new SinemaContext())
            {
                var koltuk = context.Koltuklar.Find(koltukId);
                if (koltuk.DoluMu)
                {
                    MessageBox.Show("Koltuk dolu !");
                    return;
                }

                if (secilenKoltuklar.Contains(koltukId))
                {
                    secilenKoltuklar.Remove(koltukId);
                    btnKoltuk.BackColor = Color.Green;
                }
                else
                {
                    secilenKoltuklar.Add(koltukId);
                    btnKoltuk.BackColor = Color.Red;
                }
                lblSecilenKoltuklarVal.Text = string.Join(", ", secilenKoltuklar.Select(k => context.Koltuklar.Find(k).KoltukNo));
                ToplamFiyatHesapla();
            }
        }
        private void ToplamFiyatHesapla()
        {
            decimal toplamTutar = secilenKoltuklar.Count * KoltukFiyat;
            lblOdenecekTutarVal.Text = toplamTutar.ToString("0.00") + " TRY";
        }

        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            if(secilenKoltuklar.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir koltuk seçiniz","Bilgi");
                return;
            }

            using(var context = new SinemaContext())
            {
                foreach (var koltuk in secilenKoltuklar)
                {
                    var rezervasyon = new Rezervasyon
                    {
                        FilmId = (int)cboFilmSecin.SelectedValue,
                        MusteriId = (int)cboMusteriSecin.SelectedValue,
                        KoltukId = koltuk,
                        RezervasyonTarihi = DateTime.Now
                    };
                    rezervasyonService.RezervasyonAdd(rezervasyon);
                }
                foreach (var koltuk in secilenKoltuklar)
                {
                    var DBkoltuk = context.Koltuklar.FirstOrDefault(k => k.Id == koltuk);
                    DBkoltuk.DoluMu = true;
                    koltukService.UpdateKoltuk(DBkoltuk);
                }

                decimal toplamTutar = secilenKoltuklar.Count * KoltukFiyat;
                var kasaKaydi = new Kasa
                {
                    Tutar = toplamTutar,
                    Aciklama = $"{secilenKoltuklar.Count()} adet koltuk satışı",
                    IslemTarihi = DateTime.Now
                };

                kasaService.AddKasa(kasaKaydi);
                MessageBox.Show("Satış başarılı");
                lblOdenecekTutarVal.Text = "0.00 TRY";
                lblSecilenKoltuklarVal.Text = "";
                KoltukListele(context);
            }
        }
    }
}
