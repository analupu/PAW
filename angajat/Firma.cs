using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angajat
{
    public class Firma
    {
        private string numeFirma;
        public static BindingList<Angajat> Angajati = new BindingList<Angajat>();

        public Firma(string numeFirma)
        {
            this.numeFirma = numeFirma;
        }

        public string Nume
        {
            get => numeFirma;
            set => numeFirma = value;
        }
        //public static Firma operator +(Firma firma, Angajat angajat)
        //{
        //    firma.Angajati.Add(angajat);
        //    return firma;
        //}
    }
}
