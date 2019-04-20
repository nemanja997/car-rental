using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_rental_project.Modeli
{
    class Ponuda
    {
        private int idAutomobila;
        private string datumOd;
        private string datumDo;
        private double cenaPoDanu;

        public Ponuda()
        {
        }

        public Ponuda(int idAutomobila, string datumOd, string datumDo, double cenaPoDanu)
        {
            this.IdAutomobila = idAutomobila;
            this.DatumOd = datumOd;
            this.DatumDo = datumDo;
            this.CenaPoDanu = cenaPoDanu;
        }
        
        public int IdAutomobila { get => idAutomobila; set => idAutomobila = value; }
        public string DatumOd { get => datumOd; set => datumOd = value; }
        public string DatumDo { get => datumDo; set => datumDo = value; }
        public double CenaPoDanu { get => cenaPoDanu; set => cenaPoDanu = value; }
    }
}
