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
    public partial class KupacForm : Form
    {
        Kupac kupac;
        List<Rezervacija> listaSvihRezervacijaZaKupca;

        public KupacForm(Kupac kupac)
        {
            InitializeComponent();
            this.kupac = kupac;
        }

        private void KupacForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Ulogovani ste kao: " + kupac.Ime;
            popuniListuRezervacijaZaKupca();
        }


        public void popuniListuRezervacijaZaKupca()
        {
            LBRezervacije.Items.Clear();
            listaSvihRezervacijaZaKupca = Rezervacija.vratiRezervacijeZaKupca(kupac.Id);

            foreach (Rezervacija rezervacija in listaSvihRezervacijaZaKupca)
            {
                LBRezervacije.Items.Add(rezervacija);
            }
        }

        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            Rezervacija rezervaciajZaBrisanje = (Rezervacija)LBRezervacije.SelectedItem;
            if (rezervaciajZaBrisanje != null)
            {
                Rezervacija.obrisiRezervaciju(rezervaciajZaBrisanje.Id);
                popuniListuRezervacijaZaKupca();
            }
            else
            {
                MessageBox.Show("Morate odabrati rezervaciju za brisanje");
            }
        }

        private void btnNapraviRezervaciju_Click(object sender, EventArgs e)
        {
            DialogResult rezultatRezervacije = new DialogResult();
            Form rezervacijeForm = new KuRezervacijeForm(kupac);
            rezultatRezervacije = rezervacijeForm.ShowDialog();
            if (rezultatRezervacije == DialogResult.OK)
            {
                popuniListuRezervacijaZaKupca();
            }

        }
    }
}
