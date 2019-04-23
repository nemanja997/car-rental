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

    class ModelAutomobila
    {

        private string brand;
        private List<string> models;

        public string Brand { get => brand; set => brand = value; }
        public List<string> Models { get => models; set => models = value; }

        public static List<string> vratiSveMarke()
        {
            List<string> listaSvihModela = new List<string>();
            string text = File.ReadAllText("Data\\ModeliAutomobila\\modeliAutomobila.json");
            MessageBox.Show(text);
            if (File.Exists("Data\\ModeliAutomobila\\modeliAutomobila.json"))
            {   
                JavaScriptSerializer js = new JavaScriptSerializer();
                List<ModelAutomobila> sviModeli = js.Deserialize<List<ModelAutomobila>>(text);
                foreach (ModelAutomobila model in sviModeli)
                {
                    listaSvihModela.Add(model.Brand);
                }
            }
            else {
                MessageBox.Show("Ne postoji fajl sa markama i modelima automobila.");
            }
            

            return listaSvihModela;
        }

        public static List<string> vratiModeleZaMarku(string marka)
        {
            List<string> listaSvihModelaZaMarku = new List<string>();


            return listaSvihModelaZaMarku;
        }
    }

    

}
