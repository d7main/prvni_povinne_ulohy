using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvni_povinne_ulohy
{
    public class Kruh : Utvar
    {
        public Kruh(double hrana) : base(hrana)
        {
        }
        public override double Plocha()
        {
            return Math.PI * hrana * hrana;
        }
        public override double Obvod()
        {
            return 2 * Math.PI * hrana;
        }
    }
}
