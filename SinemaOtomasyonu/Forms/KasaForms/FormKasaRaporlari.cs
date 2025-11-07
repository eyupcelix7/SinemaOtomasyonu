using SinemaOtomasyonu.DataAccess;
using SinemaOtomasyonu.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu.UI.Forms.KasaForms
{
    public partial class FormKasaRaporlari : Form
    {
        private readonly KasaService _kasaService;
        private readonly SinemaContext _context;
        public FormKasaRaporlari()
        {
            _kasaService = new KasaService(new SinemaContext());
            _context = new SinemaContext();
            InitializeComponent();
        }

        private void FormKasaRaporlari_Load(object sender, EventArgs e)
        {
            KasaGecmisiYukle();
            ToplamSatisYukle();
            BugunkileriYukle();
        }
        private void KasaGecmisiYukle()
        {
            var kasaGecmis = _kasaService.GetAll();
            gridKasaGecmisi.DataSource = kasaGecmis;
        }
        private void ToplamSatisYukle()
        {
            int totalFilmsSold = _context.Rezervasyonlar.Count();
            int totalSeatsSold = _context.Rezervasyonlar.Where(x => x.KoltukId != 0).Count();
            decimal totalRenevue = _context.Rezervasyonlar.Count() * 115;

            lblToplamKazanilanPara.Text = totalRenevue.ToString();
            lblToplamSatilanBiletler.Text = totalFilmsSold.ToString();
            lblToplamSatilanKoltuklar.Text = totalSeatsSold.ToString();
        }
        private void BugunkileriYukle()
        {
            var todayDate = DateTime.Today;
            var startOfDate = todayDate.Date;
            var endOfDate = todayDate.Date.AddDays(1).AddTicks(-1);

            int dailyFilmsSold = _kasaService
                .GetAll()
                .Where(r=> r.IslemTarihi >= startOfDate && r.IslemTarihi <= endOfDate)
                .Count();

            int dailySeatsSold = _context
                .Rezervasyonlar
                .Where(r => r.RezervasyonTarihi >= startOfDate && r.RezervasyonTarihi <= endOfDate)
                .Count();

            decimal dailyRevenue = _context
                .Rezervasyonlar
                .Where(r => r.RezervasyonTarihi >= startOfDate && r.RezervasyonTarihi <= endOfDate)
                .Count() * 115;

            lblBugunKazanilanPara.Text = dailyRevenue.ToString();
            lblBugunSatilanBiletler.Text = dailyFilmsSold.ToString();
            lblBugunSatilanKoltuklar.Text = dailySeatsSold.ToString();
        }
    }
}
