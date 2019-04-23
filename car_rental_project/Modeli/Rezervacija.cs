using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace car_rental_project.Modeli
{
    [Serializable]
    class Rezervacija
    {
        
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
        }

        public int IdAutomobila { get => idAutomobila; set => idAutomobila = value; }
        public int IdKupca { get => idKupca; set => idKupca = value; }
        public DateTime DatumOd { get => datumOd; set => datumOd = value; }
        public DateTime DatumDo { get => datumDo; set => datumDo = value; }
        public double Cena { get => cena; set => cena = value; }

        public override string ToString()
        {
            return DatumOd.ToString("dd.MM.yyyy.") + " - " + DatumDo.ToString("dd.MM.yyyy.") + "Cena: " + Cena.ToString() + "dinara po danu";
        }
        static public bool napraviRezervaciju(Rezervacija rezervacija)
        {
            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();

            string path = "Data\\Rezervacije\\" + rezervacija.idAutomobila + "-" +  rezervacija.idKupca + "-" + 
                rezervacija.datumDo.ToString("dd-MM-yyyy") + "-" +  rezervacija.datumDo.ToString("dd-MM-yyyy") +".bin";
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

        public static List<Rezervacija> vratiRezervacijeZaKupca(Kupac kupac) {
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
                        if (rezervacija.IdKupca == kupac.Id)
                        {
                            rezervacijeZaKupca.Add(rezervacija);
                        }
                        
                    }
                }
            }
            

            return rezervacijeZaKupca;

        }
    }
}
