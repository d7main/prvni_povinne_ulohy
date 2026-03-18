using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvni_povinne_ulohy
{
  public class Trojuhelnik : Utvar
    {
        public Trojuhelnik(double hrana) : base(hrana)
        {

        }

        public override double Plocha()
        {
            return (Math.Sqrt(3) / 4) * hrana * hrana;
        }

        public override double Obvod()
        {
            return 3 * hrana;
        }
    }
}
