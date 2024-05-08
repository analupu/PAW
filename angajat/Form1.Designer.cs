namespace angajat
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.oreLabel = new System.Windows.Forms.Label();
            this.salariuLabel = new System.Windows.Forms.Label();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.oreTextBox = new System.Windows.Forms.TextBox();
            this.salariuTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.totiButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medieButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(36, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nume";
            // 
            // oreLabel
            // 
            this.oreLabel.AutoSize = true;
            this.oreLabel.Location = new System.Drawing.Point(36, 105);
            this.oreLabel.Name = "oreLabel";
            this.oreLabel.Size = new System.Drawing.Size(142, 16);
            this.oreLabel.TabIndex = 1;
            this.oreLabel.Text = "Numarul de ore lucrate";
            // 
            // salariuLabel
            // 
            this.salariuLabel.AutoSize = true;
            this.salariuLabel.Location = new System.Drawing.Point(36, 158);
            this.salariuLabel.Name = "salariuLabel";
            this.salariuLabel.Size = new System.Drawing.Size(79, 16);
            this.salariuLabel.TabIndex = 2;
            this.salariuLabel.Text = "Salariul orar";
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(195, 54);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(269, 22);
            this.numeTextBox.TabIndex = 3;
            // 
            // oreTextBox
            // 
            this.oreTextBox.Location = new System.Drawing.Point(195, 99);
            this.oreTextBox.Name = "oreTextBox";
            this.oreTextBox.Size = new System.Drawing.Size(269, 22);
            this.oreTextBox.TabIndex = 4;
            // 
            // salariuTextBox
            // 
            this.salariuTextBox.Location = new System.Drawing.Point(195, 152);
            this.salariuTextBox.Name = "salariuTextBox";
            this.salariuTextBox.Size = new System.Drawing.Size(269, 22);
            this.salariuTextBox.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(39, 195);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(425, 150);
            this.dataGridView.TabIndex = 6;
            // 
            // adaugaButton
            // 
            this.adaugaButton.Location = new System.Drawing.Point(489, 228);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(127, 56);
            this.adaugaButton.TabIndex = 7;
            this.adaugaButton.Text = "Adauga un angajat";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // totiButton
            // 
            this.totiButton.Location = new System.Drawing.Point(489, 309);
            this.totiButton.Name = "totiButton";
            this.totiButton.Size = new System.Drawing.Size(127, 61);
            this.totiButton.TabIndex = 8;
            this.totiButton.Text = "Arata toti angajatii! ";
            this.totiButton.UseVisualStyleBackColor = true;
            this.totiButton.Click += new System.EventHandler(this.totiButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // medieButton
            // 
            this.medieButton.Location = new System.Drawing.Point(489, 142);
            this.medieButton.Name = "medieButton";
            this.medieButton.Size = new System.Drawing.Size(127, 67);
            this.medieButton.TabIndex = 10;
            this.medieButton.Text = "Salariu mediu";
            this.medieButton.UseVisualStyleBackColor = true;
            this.medieButton.Click += new System.EventHandler(this.medieButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(489, 54);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(127, 67);
            this.totalButton.TabIndex = 11;
            this.totalButton.Text = "Salarii totale";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.medieButton);
            this.Controls.Add(this.totiButton);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.salariuTextBox);
            this.Controls.Add(this.oreTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(this.salariuLabel);
            this.Controls.Add(this.oreLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label oreLabel;
        private System.Windows.Forms.Label salariuLabel;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox oreTextBox;
        private System.Windows.Forms.TextBox salariuTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.Button totiButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.Button medieButton;
        private System.Windows.Forms.Button totalButton;
    }
}

