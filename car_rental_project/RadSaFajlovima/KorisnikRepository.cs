using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental_project.RadSaFajlovima
{
    class KorisnikRepository
    {

        static public void napraviKorisnika(Korisnik korisnik)
        {
            string path = "Data\\" + korisnik.KorisnickoIme + ".bin";
            if ( !Directory.Exists("Data") ){
                System.IO.Directory.CreateDirectory("Data");
            }
            if ( !File.Exists(path) ) {
                Stream stream = File.Open(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, korisnik);
                stream.Close();
            }
            else {
                MessageBox.Show("Korisnik sa unetim korisnickim imenom vec postoji. Molimo odaberite drugo korisnicko ime.");
            }
            
           
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
            Stream stream;
            BinaryFormatter bf = new BinaryFormatter();

            if ( !Directory.Exists("Data") ){
                System.IO.Directory.CreateDirectory("Data");
            }
            
            string[] filePaths = Directory.GetFiles("Data"); //Uzmi sve fajlove iz Data foldera
            foreach (string filePath in filePaths) {

                if ( File.Exists(filePath) )
                {
                    stream = File.Open(filePath, FileMode.Open);
                    korisnik = (Korisnik)bf.Deserialize(stream);
                    stream.Close();
                    if ( korisnik.KorisnickoIme.Equals(korisnickoIme) && korisnik.Lozinka.Equals(lozinka) )
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
