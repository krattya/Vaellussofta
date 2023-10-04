using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentti_27_4_2023_Kalle_Rättyä
{
    internal class Vaellusreitti
    {
        public string nimi;
        public int pituus;
        public int vaikeusaste;
        public Taukopiste[] taukopisteet;

        public Vaellusreitti(string nimi, int pituus, int vaikeusaste, Taukopiste[] taukopisteet)
        {
            if (nimi == "")
            {
                throw new ArgumentException("Nimi ei voi olla tyhjä");
            }
            if (pituus < 10 || pituus > 100)
            {
                throw new ArgumentException("Pituus tulee olla väliltä 10 - 100");
            }
            if (vaikeusaste < 1 || vaikeusaste > 5)
            {
                throw new ArgumentException("Vaikeusaste tulee olla väliltä 1 - 5");
            }

            foreach (Taukopiste taukopiste in taukopisteet)
            {
                if (taukopiste.etaisyys >= pituus)
                {
                    throw new ArgumentException("Taukopisteen etäisyys tulee olla pienempi kuin vaelluksen pituus");
                }
            }

            this.nimi = nimi;
            this.pituus = pituus;
            this.vaikeusaste = vaikeusaste;
            this.taukopisteet = taukopisteet;
        }

        public override string ToString()
        {
            string taukopisteetStr = "";
            foreach (Taukopiste taukopiste in taukopisteet)
            {
                taukopisteetStr += taukopiste.Tunnus + " (" + taukopiste.etaisyys + " km), ";
            }
            taukopisteetStr = taukopisteetStr.TrimEnd(',', ' ');

            string info = "Vaellusreitti: " + nimi + "\n"
                        + "Pituus: " + pituus + " km\n"
                        + "Vaikeusaste: " + vaikeusaste + "\n"
                        + "Taukopisteet: " + taukopisteetStr;
            return info;
        }
    }
}
