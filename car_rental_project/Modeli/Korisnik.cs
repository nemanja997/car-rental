using car_rental_project.Modeli;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental_project
{
    [Serializable()]
    public class Korisnik
    {
        static Stream stream;
        static BinaryFormatter bf = new BinaryFormatter();

        private int id;
        private string korisnickoIme;
        private string lozinka;

        

        public Korisnik(string korisnickoIme, string lozinka)
        {
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.id = vratiNajveciId() + 1;
        }

        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public int Id { get => id; set => id = value; }

        static public bool napraviKorisnika(Korisnik korisnik)
        {
            string path = "Data\\Korisnici\\" + korisnik.KorisnickoIme + ".bin";
            if (!Directory.Exists("Data\\Korisnici"))
            {
                System.IO.Directory.CreateDirectory("Data\\Korisnici");
            }
            if (!File.Exists(path))
            {
                stream = File.Open(path, FileMode.Create);
                bf.Serialize(stream, korisnik);
                stream.Close();
                MessageBox.Show("Uspesno ste dodali novog korisnika!");
                return true;
            }
            else
            {
                MessageBox.Show("Korisnik sa unetim korisnickim imenom vec postoji. Molimo odaberite drugo korisnicko ime.");
                return false;
            }
        }

        static public void obrisiKorisnika(string korisnickoIme,int IdKorisnika)
        {   
            string path = "Data\\Korisnici\\" + korisnickoIme + ".bin";
            if (File.Exists(path)){

                try{
                    File.Delete(path);
                    MessageBox.Show("Korisnik uspesno obrisan.");

                    FileStream stream;
                    BinaryFormatter bf = new BinaryFormatter();

                    //obrisi sve rezervacije vezane za korisnika
                    List<Rezervacija> listaSvihRezervacija = Rezervacija.vratiSveRezervacije();
                    foreach (Rezervacija rezervacija in listaSvihRezervacija)
                    {
                        if (rezervacija.IdKupca == IdKorisnika)
                        {
                            Rezervacija.obrisiRezervaciju(rezervacija.Id);
                        }
                    }

                }
                catch (IOException){
                    MessageBox.Show("Nije uspelo brisanje fajla za trazenog korisnika.");
                }

            }else {
                MessageBox.Show("Ne postoji fajl koji ste pokusali da obrisete.");
            }
        }

        static public Korisnik pronadjiKorisnika(string korisnickoIme, string lozinka)
        {
            Korisnik korisnik;
            if (!Directory.Exists("Data\\Korisnici")){
                System.IO.Directory.CreateDirectory("Data\\Korisnici");
            }
            string[] filePaths = Directory.GetFiles("Data\\Korisnici");


            foreach (string filePath in filePaths)
            {

                if (File.Exists(filePath))
                {
                    stream = File.Open(filePath, FileMode.Open);
                    korisnik = (Korisnik)bf.Deserialize(stream);
                    stream.Close();
                    if (korisnik.KorisnickoIme.Equals(korisnickoIme) && korisnik.Lozinka.Equals(lozinka))
                    {
                        return korisnik;
                    }
                }
            }
            return null;
        }

        private int vratiNajveciId() {
            int max = 0;
            Korisnik k;
            if (!Directory.Exists("Data\\Korisnici")){
                System.IO.Directory.CreateDirectory("Data\\Korisnici");
            }
            string[] filePaths = Directory.GetFiles("Data\\Korisnici");
            if (filePaths.Length != 0) {
                foreach (string filePath in filePaths) {
                    stream = File.Open(filePath, FileMode.Open);
                    k = (Korisnik)bf.Deserialize(stream);
                    stream.Close();
                    if (max < k.Id) {
                        max = k.Id;
                    }
                }
            }
            return max;
        }

    }
}
