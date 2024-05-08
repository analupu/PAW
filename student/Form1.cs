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

namespace student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = DataBase.Studenti;
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student();
                student.Marca = int.Parse(marcaTextBox.Text.Trim());
                student.Nume = numeTextBox.Text;
                student.Facultate = facultateTextBox.Text;
                student.Note = int.Parse(noteTextBox.Text.Trim());
                DataBase.Studenti.Add(student);
                marcaTextBox.Text = string.Empty;
                numeTextBox.Text = string.Empty;
                facultateTextBox.Text = string.Empty;
                noteTextBox.Text = string.Empty;
                MessageBox.Show("Studentul a fost adaugat cu succes! ");
            }
            catch (FormatException)
            {
                MessageBox.Show("Formatul datelor este gresit! ");
            }
            catch (Exception exec)
            {
                MessageBox.Show ("A aparut o eraoare! " + exec.Message);
            }
        }

        private void totiButton_Click(object sender, EventArgs e)
        {
            var selected = DataBase.Studenti.Where(x => x.Marca > 0).OrderByDescending(x => x.Marca).Select(x => x.Nume);
            var result = string.Join(", ", selected);
            MessageBox.Show(result);
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filename = "fisier.bin";
            using (var stream = new FileStream (filename, FileMode.OpenOrCreate))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, DataBase.Studenti);
            }
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filename = "fisier.bin";
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                var binaryFormatter = new BinaryFormatter();
                var data = (BindingList<Student>)binaryFormatter.Deserialize(stream);

                DataBase.Studenti = new BindingList<Student>(data);
                dataGridView.DataSource = DataBase.Studenti;
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
