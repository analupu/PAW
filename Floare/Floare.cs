using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Floare
{
    public class Floare : ICloneable 
    {
        public string denumire;
        public string culoare;
        public int nrBulbi;

        public Floare()
        {
            this.denumire = "N/A";
            this.culoare = "N/A";
            this.nrBulbi = 0;
        }

        public Floare (string denumire, string culoare, int nrBulbi)
        {
            this.denumire = denumire;
            this.culoare = culoare;
            this.nrBulbi = (int)nrBulbi; // trebuie sa fac cast la int
        }

        public string Denumire
        {
            get => denumire;
            set => denumire = value;
        }

        public string Culaore
        {
            get => culoare;
            set => culoare = value;
        }

        public int NrBulbi
        {
            get => nrBulbi;
            set
            {
                if (value < 0)
                {
                    throw new Exception("ERR: Numarul de bulbi este negativ! ");
                }
            } 
        }

        public object Clone()
        {
            return new Floare()
            {
                denumire = this.denumire,
                culoare = this.culoare,
                nrBulbi = this.nrBulbi
            };
        }

        public override string ToString()
        {
            return "Denumire: " + denumire
                + "Culoare: " + culoare
                + "Numarul de bulbi: " + nrBulbi
                + "\n";
        }

        public static Floare operator + (Floare f1, Floare f2)
        {
            return new Floare()
            {
                denumire = f1.denumire + f2.denumire,
                culoare = f1.culoare + f2.culoare,
                nrBulbi = f1.nrBulbi + f2.nrBulbi
            };
        }
    }
}
