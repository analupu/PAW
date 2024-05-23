using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervari_Hotel
{
    public class turisti
    {
        public string nume;
        public string prenume;
        public int varsta;
        public string domiciliu;

        public turisti ()
        {
            this.nume = "ANONIM";
            this.prenume = "ANONIM";
            this.varsta = 0;
            this.domiciliu = "N/A";
        }

        public turisti (string nume, string prenume, int varsta, string domiciliu)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = (int)varsta;
            this.domiciliu = domiciliu;
        }

        public string Nume
        {
            get => nume;
            set => nume = value;
        }

        public string Prenume
        {
            get => prenume;
            set => prenume = value;
        }

        public int Varsta
        {
            get => varsta;
            set
            {
                if (value < 0)
                {
                    throw new Exception("ERR: Varsta unui turist nu poate sa fie negativa! ");
                }
                else
                {
                    varsta = value;
                }
            }
        }

        public string Domiciliu
        {
            get => domiciliu;
            set => domiciliu = value;
        }

        public override string ToString()
        {
            return "Nume: " + nume
                + "Prenume: " + prenume
                + "Varsta: " + varsta
                + "Domiciliu: " + domiciliu
                + "\n";
        }
    }
}
