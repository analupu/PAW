using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angajat
{
    [Serializable]
    public class Angajat
    {
        private string nume;
        private int oreLucrate;
        private int salariuOrar;

        public Angajat (string nume, int oreLucrate, int salariuOrar)
        {
            this.nume = nume;
            this.oreLucrate = oreLucrate;
            this.salariuOrar = salariuOrar;
        }

        public Angajat()
        {
            this.nume = "N/A";
            this.oreLucrate = 0;
            this.salariuOrar = 0;
        }

        public string Nume
        {
            get => nume;
            set => nume = value;
        }

        public int Ore
        {
            get => oreLucrate;
            set
            {
                if (value < 0)
                {
                    throw new Exception("ERR: Numarul de ore este negativ! ");
                }
                else
                {
                    oreLucrate = value;
                }
            }
        }

        public int Salariu
        {
            get => salariuOrar;
            set
            {
                if ( value < 0 )
                {
                    throw new Exception("ERR: Salariul este negativ! ");
                }
                else
                {
                    salariuOrar = value;
                }
            }
        }

        public override string ToString()
        {
            return "Nume: " + nume
                + "Numarul de ore lucrate: " + oreLucrate
                + "Salariul per ora este: " + salariuOrar
                + "\n";
        }

        public double calculeazaTotalSalarii (List<Angajat> Angajati)
        {
            float total = 0;
            foreach (Angajat ang in Angajati)
            {
                total = total + ang.oreLucrate * ang.salariuOrar;
            }
            return total;
        }
    }
}
