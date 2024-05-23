using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Rezervari_Hotel
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\turisti.accdb";
        private const string FilePath = "turisti.txt";
        private List<turisti> turisti;
        public Form1()
        {
            InitializeComponent();
            turisti = new List<turisti>();
            SetTransparentBackground();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.KeyDown += new KeyEventHandler(TextBox_KeyDown);
                }
            }

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SetTransparentBackground()
        {
            // Calea către imaginea de pe desktop
            //string imagePath = @"C:\Probleme C\Rezervari Hotel\bin\debug\lup.png";
            string imagePath = Path.Combine(Application.StartupPath, "lup.png");
            Image image = Image.FromFile(imagePath);

            float transparency = 0.5f; // 50% transparență

            // Creează ColorMatrix și setează matricea de transparență
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = transparency;

            // Creează ImageAttributes și setează ColorMatrix
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            // Creează o imagine compusă din fundalul implicit (alb) și imaginea de fundal dorită
            Bitmap composedImage = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(composedImage))
            {
                // Desenează fundalul implicit (alb) în partea stângă a formularului
                g.Clear(Color.White);

                // Desenează imaginea de fundal în partea dreaptă a formularului cu transparența setată
                g.DrawImage(image, new Rectangle(this.Width / 2, 0, this.Width / 2, this.Height),
                    0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            // Setează imaginea compusă ca fundal pentru formular
            this.BackgroundImage = composedImage;

            // Setează modul de afișare a imaginii de fundal
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turisti turist = new turisti
            {
                nume = numeTextBox.Text,
                prenume = prenumeTextBox.Text,
                varsta = int.Parse(varstaTextBox.Text),
                domiciliu = domiciliuTextBox.Text
            };

            turisti.Add(turist);
            SaveDataToFile(turist);
            SaveDataToDatabase(turist);

            Form2 form2 = new Form2(turisti);
            form2.ShowDialog();
        }

        private void SaveDataToFile(turisti turist)
        {
            using (StreamWriter sw = File.AppendText(FilePath))
            {
                sw.WriteLine($"{turist.Nume},{turist.Prenume},{turist.Varsta},{turist.Domiciliu}");
            }
        }

        private void SaveDataToDatabase(turisti turist)
        {
            using (var connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                var command = new OleDbCommand("INSERT INTO TURISTI (Nume, Prenume, Varsta, Domiciliu) VALUES (@Nume, @Prenume, @Varsta, @Domiciliu)", connection);
                command.Parameters.AddWithValue("@Nume", turist.Nume);
                command.Parameters.AddWithValue("@Prenume", turist.Prenume);
                command.Parameters.AddWithValue("@Varsta", turist.Varsta);
                command.Parameters.AddWithValue("@Domiciliu", turist.Domiciliu);

                command.ExecuteNonQuery();
            }
        }

        private void rezervareButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void statisticaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
