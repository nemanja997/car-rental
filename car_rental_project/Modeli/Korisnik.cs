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
    class Korisnik
    {
        static Stream stream;
        static BinaryFormatter bf = new BinaryFormatter();

        private string korisnickoIme;
        private string lozinka;

        

        public Korisnik(string korisnickoIme, string lozinka)
        {
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
        }

        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }



        

        static public void napraviKorisnika(Korisnik korisnik)
        {
            string path = "Data\\" + korisnik.KorisnickoIme + ".bin";
            if (!Directory.Exists("Data"))
            {
                System.IO.Directory.CreateDirectory("Data");
            }
            if (!File.Exists(path))
            {
                stream = File.Open(path, FileMode.Create);
                bf.Serialize(stream, korisnik);
                stream.Close();
                MessageBox.Show("Uspesno ste dodali novog kupca!");
            }
            else
            {
                MessageBox.Show("Korisnik sa unetim korisnickim imenom vec postoji. Molimo odaberite drugo korisnicko ime.");
            }


        }

        static public void obrisiKorisnika(string korisnickoIme)
        {
            string path = "Data\\" + korisnickoIme + ".bin";
            if (File.Exists(path))
            {

                try
                {
                    File.Delete(path);
                    MessageBox.Show("Korisnik uspesno obrisan.");
                }
                catch (IOException)
                {
                    MessageBox.Show("Nije uspelo brisanje fajla za trazenog korisnika.");
                }

            }
            else
            {
                MessageBox.Show("Ne postoji fajl koji ste pokusali da obrisete.");
            }
        }

        static public void izmeniKorisnika(Korisnik korisnik)
        {

        }

        static public Korisnik pronadjiKorisnika(string korisnickoIme, string lozinka)
        {
            Korisnik korisnik;
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
                    if (korisnik.KorisnickoIme.Equals(korisnickoIme) && korisnik.Lozinka.Equals(lozinka))
                    {
                        MessageBox.Show("Uspesno logovanje");
                        return korisnik;
                    }
                }
            }
            return null;
        }

    }
}
