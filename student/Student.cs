using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    [Serializable]
    public class Student : Persoana
    {
        private string facultate;
        private int note;

        public Student (int marca, string nume, string facultate, int note) : base (marca, nume)
        {
            this.facultate = facultate;
            this.note = note;
        }

        public Student() : base ()
        {
            this.facultate = "N/A";
            this.note = 0;
        }

        public string Facultate
        {
            get => facultate;
            set => facultate = value;
        }
        public int Note
        {
            get => note;
            set
            {
                if (value < 0)
                {
                    throw new Exception("ERR: Notele sunt negative! ");
                }
                else
                {
                    note = value;
                }
            }
        }
        public override string ToString()
        {
            return "Facultate: " + facultate
                + "Note: " + note
                + "\n";
        }

        //public static explicit operator float(Student s)
        //{
        //    float suma = 0;
        //    foreach (var nota in s.note)
        //    {
        //        suma += nota;
        //    }
        //    return suma / s.note;
        //}
    }
}
