using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Masina
{
    public class Masina : ICloneable
    {
       public string marca;
       public string model;
       public double pret;

        //constructor cu parametri
        public Masina(string marca, string model, double pret)
        {
            this.marca = marca;
            this.model = model;
            this.pret = pret;
        }

        //constructor implicit
        public Masina()
        {
            this.marca = "N/A";
            this.model = "N/A";
            this.pret = 0;
        }

        //proprietati
        public string MarcaP
        {
            get => marca;
            set => marca = value;
        }
        public string ModelP
        {
            get => model;
            set => marca = value;
        }
        public double PretP
        {
            get => pret;
            set
            {
                if (value < 0)
                {
                    throw new Exception("ERR: Pretul masinii este negativ! ");
                }
                else
                {
                    pret = value;
                }
            }
        }

        public object Clone()
        {
            return new Masina()
            {
                marca = this.marca,
                model = this.model,
                pret = this.pret,
            };
        }
        // ########################### // PANA AICI OBLIGATORIU // ##############################
        public override string ToString()
        {
            return "Marca: " + marca
                + "Model: " + model
                + "Pret: " + pret
                + "\n";
        }

        public static Masina operator + (Masina m1, Masina m2)
        {
            return new Masina()
            {
                marca = m1.marca + m2.marca,
                model = m1.model + m2.model,
                pret = m1.pret + m2.pret
            };
        }
    }
}



