using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervari_Hotel
{
    public class rezervari
    {
        public string destinatie;
        int numarZile;
        public DateTime dataSosire { get; set; }
        public DateTime dataPlecare { get; set; }

        public string Destinatie
        {
            get => destinatie;
            set => destinatie = value;
        }

        public int Zile
        {
            get => numarZile;
            set
            {
                if (value < 0)
                {
                    throw new Exception("ERR: Nu ati selectat perioada sejurului! ");
                }
                else
                {
                    numarZile = value;
                }
            }
        }

        public rezervari(string destinatie, int numarZile, DateTime dataSosire, DateTime dataPlecare)        {
            Destinatie = destinatie;
            this.numarZile = numarZile;
            this.dataSosire = dataSosire;
            this.dataPlecare = dataPlecare;
        }

        public override string ToString()
        {
            return "Destinatie: " + destinatie
                + "Numarul de zile: " + numarZile
                + "Data sosire: " + dataSosire
                + "Data plecare: " + dataPlecare
                + "\n";
        }
    }
}
