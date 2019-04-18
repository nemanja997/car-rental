using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace car_rental_project
{   
    [Serializable()]
    class Kupac : Korisnik
    {
        private int id;
        private string ime;
        private string prezime;
        private string jmbg;
        private string datumRodjenja;
        private string telefon;

        public Kupac(string korisnickoIme, string lozinka, int id, string ime, string prezime, string jmbg, string datumRodjenja, string telefon) : base(korisnickoIme, lozinka)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.telefon = telefon;
        }
        
        
        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return Id + ", " +"Korisnicko ime: " + KorisnickoIme;
        }
    }
}
