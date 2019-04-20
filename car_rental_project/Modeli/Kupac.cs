using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace car_rental_project
{   
    [Serializable()]
    class Kupac : Korisnik
    {
        
        private string ime;
        private string prezime;
        private string jmbg;
        private string datumRodjenja;
        private string telefon;

        public Kupac(string korisnickoIme, string lozinka, string ime, string prezime, string jmbg, string datumRodjenja, string telefon) : base(korisnickoIme, lozinka)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.telefon = telefon;
        }
        
        
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return "Korisnicko ime: " + KorisnickoIme +", Ime i prezime:" + Ime + " " + Prezime;
        }

        public static List<Kupac> vratiSveKupce()
        {
            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();
            Korisnik korisnik;
            List<Kupac> listaKupaca = new List<Kupac>();
            string[] filePaths = Directory.GetFiles("Data"); //Uzmi sve fajlove iz Data foldera

            if (!Directory.Exists("Data"))
            {
                System.IO.Directory.CreateDirectory("Data");
            }
            foreach (string filePath in filePaths)
            {
                if (File.Exists(filePath))
                {
                    stream = File.Open(filePath, FileMode.Open);
                    korisnik = (Korisnik)bf.Deserialize(stream);
                    stream.Close();
                    if (korisnik is Kupac)
                    {
                        listaKupaca.Add((Kupac)korisnik);
                    }
                }
            }
            return listaKupaca;
        }
    }
}
