using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentti_27_4_2023_Kalle_Rättyä
{
    internal class Taukopiste
    {
        public string Tunnus;
        public int etaisyys;

        public Taukopiste(string Tunnus, int etaisyys)
        {
            
            if (Tunnus == "")
            {
                throw new ArgumentException("Tunnus ei voi olla tyhjä");
            }
            if (etaisyys < 0)
            {
                throw new ArgumentException("Etäisyys ei voi olla negatiivinen");
            }

            this.Tunnus = Tunnus;
            this.etaisyys = etaisyys;
        }
    }
}
