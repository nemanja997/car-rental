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
    class Automobil
    {   
        
        private static FileStream stream;
        private int id;
        private string marka;
        private string model;
        private int godiste;
        private string kubikaza;
        private string pogon;
        private string vrstaMenjaca;
        private string karoserija;
        private string gorivo;
        private string brojVrata;

        public Automobil(string marka, string model, int godiste, string kubikaza, string pogon, string vrstaMenjaca, string karoserija, string gorivo, string brojVrata)
        {
            this.Marka = marka;
            this.Model = model;
            this.Godiste = godiste;
            this.Kubikaza = kubikaza;
            this.Pogon = pogon;
            this.VrstaMenjaca = vrstaMenjaca;
            this.Karoserija = karoserija;
            this.Gorivo = gorivo;
            this.BrojVrata = brojVrata;
            this.id = vratiNajveciId() + 1;
        }

        public int Id { get => id;}
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Godiste { get => godiste; set => godiste = value; }
        public string Kubikaza { get => kubikaza; set => kubikaza = value; }
        public string Pogon { get => pogon; set => pogon = value; }
        public string VrstaMenjaca { get => vrstaMenjaca; set => vrstaMenjaca = value; }
        public string Karoserija { get => karoserija; set => karoserija = value; }
        public string Gorivo { get => gorivo; set => gorivo = value; }
        public string BrojVrata { get => brojVrata; set => brojVrata = value; }

        public override string ToString()
        {
            return Id + " " + Marka + " " + Model + " " + Godiste + " god. " + Kubikaza + " " + Gorivo +" " + VrstaMenjaca + " " + Karoserija + " " + Pogon + " pogon" + BrojVrata + " vrata";
        }

        public static bool dodajAutomobil(Automobil automobil)
        {   
            BinaryFormatter bf = new BinaryFormatter();
            string path = "Data\\Automobili\\" + automobil.Id + ".bin";
            if (!Directory.Exists("Data\\Automobili"))
            {
                System.IO.Directory.CreateDirectory("Data\\Automobili");
            }
            if (!File.Exists(path))
            {
                stream = File.Open(path, FileMode.Create);
                bf.Serialize(stream, automobil);
                stream.Close();
                MessageBox.Show("Uspesno ste dodali novi automobil!");
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void obrisiAutomobil(int id)
        {
            string path = "Data\\Automobili\\" + id + ".bin";
            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                    MessageBox.Show("Automobil uspesno obrisan.");
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

        public static List<Automobil> vratiSveAutomobile()
        {
            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();
            Automobil automobil;
            List<Automobil> listaAutomobila = new List<Automobil>();
            

            if (!Directory.Exists("Data\\Automobili"))
            {   
                System.IO.Directory.CreateDirectory("Data\\Automobili");
            }
            string[] filePaths = Directory.GetFiles("Data\\Automobili");
            foreach (string filePath in filePaths)
            {
                if (File.Exists(filePath))
                {
                    stream = File.Open(filePath, FileMode.Open);
                    automobil = (Automobil)bf.Deserialize(stream);
                    stream.Close();
                    listaAutomobila.Add(automobil);
                }
            }
            return listaAutomobila;
        }

        public static bool izmeniAutomobil(int id, Automobil izmenjeniAutomobil)
        {
            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();
            string[] filePaths = Directory.GetFiles("Data\\Automobili");
            Automobil automobil;
            foreach (string filePath in filePaths)
            {
                if (File.Exists(filePath))
                {
                    stream = File.Open(filePath, FileMode.Open);
                    automobil = (Automobil)bf.Deserialize(stream);
                    stream.Close();

                    if (automobil.Id == id)
                    {
                        try
                        {
                            File.Delete(filePath);
                        }
                        catch (IOException) { }
                        stream = File.Open("Data\\Automobili\\" + izmenjeniAutomobil.Id + ".bin", FileMode.Create);
                        bf.Serialize(stream, izmenjeniAutomobil);
                        
                        stream.Close();
                        return true;
                    }
                }
            }
            return false;
        }

        private int vratiNajveciId()
        {
            BinaryFormatter bf = new BinaryFormatter();
            int max = 0;
            Automobil automobil;
            if (!Directory.Exists("Data\\Automobili"))
            {
                System.IO.Directory.CreateDirectory("Data\\Automobili");
            }
            string[] filePaths = Directory.GetFiles("Data\\Automobili");
            if (filePaths.Length != 0)
            {
                foreach (string filePath in filePaths)
                {
                    stream = File.Open(filePath, FileMode.Open);
                    automobil = (Automobil)bf.Deserialize(stream);
                    stream.Close();
                    if (max < automobil.Id)
                    {
                        max = automobil.Id;
                    }
                }
            }
            return max;
        }

    }

    
}
