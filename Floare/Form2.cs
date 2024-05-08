using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floare
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comanda a fost inregistrata! ");
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Lupu";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "Ana - Maria";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "21";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "Domnesti";
        }
    }
}
