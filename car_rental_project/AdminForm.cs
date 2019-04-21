using car_rental_project.RadSaFajlovima;
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
        List<Kupac> listaSvihKupaca;

        public AdminForm()
        {
            InitializeComponent();
            
            
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kupac kupac = (Kupac)listBox1.SelectedItem;

            if (kupac != null)
            {
                string[] datum = kupac.DatumRodjenja.Split('/');
                TBoxIzmenaKorisnickoIme.Text = kupac.KorisnickoIme;
                TBoxIzmenaLozinka.Text = kupac.Lozinka;
                TBoxIzmenaIme.Text = kupac.Ime;
                TBoxIzmenaPrezime.Text = kupac.Prezime;
                TBoxIzmenaDan.Text = datum[0];
                TBoxIzmenaMesec.Text = datum[1];
                TBoxIzmenaGodina.Text = datum[2];
                TBoxIzmenaTelefon.Text = kupac.Telefon;
                TBoxIzmenaJMBG.Text = kupac.Jmbg;
            }
            else {
                TBoxIzmenaKorisnickoIme.Text = "";
                TBoxIzmenaLozinka.Text = "";
                TBoxIzmenaIme.Text = "";
                TBoxIzmenaPrezime.Text = "";
                TBoxIzmenaDan.Text = "";
                TBoxIzmenaMesec.Text = "";
                TBoxIzmenaGodina.Text = "";
                TBoxIzmenaTelefon.Text = "";
                TBoxIzmenaJMBG.Text = "";
            }
            

        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            if (TBoxDodajIme.Text.Trim().Length != 0 && TBoxDodajPrezime.Text.Trim().Length != 0 &&
                TBoxDodajTelefon.Text.Trim().Length != 0 && TBoxDodajDan.Text.Trim().Length !=0 &&
                TBoxDodajMesec.Text.Trim().Length != 0 && TBoxDodajGodina.Text.Trim().Length != 0 &&
                TBoxDodajJMBG.Text.Trim().Length != 0){
                int dan, mesec, godina;
                bool uspesnoDan = int.TryParse(TBoxDodajDan.Text, out dan);
                bool uspesnoMesec = int.TryParse(TBoxDodajMesec.Text, out mesec);
                bool uspesnoGodina = int.TryParse(TBoxDodajGodina.Text, out godina);
                if (uspesnoDan && uspesnoMesec && uspesnoGodina)
                {

                    if (DateTime.DaysInMonth(godina, mesec) >= dan)
                    {
                        string datum = dan.ToString() + "/" + mesec.ToString() + "/" + godina.ToString();

                        Kupac noviKupac =
                         new Kupac(
                         TBoxDodajKorisnickoIme.Text,
                         TBoxDodajLozinka.Text,
                         TBoxDodajIme.Text,
                         TBoxDodajPrezime.Text,
                         TBoxDodajJMBG.Text,
                         datum,
                         TBoxDodajTelefon.Text);
                        if (Korisnik.napraviKorisnika(noviKupac)) {
                            napuniListuKupaca();
                            TBoxDodajKorisnickoIme.Text = "";
                            TBoxDodajLozinka.Text = "";
                            TBoxDodajIme.Text = "";
                            TBoxDodajPrezime.Text = "";
                            TBoxDodajDan.Text = "";
                            TBoxDodajMesec.Text = "";
                            TBoxDodajGodina.Text = "";
                            TBoxDodajTelefon.Text = "";
                            TBoxDodajJMBG.Text = "";
                        }
                        
                    }
                    else {
                        MessageBox.Show("Molimo unesite validan datum.");
                    }
                }
                else {
                    MessageBox.Show("Polja za datum rodjenja moraju biti validno popunjena.");
                }
            }
            else {
                MessageBox.Show("Ne smete ostavljati prazna polja.");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   if (listBox1.SelectedIndex > -1)
            {
                Kupac kupac = (Kupac)listBox1.SelectedItem;

                Korisnik.obrisiKorisnika(kupac.KorisnickoIme);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else {
                MessageBox.Show("Niste izabrali nijednog korisnika za brisanje.");
            

            }
            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            napuniListuKupaca();
        }

        public bool proveriStringTextBox(TextBox tBox) {
            if (!tBox.Text.All(char.IsDigit)){
                    return true;
            }else {
                return false;
            }
        }

        private void BtnIzmeniKupca_Click(object sender, EventArgs e)
        { 

            Kupac kupac = (Kupac)listBox1.SelectedItem;
            if (kupac != null) {
                string datum = TBoxIzmenaDan.Text + "/" + TBoxIzmenaMesec.Text + "/" + TBoxIzmenaGodina.Text;
                Kupac kupacZaIzmenu =
                new Kupac(
                TBoxIzmenaKorisnickoIme.Text,
                TBoxIzmenaLozinka.Text,
                TBoxIzmenaIme.Text,
                TBoxIzmenaPrezime.Text,
                TBoxIzmenaJMBG.Text,
                datum,
                TBoxIzmenaTelefon.Text);

                if (Kupac.izmeniKupca(kupac.KorisnickoIme, kupacZaIzmenu))
                {
                    MessageBox.Show("Uspesno ste izmenili kupca.");
                    napuniListuKupaca();
                }
                else
                {
                    MessageBox.Show("Nije uspela izmena kupca.");
                }
            }
            
       
        }
        public void napuniListuKupaca() {
            listBox1.Items.Clear();
            listaSvihKupaca = Kupac.vratiSveKupce();
            MessageBox.Show((listaSvihKupaca == null).ToString());
            foreach (Kupac kupac in listaSvihKupaca)
            {
                listBox1.Items.Add(kupac);
            }
        }
    }
}
