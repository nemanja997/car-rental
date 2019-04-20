using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_rental_project.Modeli
{
    class Automobil
    {
        private static int nextId = 1;
        private int id;
        private string marka;
        private string model;
        private int godiste;
        private int kubikaza;
        private string pogon;
        private string vrstaMenjaca;
        private string karoserija;
        private string gorivo;
        private int brojVrata;

        public Automobil(string marka, string model, int godiste, int kubikaza, string pogon, string vrstaMenjaca, string karoserija, string gorivo, int brojVrata)
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
            this.id = nextId++;
        }

        public int Id { get => id;}
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Godiste { get => godiste; set => godiste = value; }
        public int Kubikaza { get => kubikaza; set => kubikaza = value; }
        public string Pogon { get => pogon; set => pogon = value; }
        public string VrstaMenjaca { get => vrstaMenjaca; set => vrstaMenjaca = value; }
        public string Karoserija { get => karoserija; set => karoserija = value; }
        public string Gorivo { get => gorivo; set => gorivo = value; }
        public int BrojVrata { get => brojVrata; set => brojVrata = value; }
    }
}
