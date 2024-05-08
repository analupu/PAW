namespace Masina
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Pret = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mODELToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pRETToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCAToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mODELToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pRETToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 108);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(653, 216);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pret";
            // 
            // Marca
            // 
            this.Marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Marca.Location = new System.Drawing.Point(12, 80);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(100, 22);
            this.Marca.TabIndex = 4;
            // 
            // Model
            // 
            this.Model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Model.Location = new System.Drawing.Point(173, 80);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(100, 22);
            this.Model.TabIndex = 5;
            // 
            // Pret
            // 
            this.Pret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Pret.Location = new System.Drawing.Point(339, 80);
            this.Pret.Name = "Pret";
            this.Pret.Size = new System.Drawing.Size(100, 22);
            this.Pret.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mARCAToolStripMenuItem,
            this.mODELToolStripMenuItem,
            this.pRETToolStripMenuItem});
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mARCAToolStripMenuItem1,
            this.mODELToolStripMenuItem1,
            this.pRETToolStripMenuItem1});
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.modificaToolStripMenuItem.Text = "Modifica";
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mARCAToolStripMenuItem2,
            this.mODELToolStripMenuItem2,
            this.pRETToolStripMenuItem2});
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.stergeToolStripMenuItem.Text = "Sterge";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // mARCAToolStripMenuItem
            // 
            this.mARCAToolStripMenuItem.Name = "mARCAToolStripMenuItem";
            this.mARCAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mARCAToolStripMenuItem.Text = "MARCA";
            // 
            // mODELToolStripMenuItem
            // 
            this.mODELToolStripMenuItem.Name = "mODELToolStripMenuItem";
            this.mODELToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mODELToolStripMenuItem.Text = "MODEL";
            // 
            // pRETToolStripMenuItem
            // 
            this.pRETToolStripMenuItem.Name = "pRETToolStripMenuItem";
            this.pRETToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pRETToolStripMenuItem.Text = "PRET";
            // 
            // mARCAToolStripMenuItem1
            // 
            this.mARCAToolStripMenuItem1.Name = "mARCAToolStripMenuItem1";
            this.mARCAToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.mARCAToolStripMenuItem1.Text = "MARCA";
            // 
            // mODELToolStripMenuItem1
            // 
            this.mODELToolStripMenuItem1.Name = "mODELToolStripMenuItem1";
            this.mODELToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.mODELToolStripMenuItem1.Text = "MODEL";
            // 
            // pRETToolStripMenuItem1
            // 
            this.pRETToolStripMenuItem1.Name = "pRETToolStripMenuItem1";
            this.pRETToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.pRETToolStripMenuItem1.Text = "PRET";
            // 
            // mARCAToolStripMenuItem2
            // 
            this.mARCAToolStripMenuItem2.Name = "mARCAToolStripMenuItem2";
            this.mARCAToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.mARCAToolStripMenuItem2.Text = "MARCA";
            // 
            // mODELToolStripMenuItem2
            // 
            this.mODELToolStripMenuItem2.Name = "mODELToolStripMenuItem2";
            this.mODELToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.mODELToolStripMenuItem2.Text = "MODEL";
            // 
            // pRETToolStripMenuItem2
            // 
            this.pRETToolStripMenuItem2.Name = "pRETToolStripMenuItem2";
            this.pRETToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.pRETToolStripMenuItem2.Text = "PRET";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(488, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adauga o masina!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pret);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FormularMasini";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Marca;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Pret;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARCAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARCAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mODELToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pRETToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARCAToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mODELToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pRETToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

