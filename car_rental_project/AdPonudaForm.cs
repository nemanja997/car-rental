﻿using car_rental_project.Modeli;
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
    public partial class AdPonudaForm : Form
    {
        List<Automobil> listaSvihAutomobila;
        List<Ponuda> listaSvihPonuda;
        public AdPonudaForm()
        {
            InitializeComponent();
        }

        private void AdPonudaForm_Load(object sender, EventArgs e)
        {   
            listaSvihAutomobila = Automobil.vratiSveAutomobile();
            foreach (Automobil automobil in listaSvihAutomobila) {
                CBDodajAutomobil.Items.Add(automobil);
                CBIzmenaAutomobil.Items.Add(automobil);
            }
            osveziListuPonuda();
        }

        private void BtnDodajPonudu_Click(object sender, EventArgs e)
        { int odnosDatuma = DateTime.Compare(DTPDodajDatumOd.Value, DTPDodajDatumDo.Value);
            if (CBDodajAutomobil.SelectedIndex != -1 && TBoxDodajCenaPoDanu.Text.Trim().Length != 0)
            {
                Automobil selektovaniAutomobil = (Automobil)CBDodajAutomobil.SelectedItem;

                if (odnosDatuma <=0){
                    int cena;
                    bool uspesnoParsiranje = int.TryParse(TBoxDodajCenaPoDanu.Text.Trim(),out cena);
                    if (uspesnoParsiranje)
                    {
                        Ponuda ponuda = new Ponuda(
                        selektovaniAutomobil.Id,
                        DTPDodajDatumOd.Value,
                        DTPDodajDatumDo.Value,
                        cena
                        );
                        Ponuda.dodajPonudu(ponuda);
                        osveziListuPonuda();
                        TBoxDodajCenaPoDanu.Text = "";
                        CBDodajAutomobil.SelectedIndex = -1;
                    }
                    else {
                        MessageBox.Show("Polje za cenu mora sadrzati samo brojeve.");
                    }
                    
                }
                else{
                    MessageBox.Show("Pocetni datum mora biti manji od zavrsnog datuma.");
                }
            }
            else {
                MessageBox.Show("Morate popuniti sva polja.");

            }
        }



        public void osveziListuPonuda()
        {
            LBPonude.Items.Clear();
            listaSvihPonuda = Ponuda.vratiSvePonude();
            foreach (Ponuda ponude in listaSvihPonuda)
            {
                LBPonude.Items.Add(ponude);
            }
        }

        private void BtnObrisiPonudu_Click(object sender, EventArgs e)
        {
            if (LBPonude.SelectedIndex != -1)
            {
                Ponuda ponudaZaBrisanje = (Ponuda)LBPonude.SelectedItem;
                Ponuda.obrisiPonudu(ponudaZaBrisanje.Id);
                osveziListuPonuda();
            }
            else
            {
                MessageBox.Show("Niste odabrali nijednu ponudu za brisanje.");
            }
        }

        private void LBPonude_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ponuda ponuda = (Ponuda)LBPonude.SelectedItem;
            if (ponuda != null)
            {
                foreach (Automobil a in listaSvihAutomobila)
                {
                    if (a.Id == ponuda.IdAutomobila)
                    {
                        CBIzmenaAutomobil.SelectedItem = a;
                    }
                }
                TBoxIzmenaCenaPoDanu.Text = ponuda.CenaPoDanu.ToString();
                TBoxIzmenaCenaPoDanu.Text = ponuda.CenaPoDanu.ToString();
                DTPIzmenaDatumDo.Value = ponuda.DatumDo;
                DTPIzmenaDatumOd.Value = ponuda.DatumOd;
            }
        }

        private void BtnIzmenaPonuda_Click(object sender, EventArgs e)
        {
            int cena;
            bool uspesno = int.TryParse(TBoxIzmenaCenaPoDanu.Text.Trim(), out cena);
            Ponuda izabranaPonuda = (Ponuda)LBPonude.SelectedItem;
            if (izabranaPonuda != null)
            {   
                int odnosDatuma = DateTime.Compare(DTPIzmenaDatumOd.Value, DTPIzmenaDatumDo.Value);
                if (odnosDatuma <= 0)
                {
                    if (uspesno)
                    {
                        Ponuda novaPonuda = new Ponuda(
                                        ((Automobil)CBIzmenaAutomobil.SelectedItem).Id,
                                        DTPIzmenaDatumOd.Value,
                                        DTPIzmenaDatumDo.Value,
                                        cena);
                        if (Ponuda.izmeniPonudu(izabranaPonuda.Id, novaPonuda))
                        {
                            osveziListuPonuda();
                            MessageBox.Show("Uspesno ste izmenili ponudu.");

                        }
                        else
                        {
                            MessageBox.Show("Nije uspela izmena ponude.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Cena moze sadrzati samo cifre.");
                    }
                }
                else {
                    MessageBox.Show("Krajnji datum ne sme biti pre pocetnog."); 

                }
                
            }
            else {
                MessageBox.Show("Morate izabrati ponudu za izmenu.");
            }
           
        }
    }
}
