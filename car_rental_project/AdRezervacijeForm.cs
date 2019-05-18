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
    public partial class AdRezervacijeForm : Form
    {
        List<Kupac> listaSvihKupaca;
        List<Automobil> listaSvihAutomobila;
        List<Rezervacija> listaSvihRezervacija;

        
        public AdRezervacijeForm()
        {
            InitializeComponent();
        }

        private void AdRezervacijeForm_Load(object sender, EventArgs e)
        {
            listaSvihKupaca = Kupac.vratiSveKupce();
            foreach (Kupac kupac in listaSvihKupaca) {
                CBKupac.Items.Add(kupac);
            }
            listaSvihAutomobila = Automobil.vratiSveAutomobile();
        }


        public void popuniListuRezervacijaZaKupca(int idKupca)
        {
            LBRezervacije.Items.Clear();
            listaSvihRezervacija = Rezervacija.vratiRezervacijeZaKupca(idKupca);
            if (listaSvihRezervacija.Any())
            {
                MessageBox.Show("Lista nije praza");

            }
            else {

                MessageBox.Show("lista je prazna");
            }
            
            foreach (Rezervacija rezervacija in listaSvihRezervacija)
            {
                LBRezervacije.Items.Add(rezervacija);
            }
        }

        private void CBKupac_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kupac selektovaniKupac = (Kupac)CBKupac.SelectedItem;
            if (selektovaniKupac != null) {
                popuniListuRezervacijaZaKupca(selektovaniKupac.Id);
                CBDodajAutomobil.Items.Clear();
                foreach (Automobil auto in listaSvihAutomobila)
                {
                    CBDodajAutomobil.Items.Add(auto);
                }
            }
            
            
        }

        private void BtnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            Rezervacija rezervaciajZaBrisanje = (Rezervacija)LBRezervacije.SelectedItem;
            if (rezervaciajZaBrisanje != null) {
                Rezervacija.obrisiRezervaciju(rezervaciajZaBrisanje.Id);
                popuniListuRezervacijaZaKupca(((Kupac)CBKupac.SelectedItem).Id);
            }
            
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {

            MessageBox.Show(((Kupac)CBKupac.SelectedItem).Id.ToString());

            int cena;
            bool uspesno = int.TryParse(TBoxDodajCena.Text.Trim(), out cena);
            if (uspesno)
            {
                Rezervacija novaRezezervacija = new Rezervacija(
                ((Automobil)CBDodajAutomobil.SelectedItem).Id,
                ((Kupac)CBKupac.SelectedItem).Id,
                DTPDodajDatumOd.Value,
                DTPDodajDatumDo.Value,
                cena
                );

                if (Rezervacija.napraviRezervaciju(novaRezezervacija))
                {
                    popuniListuRezervacijaZaKupca(((Kupac)CBKupac.SelectedItem).Id);
                    MessageBox.Show("Uspesno ste napravili rezervaciju.");
                    
                }
                else {
                    MessageBox.Show("Nije uspelo pravljenje nove rezervacije.");
                }



            }
            
        }
    }
}
