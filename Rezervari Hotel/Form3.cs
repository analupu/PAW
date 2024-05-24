//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervari_Hotel
{
    public partial class Form3 : Form
    {

        private List<string> listaDeDestinatii = new List<string>
        {
            "Iasi", "Suceava", "Brasov", "Arad", "Plaiul Foii",
            "Ciucas", "Straja", "Ceahlau", "Durau", "Cetatile Ponorului",
            "Balea Lac", "Arieseni", "Paltinis"
        };

        public Form3(string nume, string prenume, int varsta, string domiciliu)
        {
            InitializeComponent();
            numeBox.Text = nume;
            prenumeBox.Text = prenume;
            varstaBox.Text = varsta.ToString();
            domiciliuBox.Text = domiciliu;

            destinatiiComboBox.Items.AddRange(new string[]
          {
                "Iasi", "Suceava", "Brasov", "Arad", "Plaiul Foii",
                "Ciucas", "Straja", "Ceahlau", "Durau", "Cetatile Ponorului",
                "Balea Lac", "Arieseni", "Paltinis"
          });
        }

        public string GetInformations()
        {
            string nume = numeBox.Text;
            string prenume = prenumeBox.Text;
            string varsta = varstaBox.Text;
            string domiciliu = domiciliuBox.Text;
            string destinatie = destinatiiComboBox.SelectedItem.ToString();
            string numarZile = zileBox.Text;
            string dataSosire = dateTimePickerSosire.Value.ToShortDateString();
            string dataPlecare = dateTimePickerPlecare.Value.ToShortDateString();

            return $"Nume: {nume}\n" +
                   $"Prenume: {prenume}\n" +
                   $"Varsta: {varsta}\n" +
                   $"Domiciliu: {domiciliu}\n" +
                   $"Destinatie: {destinatie}\n" +
                   $"Numar Zile: {numarZile}\n" +
                   $"Data Sosire: {dataSosire}\n" +
                   $"Data Plecare: {dataPlecare}\n";
        }

        private void salveazaButton_Click(object sender, System.EventArgs e)
        {
            string destinatie = destinatiiComboBox.SelectedItem.ToString();
            int numarZile = int.Parse(zileBox.Text);
            DateTime dataSosire = dateTimePickerSosire.Value;
            DateTime dataPlecare = dateTimePickerPlecare.Value;

            rezervari rezervare = new rezervari(destinatie, numarZile, dataSosire, dataPlecare);
            this.Hide();
            Form4 form4 = new Form4();
            form4.AfiseazaInformatii(GetInformations());
            form4.ShowDialog();
        }
    }
}
