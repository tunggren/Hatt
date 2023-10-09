namespace DinHatt_CodeFirst
{
    partial class Artikelform
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
            this.tabArtikel = new System.Windows.Forms.TabControl();
            this.tabAllaArtiklar = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listArtikel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArtikelNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArtikelID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBeskrivning = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStorlek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBildNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAntalILager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBegagnad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVisaArtiklar = new System.Windows.Forms.Button();
            this.tabNyArtikel = new System.Windows.Forms.TabPage();
            this.tabVisaArtikel = new System.Windows.Forms.TabPage();
            this.tabArtikel.SuspendLayout();
            this.tabAllaArtiklar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabArtikel
            // 
            this.tabArtikel.Controls.Add(this.tabAllaArtiklar);
            this.tabArtikel.Controls.Add(this.tabNyArtikel);
            this.tabArtikel.Controls.Add(this.tabVisaArtikel);
            this.tabArtikel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabArtikel.Location = new System.Drawing.Point(0, 0);
            this.tabArtikel.Name = "tabArtikel";
            this.tabArtikel.SelectedIndex = 0;
            this.tabArtikel.Size = new System.Drawing.Size(860, 481);
            this.tabArtikel.TabIndex = 0;
            this.tabArtikel.SelectedIndexChanged += new System.EventHandler(this.tabArtikel_SelectedIndexChanged);
            // 
            // tabAllaArtiklar
            // 
            this.tabAllaArtiklar.Controls.Add(this.groupBox2);
            this.tabAllaArtiklar.Controls.Add(this.groupBox1);
            this.tabAllaArtiklar.Location = new System.Drawing.Point(4, 22);
            this.tabAllaArtiklar.Name = "tabAllaArtiklar";
            this.tabAllaArtiklar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllaArtiklar.Size = new System.Drawing.Size(852, 455);
            this.tabAllaArtiklar.TabIndex = 0;
            this.tabAllaArtiklar.Text = "Alla Artiklar";
            this.tabAllaArtiklar.UseVisualStyleBackColor = true;
            this.tabAllaArtiklar.Click += new System.EventHandler(this.tabNyArtikel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listArtikel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 397);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artikellista";
            // 
            // listArtikel
            // 
            this.listArtikel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colArtikelNamn,
            this.colArtikelID,
            this.colBeskrivning,
            this.colStorlek,
            this.colPris,
            this.colBildNamn,
            this.colAntalILager,
            this.colBegagnad,
            this.colMoms});
            this.listArtikel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listArtikel.FullRowSelect = true;
            this.listArtikel.GridLines = true;
            this.listArtikel.HideSelection = false;
            this.listArtikel.Location = new System.Drawing.Point(3, 16);
            this.listArtikel.Margin = new System.Windows.Forms.Padding(2);
            this.listArtikel.Name = "listArtikel";
            this.listArtikel.Size = new System.Drawing.Size(840, 378);
            this.listArtikel.TabIndex = 0;
            this.listArtikel.UseCompatibleStateImageBehavior = false;
            this.listArtikel.View = System.Windows.Forms.View.Details;
            this.listArtikel.SelectedIndexChanged += new System.EventHandler(this.listArtikel_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " ";
            this.columnHeader1.Width = 0;
            // 
            // colArtikelNamn
            // 
            this.colArtikelNamn.Text = "Artikelnamn";
            this.colArtikelNamn.Width = 100;
            // 
            // colArtikelID
            // 
            this.colArtikelID.Text = "ArtikelID";
            this.colArtikelID.Width = 91;
            // 
            // colBeskrivning
            // 
            this.colBeskrivning.Text = "Beskrivning";
            this.colBeskrivning.Width = 97;
            // 
            // colStorlek
            // 
            this.colStorlek.Text = "Storlek";
            this.colStorlek.Width = 72;
            // 
            // colPris
            // 
            this.colPris.Text = "Pris";
            this.colPris.Width = 67;
            // 
            // colBildNamn
            // 
            this.colBildNamn.Text = "Bildnamn";
            this.colBildNamn.Width = 99;
            // 
            // colAntalILager
            // 
            this.colAntalILager.Text = "Antal i Lager";
            this.colAntalILager.Width = 110;
            // 
            // colBegagnad
            // 
            this.colBegagnad.Text = "Begagnad";
            this.colBegagnad.Width = 112;
            // 
            // colMoms
            // 
            this.colMoms.Text = "Moms %";
            this.colMoms.Width = 79;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVisaArtiklar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artikelkontroll";
            // 
            // btnVisaArtiklar
            // 
            this.btnVisaArtiklar.Location = new System.Drawing.Point(5, 18);
            this.btnVisaArtiklar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisaArtiklar.Name = "btnVisaArtiklar";
            this.btnVisaArtiklar.Size = new System.Drawing.Size(97, 25);
            this.btnVisaArtiklar.TabIndex = 1;
            this.btnVisaArtiklar.Text = "Visa Artiklar";
            this.btnVisaArtiklar.UseVisualStyleBackColor = true;
            this.btnVisaArtiklar.Click += new System.EventHandler(this.btnVisaArtiklar_Click);
            // 
            // tabNyArtikel
            // 
            this.tabNyArtikel.Location = new System.Drawing.Point(4, 22);
            this.tabNyArtikel.Name = "tabNyArtikel";
            this.tabNyArtikel.Padding = new System.Windows.Forms.Padding(3);
            this.tabNyArtikel.Size = new System.Drawing.Size(901, 497);
            this.tabNyArtikel.TabIndex = 1;
            this.tabNyArtikel.Text = "Ny Artikel";
            this.tabNyArtikel.UseVisualStyleBackColor = true;
            // 
            // tabVisaArtikel
            // 
            this.tabVisaArtikel.Location = new System.Drawing.Point(4, 22);
            this.tabVisaArtikel.Name = "tabVisaArtikel";
            this.tabVisaArtikel.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisaArtikel.Size = new System.Drawing.Size(901, 497);
            this.tabVisaArtikel.TabIndex = 2;
            this.tabVisaArtikel.Text = "Visa Artikel";
            this.tabVisaArtikel.UseVisualStyleBackColor = true;
            // 
            // Artikelform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(860, 481);
            this.Controls.Add(this.tabArtikel);
            this.Name = "Artikelform";
            this.ShowIcon = false;
            this.Text = "Artiklar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Artikelform_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Artikelform_FormClosed);
            this.Load += new System.EventHandler(this.Artikelform_Load);
            this.tabArtikel.ResumeLayout(false);
            this.tabAllaArtiklar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabArtikel;
        private System.Windows.Forms.TabPage tabAllaArtiklar;
        private System.Windows.Forms.TabPage tabNyArtikel;
        private System.Windows.Forms.ListView listArtikel;
        private System.Windows.Forms.Button btnVisaArtiklar;
        private System.Windows.Forms.ColumnHeader colArtikelNamn;
        private System.Windows.Forms.ColumnHeader colArtikelID;
        private System.Windows.Forms.ColumnHeader colBeskrivning;
        private System.Windows.Forms.ColumnHeader colStorlek;
        private System.Windows.Forms.ColumnHeader colPris;
        private System.Windows.Forms.TabPage tabVisaArtikel;
        private System.Windows.Forms.ColumnHeader colBildNamn;
        private System.Windows.Forms.ColumnHeader colAntalILager;
        private System.Windows.Forms.ColumnHeader colBegagnad;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colMoms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}