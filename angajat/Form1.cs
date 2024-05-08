using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace angajat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = Firma.Angajati;
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var angajat = new Angajat();
                angajat.Nume = numeTextBox.Text;
                angajat.Ore = int.Parse(oreTextBox.Text.Trim());
                angajat.Salariu = int.Parse(salariuTextBox.Text.Trim());
                Firma.Angajati.Add(angajat);
                numeTextBox.Text = string.Empty;
                oreTextBox.Text = string.Empty;
                salariuTextBox.Text = string.Empty;
                MessageBox.Show("Angajatul cu numele " + angajat.Nume + " a fost adaugat cu succes! ");
            }
            catch (FormatException)
            {
                MessageBox.Show("Formatul datelor introduse este gresit! ");
            }
            catch (Exception exec)
            {
                MessageBox.Show("A aparut o eroare! " + exec.Message);
            }
        }

        private void totiButton_Click(object sender, EventArgs e)
        {
            var selected = Firma.Angajati.Where(x => x.Salariu > 0).OrderByDescending(x => x.Salariu).Select(x => x.Nume);
            var result = string.Join(", ", selected);
            MessageBox.Show(result);       
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filename = "fisier.bin";
            using (var stream = new FileStream (filename, FileMode.OpenOrCreate))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, Firma.Angajati.ToList());
            }     
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filename = "fisier.bin";
            using (var stream = new FileStream (filename, FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                var data = (List<Angajat>)binaryFormatter.Deserialize(stream);

                Firma.Angajati = new BindingList<Angajat>(data);
                dataGridView.DataSource = Firma.Angajati;
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void medieButton_Click(object sender, EventArgs e)
        {
            float medie = 0;
            foreach (var ang in Firma.Angajati)
            {
                medie = medie + ang.Salariu / ang.Ore;
            }
            var result = medie.ToString();
            MessageBox.Show(result);
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            float suma = 0;
            foreach (var ang in Firma.Angajati)
            {
                suma = suma + ang.Salariu * ang.Ore;
            }
            var result = suma.ToString();
            MessageBox.Show(result);
        }
    }
}
