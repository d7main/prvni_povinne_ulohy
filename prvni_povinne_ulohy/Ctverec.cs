using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvni_povinne_ulohy
{
    internal class Ctverec : Utvar
    {
        public Ctverec(double hrana) : base(hrana)
        {
        }
        public override double Plocha()
        {
            return hrana * hrana;
        }
        public override double Obvod()
        {
            return 4 * hrana;
        }
    }
}
