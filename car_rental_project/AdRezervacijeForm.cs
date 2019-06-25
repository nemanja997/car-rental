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
            
            foreach (Rezervacija rezervacija in listaSvihRezervacija)
            {
                LBRezervacije.Items.Add(rezervacija);
            }
        }

        private void CBKupac_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kupac selektovaniKupac = (Kupac)CBKupac.SelectedItem;
            if (selektovaniKupac != null)
            {
                popuniListuRezervacijaZaKupca(selektovaniKupac.Id);
                CBDodajAutomobil.Items.Clear();
                CBIzmeniAutomobil.Items.Clear();
                foreach (Automobil auto in listaSvihAutomobila)
                {
                    CBDodajAutomobil.Items.Add(auto);
                    CBIzmeniAutomobil.Items.Add(auto);
                }
                ocistiPoljaZaIzmenu();
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
            MessageBox.Show(DTPDodajDatumOd.Value.ToString() + DTPDodajDatumDo.Value.ToString());
            int cena;
            bool uspesnoCena = int.TryParse(TBoxDodajCena.Text.Trim(), out cena);
            if (DTPDodajDatumOd.Value != null && DTPDodajDatumDo != null && TBoxDodajCena.Text.Trim() != "" &&
                CBDodajAutomobil.SelectedIndex != -1)
            {
                if (Datum.validanOpseg(DTPDodajDatumOd.Value, DTPDodajDatumDo.Value))
                {
                    if (uspesnoCena)
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
                        else
                        {
                            MessageBox.Show("Nije uspelo pravljenje nove rezervacije.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cena nije validno unesena.");
                    }
                }
                else
                {
                    MessageBox.Show("Pocetni datum rezervacije mora biti manji od zavrsnog datuma.");
                }
            }
            else
            {
                MessageBox.Show("Morate popuniti sva polja.");
            }
        }

        private void btnIzmeniRezervaciju_Click(object sender, EventArgs e)
        {   
            Rezervacija izabranaRezervacija = (Rezervacija)LBRezervacije.SelectedItem;
            int cena;
            bool uspesnoCena = int.TryParse(TBoxIzmeniCena.Text.Trim(), out cena);
            if (izabranaRezervacija != null)
            {
                if (DTPIzmeniDatumOd.Value != null && DTPIzmeniDatumDo != null && TBoxIzmeniCena.Text.Trim() != "" &&
                CBIzmeniAutomobil.SelectedIndex != -1)
                {
                    if (Datum.validanOpseg(DTPIzmeniDatumOd.Value, DTPIzmeniDatumDo.Value))
                    {
                        if (uspesnoCena)
                        {
                                Rezervacija novaRezezervacija = new Rezervacija(
                                        ((Automobil)CBIzmeniAutomobil.SelectedItem).Id,
                                        ((Kupac)CBKupac.SelectedItem).Id,
                                        DTPIzmeniDatumOd.Value,
                                        DTPIzmeniDatumDo.Value,
                                        cena
                                        );
                                if (Rezervacija.izmeniRezervaciju(izabranaRezervacija.Id, novaRezezervacija))
                                {
                                    popuniListuRezervacijaZaKupca(((Kupac)CBKupac.SelectedItem).Id);
                                    MessageBox.Show("Uspesno ste izmenili rezervaciju.");
                                    ocistiPoljaZaIzmenu();
                                }
                                else
                                {
                                    MessageBox.Show("Nije uspelo pravljenje nove rezervacije.");
                                }
                        }
                        else
                        {
                            MessageBox.Show("Cena nije validno unesena.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Pocetni datum rezervacije mora biti manji od zavrsnog datuma.");
                    }
                }
                else
                {
                    MessageBox.Show("Morate popuniti sva polja.");
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati rezervaciju za izmenu.");
            }
        }

        private void LBRezervacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rezervacija izabranaRezervacija = (Rezervacija)LBRezervacije.SelectedItem;
            if (izabranaRezervacija != null) {
                foreach (Automobil a in listaSvihAutomobila)
                {
                    if (a.Id == izabranaRezervacija.IdAutomobila)
                    {
                        CBIzmeniAutomobil.SelectedItem = a;
                    }
                }
                TBoxIzmeniCena.Text = izabranaRezervacija.Cena.ToString();
                DTPIzmeniDatumDo.Value = izabranaRezervacija.DatumDo;
                DTPIzmeniDatumOd.Value = izabranaRezervacija.DatumOd;
            }
        }

        private void ocistiPoljaZaIzmenu()
        {
            CBIzmeniAutomobil.SelectedIndex = -1;
            TBoxIzmeniCena.Text = "";
            DTPIzmeniDatumDo.Value = DateTime.Now;
            DTPIzmeniDatumOd.Value = DateTime.Now;
        }
    }
}
