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
        List<Ponuda> listaSvihPonuda;
        List<MarkaAutomobila> listaSvihMarki;
        int cenaRezervacije;
        Automobil izabraniAuto;

        public KuRezervacijeForm(Kupac kupac)
        {
            InitializeComponent();
            this.kupac = kupac;
            listaSvihMarki = new List<MarkaAutomobila>();
            listaSvihAutomobila = Automobil.vratiSveAutomobile();
            listaSvihPonuda = Ponuda.vratiSvePonude();
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)LBPonude.SelectedItem;
            if (ponuda != null)
            {
                if (DTPDatumOd.Value != null && DTPDatumDo != null && TBoxUkupnaCena.Text.Trim() != "")
                {
                    if (Datum.validanOpseg(DTPDatumOd.Value, DTPDatumDo.Value))
                    {
                        if (Datum.daLiJeOpsegUDozvoljenomOpsegu(DTPDatumOd.Value, DTPDatumDo.Value, ponuda.DatumOd, ponuda.DatumDo))
                        {
                            Rezervacija novaRezezervacija = new Rezervacija(
                        izabraniAuto.Id,
                        kupac.Id,
                        DTPDatumOd.Value,
                        DTPDatumDo.Value,
                        Int32.Parse(TBoxUkupnaCena.Text)
                        );

                            if (Rezervacija.napraviRezervaciju(novaRezezervacija))
                            {
                                MessageBox.Show("Uspesno ste napravili rezervaciju.");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Nije uspelo pravljenje nove rezervacije.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Morate izabrati datume u okviru ponude.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Morate izabrati validan opseg datuma.");
                    }
                }
                else
                {
                    MessageBox.Show("Morate popuniti sva polja.");
                }
            }
            else {
                MessageBox.Show("Morate izabrati ponudu.");
            }
            
        }
        private void napuniComboBoxove() {
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
        private void KuRezervacijeForm_Load(object sender, EventArgs e)
        {
            napuniComboBoxove();
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

        private void btnPrikaziPonudu_Click(object sender, EventArgs e)
        {
            if (CBoxMarka.SelectedIndex != -1 && CBoxModel.SelectedIndex != -1 &&
                CBoxMenjac.SelectedIndex != -1 && CBoxPogon.SelectedIndex != -1 &&
                    CBoxKaroserija.SelectedIndex != -1 && CBoxGorivo.SelectedIndex != -1 &&
                CBoxBrojVrata.SelectedIndex != -1 && CBoxGodiste.SelectedIndex != -1 &&
                CBoxKubikaza.SelectedIndex != -1)
            {
                LBPonude.Items.Clear();

                foreach (Automobil auto in listaSvihAutomobila)
                {
                    if (CBoxMarka.Text == auto.Marka && CBoxModel.Text == auto.Model &&
                        CBoxMenjac.Text == auto.VrstaMenjaca && CBoxPogon.Text == auto.Pogon &&
                        CBoxKaroserija.Text == auto.Karoserija && CBoxGorivo.Text == auto.Gorivo &&
                        CBoxBrojVrata.Text == auto.BrojVrata && CBoxGodiste.Text == auto.Godiste.ToString() &&
                        CBoxKubikaza.Text == auto.Kubikaza)
                    {
                        izabraniAuto = auto;
                    }
                }
                if (izabraniAuto != null)
                {
                    foreach (Ponuda ponuda in listaSvihPonuda)
                    {
                        if (ponuda.IdAutomobila == izabraniAuto.Id)
                        {
                            LBPonude.Items.Add(ponuda);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Trenutno nemamo trazeni auto u ponudi.");
                    ocistiComboBoxove();
                    napuniComboBoxove();
                }
            }
            else {
                MessageBox.Show("Ne smete ostavljati prazna polja.");
            }
            
        }

        public void ocistiComboBoxove() {
            CBoxBrojVrata.Items.Clear();
            CBoxKubikaza.Items.Clear();
            CBoxGodiste.Items.Clear();
            CBoxGorivo.Items.Clear();
            CBoxKaroserija.Items.Clear();
            CBoxPogon.Items.Clear();
            CBoxMenjac.Items.Clear();
            CBoxModel.Items.Clear();
            CBoxMarka.Items.Clear();
        }

        public int izracunajCenuZaOpsegDatuma(int cenaPoDanu, DateTime datumOd, DateTime datumDo) {
            int rezultat, brojDana;
            brojDana = (datumDo - datumOd).Days + 1;
            rezultat = brojDana * cenaPoDanu;
            if (Datum.validanOpseg(datumOd, datumDo))
            {
                return rezultat;
            }
            else {
                return 0;
            }

        }

        private void DTPDatumOd_ValueChanged(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)LBPonude.SelectedItem;
            
            if (ponuda != null)
            {
                cenaRezervacije = izracunajCenuZaOpsegDatuma(ponuda.CenaPoDanu, DTPDatumOd.Value, DTPDatumDo.Value);
                TBoxUkupnaCena.Text = cenaRezervacije.ToString();
            }
            else {
                TBoxUkupnaCena.Text = "/";
            }
        }

        private void DTPDatumDo_ValueChanged(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)LBPonude.SelectedItem;
            
            if (ponuda != null)
            {
                cenaRezervacije = izracunajCenuZaOpsegDatuma(ponuda.CenaPoDanu, DTPDatumOd.Value, DTPDatumDo.Value);
                TBoxUkupnaCena.Text = cenaRezervacije.ToString();
            }
            else
            {
                TBoxUkupnaCena.Text = "/";
            }
        }
    }
}
