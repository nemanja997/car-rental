using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace car_rental_project.Modeli
{

    class MarkaAutomobila
    {

        private string brand;
        private List<string> models;

        public string Brand { get => brand; set => brand = value; }
        public List<string> Models { get => models; set => models = value; }

        public static List<MarkaAutomobila> vratiSveMarke()
        {
            List<MarkaAutomobila> sviModeli= new List<MarkaAutomobila>();
            List<string> listaSvihModela = new List<string>();
            string text = File.ReadAllText("Data\\ModeliAutomobila\\modeliAutomobila.json");
            if (File.Exists("Data\\ModeliAutomobila\\modeliAutomobila.json"))
            {   
                JavaScriptSerializer js = new JavaScriptSerializer();
                sviModeli = js.Deserialize<List<MarkaAutomobila>>(text);
                foreach (MarkaAutomobila model in sviModeli)
                {
                    listaSvihModela.Add(model.Brand);
                }
            }
            else {
                MessageBox.Show("Ne postoji fajl sa markama i modelima automobila.");
            }
            

            return sviModeli;
        }

        public static List<string> vratiModeleZaMarku(string marka)
        {
            List<string> listaSvihModelaZaMarku = new List<string>();


            return listaSvihModelaZaMarku;
        }
    }

    

}
