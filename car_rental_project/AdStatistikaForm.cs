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
        public AdStatistikaForm()
        {
            InitializeComponent();
        }

        private void AdStatistikaForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Blue, new Rectangle(this.Width /4 -100, 60, 200,200));
            e.Graphics.FillPie(Brushes.Red, new Rectangle(this.Width /4 - 100, 60, 200, 200), -90.0F, 90.0F);

            e.Graphics.FillEllipse(Brushes.Blue, new Rectangle((this.Width / 4) * 3 - 100, 60, 200, 200));
            e.Graphics.FillPie(Brushes.Red, new Rectangle((this.Width / 4) * 3 - 100, 60, 200, 200), -90.0F, 90.0F);
        }
    }
}
