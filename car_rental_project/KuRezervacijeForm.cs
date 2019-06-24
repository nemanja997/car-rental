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
    public partial class KuRezervacijeForm : Form
    {
        Kupac kupac;
        List<Automobil> listaSvihAutomobila;
        List<MarkaAutomobila> listaSvihMarki;
        public KuRezervacijeForm(Kupac kupac)
        {
            InitializeComponent();
            this.kupac = kupac;
            listaSvihMarki = new List<MarkaAutomobila>();
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KuRezervacijeForm_Load(object sender, EventArgs e)
        {
            listaSvihMarki = MarkaAutomobila.vratiSveMarke();
            foreach (MarkaAutomobila model in listaSvihMarki)
            {
                CBoxMarka.Items.Add(model.Brand);
            }

            string[] vrstePogona = { "Prednji", "Zadnji", "4x4" };
            string[] vrsteMenjaca = { "Manuelni", "Automatik" };
            string[] brojVrata = { "2/3", "4/5" };
            string[] vrsteGoriva = { "Dizel", "Benzin", "Benzin + Gas", "Metan" };
            string[] vrsteKaroserija = { "Karavan", "Limuzina", "Kupe", "Kabriolet", "Dzip/SUV" };
            string[] vsteKubikaze = { "800 kubika", "1000 kubika", "1200 kubika", "1300 kubika", "1400 kubika", "1500 kubika"
                    , "1600 kubika", "1700 kubika", "1900 kubika", "2000 kubika", "2200 kubika", "2500 kubika", "3000 kubika", "3500 kubika" };
            

            //Punjenje ComboBox-ova
            listaSvihMarki = MarkaAutomobila.vratiSveMarke();
            foreach (MarkaAutomobila model in listaSvihMarki)
            {
                CBoxMarka.Items.Add(model.Brand);
            }
            foreach (string pogon in vrstePogona)
            {
                CBoxPogon.Items.Add(pogon);
            }
            foreach (string menjac in vrsteMenjaca)
            {
                CBoxMenjac.Items.Add(menjac);
            }
            foreach (string broj in brojVrata)
            {
                CBoxBrojVrata.Items.Add(broj);
            }
            foreach (string gorivo in vrsteGoriva)
            {
                CBoxGorivo.Items.Add(gorivo);
            }
            foreach (string karoserija in vrsteKaroserija)
            {
                CBoxKaroserija.Items.Add(karoserija);
            }
            foreach (string kubikaza in vsteKubikaze)
            {
                CBoxKubikaza.Items.Add(kubikaza);
            }
            for (int i = 2019; i > 1990; i--)
            {
                CBoxGodiste.Items.Add(i);
            }

        }

        private void CBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                CBoxModel.Items.Clear();
            string odabranaMarka = (string)CBoxMarka.SelectedItem;
            foreach (MarkaAutomobila marka in listaSvihMarki)
            {
                if (string.Compare(marka.Brand, odabranaMarka) == 0)
                {
                    foreach (string model in marka.Models)
                    {
                        CBoxModel.Items.Add(model);
                    }
                }
            }
        }
    }
}
