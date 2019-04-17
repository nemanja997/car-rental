using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_rental_project
{
    class Kupac : Korisnik
    {
        private int id;
        private string ime;
        private string prezime;
        private long jmbg;
        private DateTime datumRodjenja;
        private int telefon;

        public Kupac(string korisnickoIme, string lozinka, int id, string ime, string prezime, long jmbg, DateTime datumRodjenja, int telefon) : base(korisnickoIme, lozinka)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.telefon = telefon;
        }
        
        
        public int Id { get => id; set => id = value; }
        public string Ime1 { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public long Jmbg { get => jmbg; set => jmbg = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public int Telefon { get => telefon; set => telefon = value; }
    }
}
