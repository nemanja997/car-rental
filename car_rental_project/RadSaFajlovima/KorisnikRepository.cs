using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace car_rental_project.RadSaFajlovima
{
    class KorisnikRepository
    {

        static public void napraviKorisnika(Korisnik korisnik)
        {
            if (!Directory.Exists(@"Data")){
                System.IO.Directory.CreateDirectory(@"Data");
            }
            Stream stream1 = File.Open(@"Data\" +korisnik.KorisnickoIme + ".bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream1, korisnik);
            stream1.Close();
           
        }

        static public void obrisiKorisnika(string ime)
        {
            
        }

        static public void promeniKorisnika(Korisnik korisnik)
        {
            
        }

        static public Korisnik pronadjiKorisnika(string korisnickoIme, string lozinka)
        {
            Korisnik korisnik;
            Stream stream2;
            BinaryFormatter bf = new BinaryFormatter();

            if (!Directory.Exists(@"Data")){
                System.IO.Directory.CreateDirectory(@"Data");
            }
            
            string[] filePaths = Directory.GetFiles(@"Data"); 
            foreach (string filePath in filePaths) {
                stream2 = File.Open(filePath, FileMode.Open);
                korisnik = (Korisnik)bf.Deserialize(stream2);
                stream2.Close();
                if (korisnik.KorisnickoIme.Equals(korisnickoIme) && korisnik.Lozinka.Equals(lozinka)) {
                    return korisnik;
                }
            }
            return null;
        }
    }
}
