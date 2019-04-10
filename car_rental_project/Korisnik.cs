using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_rental_project
{
    abstract class Korisnik
    {
        private string korisnickoIme;
        private string lozinka;


        protected Korisnik(string korisnickoIme, string lozinka)
        {
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
        }

        protected string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        protected string Lozinka { get => lozinka; set => lozinka = value; }

    }
}
