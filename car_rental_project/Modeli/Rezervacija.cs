using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental_project.Modeli
{
    [Serializable]
    class Rezervacija
    {
        private int id;
        private int idAutomobila;
        private int idKupca;
        private DateTime datumOd;
        private DateTime datumDo;
        private double cena;

        public Rezervacija(int idAutomobila, int idKupca, DateTime datumOd, DateTime datumDo, double cena)
        {
            this.IdAutomobila = idAutomobila;
            this.IdKupca = idKupca;
            this.DatumOd = datumOd;
            this.DatumDo = datumDo;
            this.Cena = cena;
            this.id = vratiNajveciId() + 1;
        }

        public int IdAutomobila { get => idAutomobila; set => idAutomobila = value; }
        public int IdKupca { get => idKupca; set => idKupca = value; }
        public DateTime DatumOd { get => datumOd; set => datumOd = value; }
        public DateTime DatumDo { get => datumDo; set => datumDo = value; }
        public double Cena { get => cena; set => cena = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            Kupac trenutniKupac =null;
            List<Kupac> sviKupci = Kupac.vratiSveKupce();
            foreach (Kupac kupac in sviKupci) {
                if (kupac.Id == this.IdKupca) {
                    trenutniKupac = kupac;
                }
            }
            return "(" + trenutniKupac.Ime + " " + trenutniKupac.Prezime +  ") " + DatumOd.ToString("dd.MM.yyyy.") + " - " + DatumDo.ToString("dd.MM.yyyy.") + "Cena: " + Cena.ToString() + " dinara po danu";
        }
        static public bool napraviRezervaciju(Rezervacija rezervacija)
        {
            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();

            string path = "Data\\Rezervacije\\" + rezervacija.Id +".bin";
            if (!Directory.Exists("Data\\Rezervacije")) {
                System.IO.Directory.CreateDirectory("Data\\Rezervacije");
            }
            if (!File.Exists(path)){
                stream = File.Open(path, FileMode.Create);
                bf.Serialize(stream, rezervacija);
                stream.Close();
                return true;
            }else{ 
                return false;
            }
        }

        static public void obrisiRezervaciju(int idRezervacije)
        {
            string path = "Data\\Rezervacije\\" + idRezervacije + ".bin";
            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                    MessageBox.Show("Rezervacija uspesno obrisana.");

                }
                catch (IOException)
                {
                    MessageBox.Show("Nije uspelo brisanje fajla trazene ponude.");
                }
            }
            else
            {
                MessageBox.Show("Ne postoji fajl koji ste pokusali da obrisete.");
            }
        }

        public static List<Rezervacija> vratiRezervacijeZaKupca(int idKupca) {
            List<Rezervacija> rezervacijeZaKupca = new List<Rezervacija>();
            
            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();
            Rezervacija rezervacija;
            string[] filePaths = Directory.GetFiles("Data\\Rezervacije");

            if (!Directory.Exists("Data\\Rezervacije"))
            {
                System.IO.Directory.CreateDirectory("Data\\Rezervacije");
            }
            if (filePaths.Length != 0) {
                foreach (string filePath in filePaths)
                {
                    if (File.Exists(filePath))
                    {
                        stream = File.Open(filePath, FileMode.Open);
                        rezervacija = (Rezervacija)bf.Deserialize(stream);
                        stream.Close();
                        if (rezervacija.IdKupca == idKupca)
                        {
                            rezervacijeZaKupca.Add(rezervacija);
                        }
                    }
                }
            }

            return rezervacijeZaKupca;

        }

        

        public static List<Rezervacija> vratiSveRezervacije()
        {
            List<Rezervacija> sveRezervacije = new List<Rezervacija>();

            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();
            Rezervacija rezervacija;
            string[] filePaths = Directory.GetFiles("Data\\Rezervacije");

            if (!Directory.Exists("Data\\Rezervacije"))
            {
                System.IO.Directory.CreateDirectory("Data\\Rezervacije");
            }
            if (filePaths.Length != 0)
            {
                foreach (string filePath in filePaths)
                {
                    if (File.Exists(filePath))
                    {
                        stream = File.Open(filePath, FileMode.Open);
                        rezervacija = (Rezervacija)bf.Deserialize(stream);
                        stream.Close();
                        sveRezervacije.Add(rezervacija);
                    }
                }
            }
            return sveRezervacije;
        }

        public static bool izmeniRezervaciju(int idRezervacije, Rezervacija novaRezervacija)
        {
            novaRezervacija.Id = idRezervacije;
            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();
            string[] filePaths = Directory.GetFiles("Data\\Rezervacije");
            Rezervacija rezervacija;
            foreach (string filePath in filePaths)
            {
                if (File.Exists(filePath))
                {
                    stream = File.Open(filePath, FileMode.Open);
                    rezervacija = (Rezervacija)bf.Deserialize(stream);
                    stream.Close();

                    if (rezervacija.Id == idRezervacije)
                    {
                        try
                        {
                            File.Delete(filePath);
                        }
                        catch (IOException) { }
                        stream = File.Open("Data\\Rezervacije\\" + novaRezervacija.Id + ".bin", FileMode.Create);
                        bf.Serialize(stream, novaRezervacija);
                        stream.Close();
                        return true;
                    }
                }
            }
            return false;
        }

        private int vratiNajveciId()
        {
            FileStream stream;
            BinaryFormatter bf = new BinaryFormatter();
            int max = 0;
            Rezervacija rezervacija;
            if (!Directory.Exists("Data\\Rezervacije"))
            {
                System.IO.Directory.CreateDirectory("Data\\Rezervacije");
            }
            string[] filePaths = Directory.GetFiles("Data\\Rezervacije");
            if (filePaths.Length != 0)
            {
                foreach (string filePath in filePaths)
                {
                    stream = File.Open(filePath, FileMode.Open);
                    rezervacija = (Rezervacija)bf.Deserialize(stream);
                    stream.Close();
                    if (max < rezervacija.Id)
                    {
                        max = rezervacija.Id;
                    }
                }
            }
            return max;
        }

    }
}
