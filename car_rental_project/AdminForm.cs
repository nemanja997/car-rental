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
            listaSvihKupaca = Kupac.vratiSveKupce();
            foreach (Kupac k in listaSvihKupaca) {
                listBox1.Items.Add(k);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kupac kupac = (Kupac)listBox1.SelectedItem;
            TBoxIzmenaKorisnickoIme.Text = kupac.KorisnickoIme;
            TBoxIzmenaLozinka.Text = kupac.Lozinka;
            TBoxIzmenaIme.Text = kupac.Ime;
            TBoxIzmenaPrezime.Text = kupac.Prezime;
            TBoxIzmenaDatumRodjenja.Text = kupac.DatumRodjenja;
            TBoxIzmenaTelefon.Text = kupac.Telefon;
            TBoxIzmenaJMBG.Text = kupac.Jmbg;

        }

        public void updateList() {

        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            if (TBoxDodajIme.Text.Trim().Length != 0 && TBoxDodajPrezime.Text.Trim().Length != 0 &&
                TBoxDodajDatumRodjenja.Text.Trim().Length != 0 && TBoxDodajTelefon.Text.Trim().Length != 0 &&
                TBoxDodajJMBG.Text.Trim().Length != 0){
                Kupac noviKupac = 
                new Kupac(
                TBoxDodajKorisnickoIme.Text,
                TBoxDodajLozinka.Text,
                TBoxDodajIme.Text,
                TBoxDodajPrezime.Text,
                TBoxDodajJMBG.Text,
                TBoxDodajDatumRodjenja.Text,
                TBoxDodajTelefon.Text);
                Korisnik.napraviKorisnika(noviKupac);
                listBox1.Items.Add(noviKupac);
         
             
            }
            else {
                MessageBox.Show("Ne smete ostavljati prazna polja.");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kupac kupac = (Kupac)listBox1.SelectedItem;
            
            KorisnikRepository.obrisiKorisnika(kupac.KorisnickoIme);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
