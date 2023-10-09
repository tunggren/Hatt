namespace DinHatt_CodeFirst.ArtikelMeny
{
    partial class NyArtikelTabUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtArtikelNamn = new System.Windows.Forms.TextBox();
            this.btnSparaNyArtikel = new System.Windows.Forms.Button();
            this.artikelNamn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBeskrivning = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPris = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAntalILager = new System.Windows.Forms.TextBox();
            this.chkBegagnad = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLaddaInBild = new System.Windows.Forms.Button();
            this.txtBildNamn = new System.Windows.Forms.TextBox();
            this.picboxArtikel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxArtikel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArtikelNamn
            // 
            this.txtArtikelNamn.Location = new System.Drawing.Point(141, 28);
            this.txtArtikelNamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArtikelNamn.Name = "txtArtikelNamn";
            this.txtArtikelNamn.Size = new System.Drawing.Size(320, 22);
            this.txtArtikelNamn.TabIndex = 0;
            // 
            // btnSparaNyArtikel
            // 
            this.btnSparaNyArtikel.Location = new System.Drawing.Point(261, 332);
            this.btnSparaNyArtikel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSparaNyArtikel.Name = "btnSparaNyArtikel";
            this.btnSparaNyArtikel.Size = new System.Drawing.Size(201, 28);
            this.btnSparaNyArtikel.TabIndex = 6;
            this.btnSparaNyArtikel.Text = "Spara ny artikel";
            this.btnSparaNyArtikel.UseVisualStyleBackColor = true;
            this.btnSparaNyArtikel.Click += new System.EventHandler(this.btnSparaNyArtikel_Click);
            // 
            // artikelNamn
            // 
            this.artikelNamn.AutoSize = true;
            this.artikelNamn.Location = new System.Drawing.Point(64, 37);
            this.artikelNamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artikelNamn.Name = "artikelNamn";
            this.artikelNamn.Size = new System.Drawing.Size(43, 16);
            this.artikelNamn.TabIndex = 2;
            this.artikelNamn.Text = "Namn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Beskrivning";
            // 
            // txtBeskrivning
            // 
            this.txtBeskrivning.Location = new System.Drawing.Point(141, 60);
            this.txtBeskrivning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBeskrivning.Multiline = true;
            this.txtBeskrivning.Name = "txtBeskrivning";
            this.txtBeskrivning.Size = new System.Drawing.Size(320, 125);
            this.txtBeskrivning.TabIndex = 1;
            this.txtBeskrivning.TextChanged += new System.EventHandler(this.txtBeskrivning_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pris";
            // 
            // txtPris
            // 
            this.txtPris.Location = new System.Drawing.Point(141, 193);
            this.txtPris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPris.Name = "txtPris";
            this.txtPris.Size = new System.Drawing.Size(320, 22);
            this.txtPris.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Antal i lager";
            // 
            // txtAntalILager
            // 
            this.txtAntalILager.Location = new System.Drawing.Point(141, 225);
            this.txtAntalILager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAntalILager.Name = "txtAntalILager";
            this.txtAntalILager.Size = new System.Drawing.Size(320, 22);
            this.txtAntalILager.TabIndex = 3;
            // 
            // chkBegagnad
            // 
            this.chkBegagnad.AutoSize = true;
            this.chkBegagnad.Location = new System.Drawing.Point(141, 262);
            this.chkBegagnad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBegagnad.Name = "chkBegagnad";
            this.chkBegagnad.Size = new System.Drawing.Size(44, 20);
            this.chkBegagnad.TabIndex = 4;
            this.chkBegagnad.Text = "Ja";
            this.chkBegagnad.UseVisualStyleBackColor = true;
            this.chkBegagnad.CheckedChanged += new System.EventHandler(this.chkBegagnad_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Begagnad";
            // 
            // btnLaddaInBild
            // 
            this.btnLaddaInBild.Location = new System.Drawing.Point(261, 297);
            this.btnLaddaInBild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaddaInBild.Name = "btnLaddaInBild";
            this.btnLaddaInBild.Size = new System.Drawing.Size(201, 28);
            this.btnLaddaInBild.TabIndex = 5;
            this.btnLaddaInBild.Text = "Välj bild";
            this.btnLaddaInBild.UseVisualStyleBackColor = true;
            this.btnLaddaInBild.Click += new System.EventHandler(this.btnLaddaInBild_Click);
            // 
            // txtBildNamn
            // 
            this.txtBildNamn.Location = new System.Drawing.Point(129, 300);
            this.txtBildNamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBildNamn.Name = "txtBildNamn";
            this.txtBildNamn.Size = new System.Drawing.Size(123, 22);
            this.txtBildNamn.TabIndex = 12;
            // 
            // picboxArtikel
            // 
            this.picboxArtikel.Location = new System.Drawing.Point(472, 28);
            this.picboxArtikel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxArtikel.Name = "picboxArtikel";
            this.picboxArtikel.Size = new System.Drawing.Size(275, 332);
            this.picboxArtikel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxArtikel.TabIndex = 13;
            this.picboxArtikel.TabStop = false;
            // 
            // NyArtikelTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picboxArtikel);
            this.Controls.Add(this.txtBildNamn);
            this.Controls.Add(this.btnLaddaInBild);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkBegagnad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAntalILager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBeskrivning);
            this.Controls.Add(this.artikelNamn);
            this.Controls.Add(this.btnSparaNyArtikel);
            this.Controls.Add(this.txtArtikelNamn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NyArtikelTabUserControl";
            this.Size = new System.Drawing.Size(937, 602);
            ((System.ComponentModel.ISupportInitialize)(this.picboxArtikel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtikelNamn;
        private System.Windows.Forms.Button btnSparaNyArtikel;
        private System.Windows.Forms.Label artikelNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBeskrivning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAntalILager;
        private System.Windows.Forms.CheckBox chkBegagnad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLaddaInBild;
        private System.Windows.Forms.TextBox txtBildNamn;
        private System.Windows.Forms.PictureBox picboxArtikel;
    }
}
