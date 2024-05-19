namespace Rezervari_Hotel
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewRerervari = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nUMARTURISTIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iESIREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aFISEAZATURISTIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRerervari)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRerervari
            // 
            this.dataGridViewRerervari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRerervari.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewRerervari.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewRerervari.Name = "dataGridViewRerervari";
            this.dataGridViewRerervari.RowHeadersWidth = 51;
            this.dataGridViewRerervari.RowTemplate.Height = 24;
            this.dataGridViewRerervari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRerervari.Size = new System.Drawing.Size(800, 150);
            this.dataGridViewRerervari.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUMARTURISTIToolStripMenuItem,
            this.iESIREToolStripMenuItem,
            this.aFISEAZATURISTIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nUMARTURISTIToolStripMenuItem
            // 
            this.nUMARTURISTIToolStripMenuItem.Name = "nUMARTURISTIToolStripMenuItem";
            this.nUMARTURISTIToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.nUMARTURISTIToolStripMenuItem.Text = "NUMAR TURISTI";
            this.nUMARTURISTIToolStripMenuItem.Click += new System.EventHandler(this.NUMARTURISTIToolStripMenuItem_Click);
            // 
            // iESIREToolStripMenuItem
            // 
            this.iESIREToolStripMenuItem.Name = "iESIREToolStripMenuItem";
            this.iESIREToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.iESIREToolStripMenuItem.Text = "IESIRE";
            this.iESIREToolStripMenuItem.Click += new System.EventHandler(this.iESIREToolStripMenuItem_Click);
            // 
            // aFISEAZATURISTIToolStripMenuItem
            // 
            this.aFISEAZATURISTIToolStripMenuItem.Name = "aFISEAZATURISTIToolStripMenuItem";
            this.aFISEAZATURISTIToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.aFISEAZATURISTIToolStripMenuItem.Text = "AFISEAZA TURISTI ";
            this.aFISEAZATURISTIToolStripMenuItem.Click += new System.EventHandler(this.AFISEAZATURISTIToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRerervari);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRerervari)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // aici
        private System.Windows.Forms.DataGridView dataGridViewRerervari;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nUMARTURISTIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iESIREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aFISEAZATURISTIToolStripMenuItem;
    }
}