using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvni_povinne_ulohy
{
    public abstract class Utvar
    {
        protected double hrana;

        public Utvar(double hrana)
        {
            this.hrana = hrana;
        }

        public abstract double Plocha();
        public abstract double Obvod();
    }
}
