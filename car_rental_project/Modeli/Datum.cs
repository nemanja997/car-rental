using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_rental_project.Modeli
{
    class Datum
    {

        public static bool validanOpseg(DateTime datum1, DateTime datum2) {
            if (datum1.Date.CompareTo(datum2.Date) <= 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
        public static bool daLiJeOpsegUDozvoljenomOpsegu(DateTime trazeniDatum1, DateTime trazeniDatum2, DateTime dozvoljeniDatum1, DateTime dozvoljeniDatum2) {
            if (trazeniDatum1.Date.CompareTo(dozvoljeniDatum1.Date) >= 0 && trazeniDatum1.Date.CompareTo(dozvoljeniDatum2.Date) <= 0 &&
                trazeniDatum2.Date.CompareTo(dozvoljeniDatum1.Date) >= 0 && trazeniDatum2.Date.CompareTo(dozvoljeniDatum2.Date) <= 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
