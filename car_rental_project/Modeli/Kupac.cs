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
        private DateTime datumRodjenja;
        private string telefon;

        public Kupac(string korisnickoIme, string lozinka, string ime, string prezime, string jmbg, DateTime datumRodjenja, string telefon) : base(korisnickoIme, lozinka)
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
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return Id  + " " + Ime + " " + Prezime + " (" + KorisnickoIme + ") " + "JMBG: " + Jmbg + "Telefon: " + Telefon;
        }

        public static List<Kupac> vratiSveKupce()
        {
            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();
            Korisnik korisnik;
            List<Kupac> listaKupaca = new List<Kupac>();
            string[] filePaths = Directory.GetFiles("Data\\Korisnici");

            if (!Directory.Exists("Data\\Korisnici"))
            {
                System.IO.Directory.CreateDirectory("Data\\Korisnici");
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

        public static bool izmeniKupca(string korisnickoIme,Kupac izmenjeniKupac) {
            
            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();
            string[] filePaths = Directory.GetFiles("Data\\Korisnici");
            Korisnik korisnik;
            foreach (string filePath in filePaths){
                if (File.Exists(filePath)){
                    stream = File.Open(filePath, FileMode.Open);
                    korisnik = (Korisnik)bf.Deserialize(stream);
                    stream.Close();
                    
                    if (korisnik is Kupac && korisnik.KorisnickoIme == korisnickoIme)
                    {
                        izmenjeniKupac.Id = korisnik.Id;
                        try{
                            File.Delete(filePath);
                        }catch (IOException){}
                        stream = File.Open("Data\\Korisnici\\" + izmenjeniKupac.KorisnickoIme + ".bin", FileMode.Create);
                        bf.Serialize(stream, izmenjeniKupac);
                        stream.Close();
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
