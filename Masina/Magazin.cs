using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masina
{
    public class Magazin
    {
        public List<Masina> magazinMasini { get; set; }
        public List<Masina> cos { get; set; }
        public Magazin()
        {
            magazinMasini = new List<Masina>();
            cos = new List<Masina>();
        }

        //metoda checkout
        public double CheckOut()
        {
            double costTotal = 0;
            foreach (var c in cos)
            {
                costTotal = costTotal + c.pret;
            }
            cos.Clear();
            return costTotal;
        }
    }
}
