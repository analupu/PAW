using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masina
{
    public partial class Form1 : Form
    {

        public List<Masina> Masini { get; set; }
        public Form1()
        {
            Masini = getMasini();
            InitializeComponent();
        }

        private List<Masina> getMasini()
        {
            var list = new List<Masina>();
            list.Add(new Masina() { marca = "Dacia", model = "Duster", pret = 17000 });
            list.Add(new Masina() { marca = "Mazda", model = "CX3", pret = 25000 });
            list.Add(new Masina() { marca = "Peugeot", model = "3008", pret = 36000 });
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Masina m1 = new Masina("Dacia", "Spring", 20000);
            Masina m2 = new Masina("Subaru", "Forester", 49000);
            MessageBox.Show("Masina este: " + m1.marca + " " + m1.model + " " + "si are pretul de " + " " + m1.pret + ".");
            MessageBox.Show("Masina este: " + m2.marca + " " + m2.model + " " + "si are pretul de " + " " + m2.pret + ".");

            Magazin ma = new Magazin();
            ma.cos.Add(m1);
            ma.cos.Add(m2);
            double costTotal = ma.CheckOut();
            MessageBox.Show("Valoare totala: " + costTotal);
            var masini = this.Masini;
            dataGridView.DataSource = masini;

            Masina m3 = m1 + m2;
            MessageBox.Show("Masina rezultata este: " + m3.marca + " " + m3.model + " " + "si are pretul de " + " " + m3.pret);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedMasina = dataGridView.SelectedRows[0].DataBoundItem as Masina;
                Marca.Text = selectedMasina.marca;
                Model.Text = selectedMasina.model;
                Pret.Text = selectedMasina.pret.ToString();
            }
            catch (Exception exec)
            {
                MessageBox.Show("A aparut o eroare! " + exec.Message + " - " + exec.Source);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.ShowDialog();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Masina m4 = new Masina();
        Masina m5 = new Masina();
    }
}
