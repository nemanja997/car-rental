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
        List<MarkaAutomobila> listaSvihMarki;
       

        public AdAutomobilForm()
        {
            InitializeComponent();
            listaSvihAutomobila = new List<Automobil>();
            listaSvihMarki = new List<MarkaAutomobila>();
            

        }

        private void btnDodajAutomobil_Click(object sender, EventArgs e)
        {   
            if (CBDodajBrojVrata.SelectedIndex != -1 && CBDodajGorivo.SelectedIndex != -1 &&
                CBDodajGorivo.SelectedIndex != -1 && CBDodajModel.SelectedIndex != -1 &&
                CBDodajaVrstaMenjaca.SelectedIndex != -1 && CBDodajPogon.SelectedIndex != -1
                && CBDodajaKaroserija.SelectedIndex != -1)
            {
                Automobil automobil = new Automobil(
                    CBDodajMarka.Text,
                    CBDodajModel.Text,
                    Int32.Parse(CBDodajGodiste.Text) ,
                    CBDodajKubikaza.Text,
                    CBDodajPogon.Text,
                    CBDodajaVrstaMenjaca.Text,
                    CBDodajaKaroserija.Text,
                    CBDodajGorivo.Text,
                    CBDodajBrojVrata.Text
                    );
                Automobil.dodajAutomobil(automobil);
                osveziListuAutomobila();
            }
            else {
                MessageBox.Show("Ne smete ostavljati prazna polja.");
            }
        }

        private void AdAutomobilForm_Load(object sender, EventArgs e)
        {   
            string[] vrstePogona = { "Prednji", "Zadnji", "4x4" };
            string[] vrsteMenjaca = { "Manuelni", "Automatik" };
            string[] brojVrata = { "2/3", "4/5" };
            string[] vrsteGoriva = { "Dizel", "Benzin", "Benzin + Gas", "Metan" };
            string[] vrsteKaroserija = { "Karavan", "Limuzina", "Kupe", "Kabriolet", "Dzip/SUV" };
            string[] vsteKubikaze = { "800 kubika", "1000 kubika", "1200 kubika", "1300 kubika", "1400 kubika", "1500 kubika"
                    , "1600 kubika", "1700 kubika", "1900 kubika", "2000 kubika", "2200 kubika", "2500 kubika", "3000 kubika", "3500 kubika" };

            osveziListuAutomobila();

            //Punjenje ComboBox-ova
            listaSvihMarki = MarkaAutomobila.vratiSveMarke();
                foreach (MarkaAutomobila model in listaSvihMarki)
                {
                    CBIzmenaMarka.Items.Add(model.Brand);
                    CBDodajMarka.Items.Add(model.Brand);
                }
            
            foreach (string pogon in vrstePogona) {
                CBDodajPogon.Items.Add(pogon);
                CBIzmenaPogon.Items.Add(pogon);
            }
            foreach (string menjac in vrsteMenjaca)
            {
                CBDodajaVrstaMenjaca.Items.Add(menjac);
                CBIzmenaVrstaMenjaca.Items.Add(menjac);
            }
            foreach (string broj in brojVrata)
            {
                CBDodajBrojVrata.Items.Add(broj);
                CBIzmenaBrojVrata.Items.Add(broj);
            }
            foreach (string gorivo in vrsteGoriva)
            {
                CBDodajGorivo.Items.Add(gorivo);
                CBIzmenaGorivo.Items.Add(gorivo);
            }
            foreach (string karoserija in vrsteKaroserija)
            {
                CBDodajaKaroserija.Items.Add(karoserija);
                CBIzmenaKaroserija.Items.Add(karoserija);
            }
            foreach (string kubikaza in vsteKubikaze)
            {
                CBDodajKubikaza.Items.Add(kubikaza);
                CBIzmeniKubikaza.Items.Add(kubikaza);
            }
            for (int i = 2019; i > 1990; i--) {
                CBDodajGodiste.Items.Add(i);
                CBIzmeniGodiste.Items.Add(i);
            }
        }

        private void CBDodajMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBDodajModel.Items.Clear();
           string odabranaMarka = (string)CBDodajMarka.SelectedItem;
            foreach (MarkaAutomobila marka in listaSvihMarki) {
                if (string.Compare(marka.Brand, odabranaMarka) == 0 ) {
                    foreach (string model in marka.Models)
                    {
                        CBDodajModel.Items.Add(model);
                    }
                }
            }
        }

        private void CBIzmenaMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBIzmeniModel.Items.Clear();
            string odabranaMarka = (string)CBIzmenaMarka.SelectedItem;
            foreach (MarkaAutomobila marka in listaSvihMarki)
            {
                if (string.Compare(marka.Brand, odabranaMarka) == 0)
                {
                    foreach (string model in marka.Models)
                    {
                        CBIzmeniModel.Items.Add(model);
                    }
                }
            }
        }

        public void osveziListuAutomobila()
        {
            LBAutomobili.Items.Clear();
            listaSvihAutomobila = Automobil.vratiSveAutomobile();
            foreach (Automobil automobil in listaSvihAutomobila)
            {
                LBAutomobili.Items.Add(automobil);
            }
        }

        private void btnObrisiAutomobil_Click(object sender, EventArgs e)
        {
            if (LBAutomobili.SelectedIndex != -1)
            {
                Automobil automobilZaBrisanje = (Automobil)LBAutomobili.SelectedItem;
                Automobil.obrisiAutomobil(automobilZaBrisanje.Id);

                osveziListuAutomobila();
            }
            else {
                MessageBox.Show("Niste odabrali nijedan automobil za brisanje.");
            }
        }

        private void BtnIzmeniAutomobil_Click(object sender, EventArgs e)
        {
            if (LBAutomobili.SelectedIndex != -1)
            {
                Automobil automobilZaIzmenu = (Automobil)LBAutomobili.SelectedItem;
                Automobil noviAutomobil = new Automobil(
                    CBIzmenaMarka.Text,
                    CBIzmeniModel.Text,
                    Int32.Parse(CBIzmeniGodiste.Text),
                    CBIzmeniKubikaza.Text,
                    CBIzmenaPogon.Text,
                    CBIzmenaVrstaMenjaca.Text,
                    CBIzmenaKaroserija.Text,
                    CBIzmenaGorivo.Text,
                    CBIzmenaBrojVrata.Text
                    );
                if (Automobil.izmeniAutomobil(automobilZaIzmenu.Id, noviAutomobil))
                {
                    MessageBox.Show("Uspesno ste izmenili automobil.");
                }
                else {
                    MessageBox.Show("Izmena automobila nije uspela.");
                }

                osveziListuAutomobila();
            }
            else {
                MessageBox.Show("Niste odabrali automobil za izmenu.");
            }
        }

        private void LBAutomobili_SelectedIndexChanged(object sender, EventArgs e)
        {
            Automobil automobil = (Automobil)LBAutomobili.SelectedItem;
            if (automobil != null)
            {
                CBIzmenaMarka.SelectedItem = automobil.Marka;
                CBIzmeniModel.SelectedItem = automobil.Model;
                CBIzmeniGodiste.SelectedItem = automobil.Godiste;
                CBIzmeniKubikaza.SelectedItem = automobil.Kubikaza;
                CBIzmenaPogon.SelectedItem = automobil.Pogon;
                CBIzmenaVrstaMenjaca.SelectedItem = automobil.VrstaMenjaca;
                CBIzmenaKaroserija.SelectedItem = automobil.Karoserija;
                CBIzmenaGorivo.SelectedItem = automobil.Gorivo;
                CBIzmenaBrojVrata.SelectedItem = automobil.BrojVrata;
            }
            else { }
        }
    }
}
