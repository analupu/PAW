namespace student
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
            this.marcaLabel = new System.Windows.Forms.Label();
            this.numeLabel = new System.Windows.Forms.Label();
            this.facultateLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.facultateTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.totiButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // marcaLabel
            // 
            this.marcaLabel.AutoSize = true;
            this.marcaLabel.Location = new System.Drawing.Point(94, 36);
            this.marcaLabel.Name = "marcaLabel";
            this.marcaLabel.Size = new System.Drawing.Size(45, 16);
            this.marcaLabel.TabIndex = 0;
            this.marcaLabel.Text = "Marca";
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.Location = new System.Drawing.Point(94, 86);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(43, 16);
            this.numeLabel.TabIndex = 1;
            this.numeLabel.Text = "Nume";
            // 
            // facultateLabel
            // 
            this.facultateLabel.AutoSize = true;
            this.facultateLabel.Location = new System.Drawing.Point(94, 134);
            this.facultateLabel.Name = "facultateLabel";
            this.facultateLabel.Size = new System.Drawing.Size(62, 16);
            this.facultateLabel.TabIndex = 2;
            this.facultateLabel.Text = "Facultate";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(94, 188);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(36, 16);
            this.noteLabel.TabIndex = 3;
            this.noteLabel.Text = "Note";
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.Location = new System.Drawing.Point(188, 30);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(283, 22);
            this.marcaTextBox.TabIndex = 4;
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(188, 80);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(283, 22);
            this.numeTextBox.TabIndex = 5;
            // 
            // facultateTextBox
            // 
            this.facultateTextBox.Location = new System.Drawing.Point(188, 134);
            this.facultateTextBox.Name = "facultateTextBox";
            this.facultateTextBox.Size = new System.Drawing.Size(283, 22);
            this.facultateTextBox.TabIndex = 6;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(188, 182);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(283, 22);
            this.noteTextBox.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(29, 244);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(556, 150);
            this.dataGridView.TabIndex = 8;
            // 
            // adaugaButton
            // 
            this.adaugaButton.Location = new System.Drawing.Point(519, 30);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(131, 44);
            this.adaugaButton.TabIndex = 9;
            this.adaugaButton.Text = "Adauga un student";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // totiButton
            // 
            this.totiButton.Location = new System.Drawing.Point(519, 86);
            this.totiButton.Name = "totiButton";
            this.totiButton.Size = new System.Drawing.Size(131, 51);
            this.totiButton.TabIndex = 10;
            this.totiButton.Text = "Afiseaza toti studentii";
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
            this.menuStrip1.TabIndex = 11;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totiButton);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.facultateTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.facultateLabel);
            this.Controls.Add(this.numeLabel);
            this.Controls.Add(this.marcaLabel);
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

        private System.Windows.Forms.Label marcaLabel;
        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.Label facultateLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox facultateTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.Button totiButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}

