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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void BtnKupac_Click(object sender, EventArgs e)
        {
            Form adKupacForm = new AdKupacForm();
            adKupacForm.ShowDialog();
        }

        private void BtnAutomobil_Click(object sender, EventArgs e)
        {
            Form adAutomobilForm = new AdAutomobilForm();
            adAutomobilForm.ShowDialog();
        }

        private void BtnPonuda_Click(object sender, EventArgs e)
        {
            Form adPonudaForm = new AdPonudaForm();
            adPonudaForm.ShowDialog();
        }
    }
}
