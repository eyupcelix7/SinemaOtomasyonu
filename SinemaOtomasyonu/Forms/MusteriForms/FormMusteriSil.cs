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

namespace SinemaOtomasyonu.UI.Forms.MusteriForms
{
    public partial class FormMusteriSil : Form
    {
        private readonly MusteriService _musteriService;
        public FormMusteriSil()
        {
            _musteriService = new MusteriService(new SinemaContext());
            InitializeComponent();
        }

        private void LoadFilms()
        {
            var musteriler = _musteriService.GetAllCustomers();
            dgvMusteriler.DataSource = musteriler;
        }

        private void FormMusteriSil_Load(object sender, EventArgs e)
        {
            LoadFilms();
        }

        private void dgvMusteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvMusteriler.CurrentRow.Cells[0].Value;
            Musteri musteri = _musteriService.GetCustomerById(id);

            DialogResult dialogResult = MessageBox.Show($"{musteri.Ad} isimli müşteriyi silmek istediğinize emin misiniz?","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                _musteriService.DeleteCustomer(id);
                LoadFilms();
            }
        }
    }
}
