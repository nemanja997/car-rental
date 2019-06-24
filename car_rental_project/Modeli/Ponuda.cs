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
    class Ponuda
    {
        private int id;
        private int idAutomobila;
        private DateTime datumOd;
        private DateTime datumDo;
        private int cenaPoDanu;

        public Ponuda()
        {
        }

        public Ponuda(int idAutomobila, DateTime datumOd, DateTime datumDo, int cenaPoDanu)
        {   
            this.IdAutomobila = idAutomobila;
            this.DatumOd = datumOd;
            this.DatumDo = datumDo;
            this.CenaPoDanu = cenaPoDanu;
            this.id = vratiNajveciId() + 1;
        }
        public int Id { get => id; set => id = value; }
        public int IdAutomobila { get => idAutomobila; set => idAutomobila = value; }
        public DateTime DatumOd { get => datumOd; set => datumOd = value; }
        public DateTime DatumDo { get => datumDo; set => datumDo = value; }
        public int CenaPoDanu { get => cenaPoDanu; set => cenaPoDanu = value; }

        public override string ToString()
        {
            List<Automobil> listaSvihAutomobila = Automobil.vratiSveAutomobile();
            return Id + " " + "Id automobila:" + IdAutomobila + " " + DatumOd.ToString("dd.MM.yyyy.") + "-" + DatumDo.ToString("dd.MM.yyyy.") + "Cena po danu:" + CenaPoDanu.ToString();
        }

        public static bool dodajPonudu(Ponuda ponuda)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream;
            string path = "Data\\Ponude\\" + ponuda.Id + ".bin";
            if (!Directory.Exists("Data\\Ponude"))
            {
                System.IO.Directory.CreateDirectory("Data\\Ponude");
            }
            if (!File.Exists(path))
            {
                stream = File.Open(path, FileMode.Create);
                bf.Serialize(stream, ponuda);
                stream.Close();
                MessageBox.Show("Uspesno ste dodali novu ponudu!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool izmeniPonudu(int idPonude,Ponuda novaPonuda)
        {
            novaPonuda.Id = idPonude;
            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();
            string[] filePaths = Directory.GetFiles("Data\\Ponude");
            Ponuda ponuda;
            foreach (string filePath in filePaths)
            {
                if (File.Exists(filePath))
                {
                    stream = File.Open(filePath, FileMode.Open);
                    ponuda = (Ponuda)bf.Deserialize(stream);
                    stream.Close();

                    if (ponuda.Id == idPonude)
                    {
                        try
                        {
                            File.Delete(filePath);
                        }
                        catch (IOException) { }
                        stream = File.Open("Data\\Ponude\\" + novaPonuda.Id + ".bin", FileMode.Create);
                        bf.Serialize(stream, novaPonuda);
                        stream.Close();
                        return true;
                    }
                }
            }
            return false;
        }


        public static List<Ponuda> vratiSvePonude() {
           

            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();
            Ponuda ponuda;
            List<Ponuda> listaSvihPonuda = new List<Ponuda>();


            if (!Directory.Exists("Data\\Ponude"))
            {
                System.IO.Directory.CreateDirectory("Data\\Ponude");
            }
            string[] filePaths = Directory.GetFiles("Data\\Ponude");
            foreach (string filePath in filePaths)
            {
                    
                    stream = File.Open(filePath, FileMode.Open);
                    ponuda = (Ponuda)bf.Deserialize(stream);
                    stream.Close();
                    listaSvihPonuda.Add(ponuda);
            }
            return listaSvihPonuda; 
        }

        static public void obrisiPonudu(int idPonude)
        {
            string path = "Data\\Ponude\\" + idPonude + ".bin";
            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                    MessageBox.Show("Ponuda uspesno obrisana.");
                }
                catch (IOException)
                {
                    MessageBox.Show("Nije uspelo brisanje fajla trazenog automobila.");
                }
            }
            else
            {
                MessageBox.Show("Ne postoji fajl koji ste pokusali da obrisete.");
            }
        }

        public static void obrisiSvePonudeZaAutomobil(int idAutomobila) {
            FileStream stream;
            BinaryFormatter bf = new BinaryFormatter();
            List<Ponuda> listaSvihPonuda = Ponuda.vratiSvePonude();
            foreach (Ponuda ponuda in listaSvihPonuda) {
                if (ponuda.IdAutomobila == idAutomobila) {
                    Ponuda.obrisiPonudu(ponuda.Id);
                }
            }

        }

        private int vratiNajveciId()
        {
            FileStream stream;
            BinaryFormatter bf = new BinaryFormatter();
            int max = 0;
            Ponuda ponuda;
            if (!Directory.Exists("Data\\Ponude"))
            {
                System.IO.Directory.CreateDirectory("Data\\Ponude");
            }
            string[] filePaths = Directory.GetFiles("Data\\Ponude");
            if (filePaths.Length != 0)
            {
                foreach (string filePath in filePaths)
                {
                    stream = File.Open(filePath, FileMode.Open);
                    ponuda = (Ponuda)bf.Deserialize(stream);
                    stream.Close();
                    if (max < ponuda.Id)
                    {
                        max = ponuda.Id;
                    }
                }
            }
            return max;
        }
    }

    
}
