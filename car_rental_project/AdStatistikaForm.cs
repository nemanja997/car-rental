using car_rental_project.Modeli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental_project
{
    public partial class AdStatistikaForm : Form
    {
        int aprilBrojRezervacija, majBrojRezervacija, junBrojRezervacija,ukupno;
        float aprilUdeo, majUdeo, junUdeo;
        List<Rezervacija> sveRezervacije;

        private void AdStatistikaForm_Load(object sender, EventArgs e)
        {
            sveRezervacije = Rezervacija.vratiSveRezervacije();
            foreach (Rezervacija rezervacija in sveRezervacije)
            {
                if (rezervacija.DatumOd.Month == 4)
                {
                    aprilBrojRezervacija++;
                }
                else if (rezervacija.DatumOd.Month == 5)
                {
                    majBrojRezervacija++;
                }
                else if (rezervacija.DatumOd.Month == 6)
                {
                    junBrojRezervacija++;
                }
            }
            ukupno = aprilBrojRezervacija + majBrojRezervacija + junBrojRezervacija;
            aprilUdeo = ((float)aprilBrojRezervacija / ukupno) * 360;
            majUdeo = ((float)majBrojRezervacija / ukupno) * 360;
            junUdeo = ((float)junBrojRezervacija / ukupno) * 360;
            Label LBApril = new Label();
            LBApril.Location = new Point(100,140);
            LBApril.Font = new Font("Arial", 12, FontStyle.Bold);
            LBApril.Size = new Size(200, 20);
            LBApril.Text = "(crvena ) April (" + ((float)((float)aprilBrojRezervacija / ukupno) * 100).ToString() + "%)";
            Label LBMaj = new Label();
            LBMaj.Location = new Point(100, 180);
            LBMaj.Font = new Font("Arial", 12, FontStyle.Bold);
            LBMaj.Size = new Size(200, 20);
            LBMaj.Text = "( zelena ) Maj (" + ((float)((float)majBrojRezervacija / ukupno) * 100).ToString() + "%)";
            Label LBJun = new Label();
            LBJun.Location = new Point(100, 220);
            LBJun.Font = new Font("Arial", 12, FontStyle.Bold);
            LBJun.Size = new Size(200, 20);
            LBJun.Text = "( plava ) Jun (" + ((float)((float)junBrojRezervacija / ukupno) * 100).ToString() + "%)";
            this.Controls.Add(LBApril);
            this.Controls.Add(LBMaj);
            this.Controls.Add(LBJun);

        }

        public AdStatistikaForm()
        {
            InitializeComponent();
            aprilBrojRezervacija = 0;
            majBrojRezervacija = 0;
            junBrojRezervacija = 0;
        }

        private void AdStatistikaForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPie(Brushes.Red, new Rectangle((this.Width / 4) * 3 - 150, 80, 200, 200), 0, aprilUdeo);
            e.Graphics.FillPie(Brushes.Green, new Rectangle((this.Width / 4) * 3 - 150, 80, 200, 200), aprilUdeo, majUdeo);
            e.Graphics.FillPie(Brushes.Blue, new Rectangle((this.Width / 4) * 3 - 150, 80, 200, 200), aprilUdeo + majUdeo, junUdeo);
            
        }
    }
}
