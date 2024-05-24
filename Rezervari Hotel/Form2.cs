using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Rezervari_Hotel
{
    public partial class Form2 : Form
    {
        private  string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private  string ConnectionString;
        private string FilePath;
        private turisti turist;
        public Form2 (List<turisti> turisti)
        {
            InitializeComponent ();
            

            ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(BaseDirectory, "turisti.accdb")}";
            FilePath = Path.Combine(BaseDirectory, "turisti.txt");
            LoadDataFromDatabase();
            dataGridViewRerervari.CellClick += dataGridViewRerervari_CellContentClick;
        }

        public Form2()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(BaseDirectory, "turisti.accdb")}";
            FilePath = Path.Combine(BaseDirectory, "turisti.txt");
            dataGridViewRerervari.CellContentClick += dataGridViewRerervari_CellContentClick;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

            private void LoadDataFromFile()
        {
            var turistiList = new List<turisti>();
            if (File.Exists(FilePath))
            {
                var lines = File.ReadAllLines(FilePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    var turist = new turisti
                    {
                        Nume = data[0],
                        Prenume = data[1],
                        Varsta = int.Parse(data[2]),
                        Domiciliu = data[3]
                    };
                    turistiList.Add(turist);
                }
            }
            dataGridViewRerervari.DataSource = turistiList;
        }

        private void LoadDataFromDatabase()
        {
            using (var connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                var adapter = new OleDbDataAdapter("SELECT * FROM TURISTI", connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewRerervari.DataSource = dataTable;
            }
        }

       
        private void NUMARTURISTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTuristiCount();
        }

        private void UpdateTuristiCount()
        {

            int numarTuristiBazaDate = 0;
            using (var connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                var command = new OleDbCommand("SELECT COUNT(*) FROM TURISTI", connection);
                numarTuristiBazaDate = (int)command.ExecuteScalar();
            }

            MessageBox.Show($"Numărul total de turiști din baza de date este: {numarTuristiBazaDate}", "Numar Turisti");
        }



        private void AFISEAZATURISTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void iESIREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewRerervari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRerervari.Rows[e.RowIndex];

                string nume = row.Cells["Nume"].Value.ToString();
                string prenume = row.Cells["Prenume"].Value.ToString();
                int varsta = Convert.ToInt32(row.Cells["Varsta"].Value);
                string domiciliu = row.Cells["Domiciliu"].Value.ToString();


                Form3 form3 = new Form3(nume, prenume, varsta, domiciliu);
                form3.ShowDialog();
            }
        }

        private void aNULEAZAREZERVAREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewRerervari.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewRerervari.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value); 
                DeleteRowFromDatabase(id);
                dataGridViewRerervari.Rows.Remove(selectedRow);

            }
            else
            {
                MessageBox.Show("Selectați un rând pentru a șterge.");
            }
        }

        private void DeleteRowFromDatabase(int id)
        {
            using (var connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new OleDbCommand("DELETE FROM TURISTI WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
