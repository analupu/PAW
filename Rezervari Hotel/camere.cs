using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervari_Hotel
{
    public class camere
    {
        public string tipCamera;
        public double pret;
        public string tipVedere;

        public camere()
        {
            this.tipCamera = "N/A";
            this.pret = 0;
            this.tipVedere = "N/A";
        }

        public camere(string tipCamera, double pret, string tipVedere)
        {
            this.tipCamera = tipCamera;
            this.pret = (double)pret;
            this.tipVedere = tipVedere;
        }

        public string Tip
        {
            get => tipCamera;
            set => tipCamera = value;
        }

        public double Pret
        {
            get => pret;
            set
            {
                if (value < 0)
                {
                    throw new Exception("ERR: Pretul unei camere nu poate sa fie negativ! ");
                }
                else
                {
                    pret = value;
                }
            }
        }

        public string Vedere
        {
            get => tipVedere;
            set => tipVedere = value;
        }

        public override string ToString()
        {
            return "Tip de camera: " + tipCamera
                + "Pret: " + pret
                + "Tip de vedere: " + tipVedere
                + "\n";
        }
    }
}
