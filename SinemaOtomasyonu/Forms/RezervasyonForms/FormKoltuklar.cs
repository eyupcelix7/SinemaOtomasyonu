using SinemaOtomasyonu.DataAccess;
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
    public partial class FormKoltuklar : Form
    {
        public FormKoltuklar()
        {
            using (var context = new SinemaContext())
            {
                new DatabaseSeeder(context).SeedKoltuklar();
            }
            InitializeComponent();
        }

        private void FormKoltuklar_Load(object sender, EventArgs e)
        {
            flpKoltuklar.Controls.Clear();
            using(var context = new SinemaContext())
            {
                var koltuklar = context.Koltuklar.ToList();
                foreach(var koltuk in koltuklar)
                {
                    Button btnKoltuk = new Button();
                    btnKoltuk.Text = $"No: {koltuk.KoltukNo}";
                    btnKoltuk.Width = 60;
                    btnKoltuk.Height = 60;
                    btnKoltuk.Tag = koltuk.Id;
                    btnKoltuk.BackColor = koltuk.DoluMu ? Color.Red : Color.Green;
                    btnKoltuk.ForeColor = Color.White;

                    flpKoltuklar.Controls.Add(btnKoltuk);
                }
            }
        }
    }
}
