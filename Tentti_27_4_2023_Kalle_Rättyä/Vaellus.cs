using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentti_27_4_2023_Kalle_Rättyä
{
    internal class Vaellus
    {
        public string nimi;
        public int pituus;
        public int vaikeusaste;
        public Taukopiste[] taukopisteet;

        public Vaellus(string nimi, int pituus, int vaikeusaste)
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

            this.nimi = nimi;
            this.pituus = pituus;
            this.vaikeusaste = vaikeusaste;
            this.taukopisteet = new Taukopiste[3];
        }

        public void LisaaTaukopiste(Taukopiste piste)
        {
            
            if (piste.etaisyys >= this.pituus)
            {
                throw new ArgumentException("Taukopisteen etäisyys ei voi olla suurempi kuin vaelluksen pituus");
            }

            int i = 0;
            while (i < this.taukopisteet.Length && this.taukopisteet[i] != null)
            {
                i++;
            }

            if (i == this.taukopisteet.Length)
            {
                throw new InvalidOperationException("Kaikki taukopisteet on jo lisätty");
            }

            this.taukopisteet[i] = piste;
        }

        public override string ToString()
        {
            string s = "";
            s += "Vaellus: " + this.nimi + "\n";
            s += "Pituus: " + this.pituus + " km\n";
            s += "Vaikeusaste: " + this.vaikeusaste + "/5\n";
            s += "Taukopisteet:\n";
            for (int i = 0; i < this.taukopisteet.Length; i++)
            {
                if (this.taukopisteet[i] != null)
                {
                    s += "- " + this.taukopisteet[i].Tunnus + " (" + this.taukopisteet[i].etaisyys + " km)\n";
                }
            }
            return s;
        }
    }
}

