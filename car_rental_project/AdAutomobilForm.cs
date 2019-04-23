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
    public partial class AdAutomobilForm : Form
    {
        List<Automobil> listaSvihAutomobila;
        List<string> listamodela;


        public AdAutomobilForm()
        {
            InitializeComponent();
            listaSvihAutomobila = new List<Automobil>();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            if (CBDodajaBrojVrata.SelectedIndex != -1 && CBDodajaGorivo.SelectedIndex != -1 &&
                CBDodajaGorivo.SelectedIndex != -1 && CBDodajaModel.SelectedIndex != -1 &&
                CBDodajaVrstaMenjaca.SelectedIndex != -1 && CBDodajPogon.SelectedIndex != -1
                && CBDodajaKaroserija.SelectedIndex != -1)
            {

            }
            else {
                MessageBox.Show("Ne smete ostavljati prazna polja.");
            }
        }

        private void AdAutomobilForm_Load(object sender, EventArgs e)
        {

            List<string> listamodela = ModelAutomobila.vratiSveMarke();
            if (listamodela != null)
            {
                foreach (string model in listamodela)
                {
                    CBIzmenaMarka.Items.Add(model);
                    CBDodajMarka.Items.Add(model);
                }
            }
            else {
                MessageBox.Show("lista je prazna");
            }
            
        }

        private void CBDodajMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> listaModelaZaMarku = ModelAutomobila.vratiModeleZaMarku(CBDodajMarka.SelectedText);
        }
    }
}
