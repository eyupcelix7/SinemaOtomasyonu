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

namespace SinemaOtomasyonu.UI.Forms.MusteriForms
{
    public partial class FormMusteriListesi : Form
    {
        private readonly MusteriService _musteriService;
        public FormMusteriListesi()
        {
            _musteriService = new MusteriService(new SinemaContext());
            InitializeComponent();
        }
        private void LoadCustomers()
        {
            var musteriler = _musteriService.GetAllCustomers();
            dgvMusteriler.DataSource = musteriler;
        }
        private void FormMusteriListesi_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}
