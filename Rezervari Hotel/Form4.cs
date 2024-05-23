using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervari_Hotel
{
    public partial class Form4 : Form
    {
        private Panel colorPanel;
        public Form4()
        {
            InitializeComponent();
            InitializeTrackBar();
            InitializeColorPanel();
        }

        private void InitializeTrackBar()
        {
            TrackBar trackBar = new TrackBar
            {
                Minimum = 0,
                Maximum = 100,
                TickFrequency = 10,
                LargeChange = 10,
                SmallChange = 1,
                Width = 400,
                Location = new Point((this.ClientSize.Width - 400) / 2, 50),
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            Label label = new Label
            {
                Text = "Nivelul de satisfacție: 0%",
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 400,
                Location = new Point((this.ClientSize.Width - 400) / 2, 20),
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            trackBar.Scroll += (sender, e) =>
            {
                int value = trackBar.Value;
                label.Text = $"Nivelul de satisfacție: {value}%";
                colorPanel.BackColor = GetColorFromValue(value);
            };

            this.Controls.Add(trackBar);
            this.Controls.Add(label);
        }

        private void InitializeColorPanel()
        {
            colorPanel = new Panel
            {
                Size = new Size(400, 200),
                Location = new Point((this.ClientSize.Width - 400) / 2, 150),
                BackColor = GetColorFromValue(0),
                BorderStyle = BorderStyle.FixedSingle
            };

            this.Controls.Add(colorPanel);

            this.Resize += (sender, e) =>
            {
                colorPanel.Location = new Point((this.ClientSize.Width - colorPanel.Width) / 2, 150);
            };
        }

        private Color GetColorFromValue(int value)
        {
            int red = (int)(255 - (value * 2.55));
            int green = (int)(value * 2.55);
            int blue = 0; // Set blue to 0 for a fully green rectangle
            return Color.FromArgb(red, green, blue);
        }

        public void AfiseazaInformatii(string informatii)
        {
            richTextBox1.Text = informatii;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

