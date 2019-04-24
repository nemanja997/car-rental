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
    public partial class AdKupacForm : Form
    {
        List<Kupac> listaSvihKupaca;

        public AdKupacForm()
        {
            InitializeComponent();
        }

        private void lBKupci_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kupac kupac = (Kupac)LBKupci.SelectedItem;

            if (kupac != null)
            {
                
                TBoxIzmenaKorisnickoIme.Text = kupac.KorisnickoIme;
                TBoxIzmenaLozinka.Text = kupac.Lozinka;
                TBoxIzmenaIme.Text = kupac.Ime;
                TBoxIzmenaPrezime.Text = kupac.Prezime;
                DTPIzmenaDatumRodjenja.Value = kupac.DatumRodjenja;
                
                TBoxIzmenaTelefon.Text = kupac.Telefon;
                TBoxIzmenaJMBG.Text = kupac.Jmbg;
            }
        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            if (TBoxDodajIme.Text.Trim().Length != 0 && TBoxDodajPrezime.Text.Trim().Length != 0 &&
                TBoxDodajTelefon.Text.Trim().Length != 0 && 
                TBoxDodajJMBG.Text.Trim().Length != 0){
                int jbmg,brTelefona;
                bool jesuBrojevi = int.TryParse(TBoxDodajTelefon.Text.Trim(), out brTelefona) && 
                    int.TryParse(TBoxDodajJMBG.Text.Trim(), out jbmg);
                if (jesuBrojevi && TBoxDodajJMBG.Text.Trim().Length == 13 && TBoxDodajTelefon.Text.Trim().Length > 8)
                {
                    Kupac noviKupac =
                         new Kupac(
                         TBoxDodajKorisnickoIme.Text.Trim(),
                         TBoxDodajLozinka.Text.Trim(),
                         TBoxDodajIme.Text.Trim(),
                         TBoxDodajPrezime.Text.Trim(),
                         TBoxDodajJMBG.Text.Trim(),
                         DTPDodajDatumRodjenja.Value,
                         TBoxDodajTelefon.Text.Trim());
                    if (Korisnik.napraviKorisnika(noviKupac))
                    {
                        TBoxDodajKorisnickoIme.Text = "";
                        TBoxDodajLozinka.Text = "";
                        TBoxDodajIme.Text = "";
                        TBoxDodajPrezime.Text = "";
                        TBoxDodajTelefon.Text = "";
                        TBoxDodajJMBG.Text = "";
                        osveziListuKupaca();
                    }
                }
                else {
                    MessageBox.Show("Telefon ili JMBG nisu validni!");
                }       
            }
            else {
                MessageBox.Show("Ne smete ostavljati prazna polja.");
            }
        }

        private void btnObrisiKupca_Click(object sender, EventArgs e)
        {   if (LBKupci.SelectedIndex > -1)
            {
                Kupac kupac = (Kupac)LBKupci.SelectedItem;
                Korisnik.obrisiKorisnika(kupac.KorisnickoIme);
                osveziListuKupaca();

                TBoxIzmenaKorisnickoIme.Text = "";
                TBoxIzmenaLozinka.Text = "";
                TBoxIzmenaIme.Text = "";
                TBoxIzmenaPrezime.Text = "";
                TBoxIzmenaTelefon.Text = "";
                TBoxIzmenaJMBG.Text = "";
            }
            else {
                MessageBox.Show("Niste izabrali nijednog korisnika za brisanje.");
            }
            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            osveziListuKupaca();
            Rezervacija r = new Rezervacija(1,2,new DateTime(2019,12,12), new DateTime(2019, 12, 12),1534.3);
            Rezervacija.napraviRezervaciju(r);
        }


        private void BtnIzmeniKupca_Click(object sender, EventArgs e)
        {
            if (LBKupci.SelectedIndex > -1)
            {
                int jbmg, brTelefona;
                bool jesuBrojevi = int.TryParse(TBoxDodajTelefon.Text.Trim(), out brTelefona) &&
                    int.TryParse(TBoxDodajJMBG.Text.Trim(), out jbmg);
                if (jesuBrojevi && TBoxDodajJMBG.Text.Trim().Length == 13 && (TBoxDodajTelefon.Text.Trim().Length >8))
                {
                    Kupac kupac = (Kupac)LBKupci.SelectedItem;

                    Kupac kupacZaIzmenu =
                    new Kupac(
                    TBoxIzmenaKorisnickoIme.Text,
                    TBoxIzmenaLozinka.Text,
                    TBoxIzmenaIme.Text,
                    TBoxIzmenaPrezime.Text,
                    TBoxIzmenaJMBG.Text,
                    DTPIzmenaDatumRodjenja.Value,
                    TBoxIzmenaTelefon.Text);

                    if (Kupac.izmeniKupca(kupac.KorisnickoIme, kupacZaIzmenu))
                    {
                        MessageBox.Show("Uspesno ste izmenili kupca.");
                        osveziListuKupaca();
                    }
                }else {
                    MessageBox.Show("Telefon ili JMBG nisu validni!");
                }
            }
            else {
                MessageBox.Show("Niste izabrali nijednog korisnika za izmenu.");
            }
        }
        public void osveziListuKupaca() {
            LBKupci.Items.Clear();
           listaSvihKupaca = Kupac.vratiSveKupce();
            foreach (Kupac kupac in listaSvihKupaca){
                LBKupci.Items.Add(kupac);
            }
        }
        
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void TBoxIzmenaKorisnickoIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBoxIzmenaIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBoxIzmenaDan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void TBoxIzmenaMesec_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
