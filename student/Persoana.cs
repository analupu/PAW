using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    [Serializable]
    public class Persoana
    {
        private int marca;
        private string nume;

        public Persoana (int marca, string nume)
        {
            this.marca = marca;
            this.nume = nume;
        }

        public Persoana()
        {
            this.marca = 0;
            this.nume = "N/A";
        }

        public int Marca
        {
            get => marca;
            set
            {

                if (value < 0)
                {
                    throw new Exception("ERR: Marca este negativa! ");
                }
                else
                {
                    marca = value;
                }
            }
        }

        public string Nume
        {
            get => nume;
            set => nume = value;
        }

        public override string ToString()
        {
            return "Marca: " + marca
                + "Nume: " + nume
                + "\n";
        }
    }
}
