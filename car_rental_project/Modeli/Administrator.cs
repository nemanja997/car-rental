using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_rental_project
{   
    [Serializable()]
    class Administrator : Korisnik
    {   

        public Administrator(string korisnickoIme, string lozinka) : base(korisnickoIme, lozinka)
        {
            
        }
        
    }
}
