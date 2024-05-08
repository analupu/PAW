using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floare
{
    public partial class Form1 : Form
    {
        public List<Floare> flori { get; set; }
        public Form1()
        {
            flori = getFlori();
            InitializeComponent();
        }

        private List<Floare> getFlori()
        {
            var list = new List<Floare>();
            list.Add(new Floare() { denumire = "Lalea", culoare = "Alb", nrBulbi = 25 });
            list.Add(new Floare() { denumire = "Zambila", culoare = "Roz", nrBulbi = 30 });
            list.Add(new Floare() { denumire = "Narcisa", culoare = "Galben", nrBulbi = 15 });
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var flori = this.flori;
            dataGridView.DataSource = flori;
            Floare f1 = new Floare("Craita", "Portocaliu", 5);
            Floare f2 = new Floare("Ghiocel", "Alb", 4);
            MessageBox.Show("Floarea este: " + " " + f1.denumire + " " + "are culoarea " + " " + f1.culoare + " " + "si numarul de bulbi este " + f1.nrBulbi);
            MessageBox.Show("Floarea este: " + " " + f2.denumire + " " + "are culoarea " + " " + f2.culoare + " " + "si numarul de bulbi este " + f2.nrBulbi);
            Floare f3 = f1 + f2;
            MessageBox.Show("Floarea este: " + " " + f3.denumire + " " + "are culoarea " + " " + f3.culoare + " " + "si numarul de bulbi este " + f3.nrBulbi);
        }

        private void dataGridView_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedFloare = dataGridView.SelectedRows[0].DataBoundItem as Floare;
                // nu uita sa redenumesti textbox - urile !!!
                Denumire.Text = selectedFloare.denumire;
                Culoare.Text = selectedFloare.culoare;
                Bulbi.Text = selectedFloare.nrBulbi.ToString();
            }
            catch (Exception exec)
            {
                MessageBox.Show("A aparut o eroare! " + exec.Message + " - " + exec.Source);
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.ShowDialog();
        }
    }
}
