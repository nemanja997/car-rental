using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_rental_project.Modeli
{
    class Rezervacija
    {
        private int idAutomobila;
        private int idKupca;
        private string datumOd;
        private string datumDo;
        private double cena;

        public Rezervacija(int idAutomobila, int idKupca, string datumOd, string datumDo, double cena)
        {
            this.IdAutomobila = idAutomobila;
            this.IdKupca = idKupca;
            this.DatumOd = datumOd;
            this.DatumDo = datumDo;
            this.Cena = cena;
        }

        public int IdAutomobila { get => idAutomobila; set => idAutomobila = value; }
        public int IdKupca { get => idKupca; set => idKupca = value; }
        public string DatumOd { get => datumOd; set => datumOd = value; }
        public string DatumDo { get => datumDo; set => datumDo = value; }
        public double Cena { get => cena; set => cena = value; }

    }
}
