namespace DinHatt_CodeFirst
{
    partial class KundForm
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
            this.tabKunder = new System.Windows.Forms.TabControl();
            this.tabKundLista = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listKunder = new System.Windows.Forms.ListView();
            this.colCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colENamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPostnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEpost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLadda = new System.Windows.Forms.Button();
            this.tabNyKund = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEpost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSpara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFnamn = new System.Windows.Forms.TextBox();
            this.txtEnamn = new System.Windows.Forms.TextBox();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.txtPostnr = new System.Windows.Forms.TextBox();
            this.tabSokKund = new System.Windows.Forms.TabPage();
            this.tabKunder.SuspendLayout();
            this.tabKundLista.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabNyKund.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabKunder
            // 
            this.tabKunder.Controls.Add(this.tabKundLista);
            this.tabKunder.Controls.Add(this.tabNyKund);
            this.tabKunder.Controls.Add(this.tabSokKund);
            this.tabKunder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabKunder.Location = new System.Drawing.Point(0, 0);
            this.tabKunder.Name = "tabKunder";
            this.tabKunder.SelectedIndex = 0;
            this.tabKunder.Size = new System.Drawing.Size(633, 361);
            this.tabKunder.TabIndex = 0;
            this.tabKunder.SelectedIndexChanged += new System.EventHandler(this.tabKunder_SelectedIndexChanged);
            // 
            // tabKundLista
            // 
            this.tabKundLista.Controls.Add(this.groupBox3);
            this.tabKundLista.Controls.Add(this.groupBox2);
            this.tabKundLista.Location = new System.Drawing.Point(4, 22);
            this.tabKundLista.Name = "tabKundLista";
            this.tabKundLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabKundLista.Size = new System.Drawing.Size(625, 335);
            this.tabKundLista.TabIndex = 0;
            this.tabKundLista.Text = "Kunder";
            this.tabKundLista.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listKunder);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(619, 278);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kunder";
            // 
            // listKunder
            // 
            this.listKunder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCheck,
            this.colId,
            this.colFNamn,
            this.colENamn,
            this.colAdress,
            this.colPostnr,
            this.colOrt,
            this.colLand,
            this.colTele,
            this.colEpost});
            this.listKunder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKunder.FullRowSelect = true;
            this.listKunder.GridLines = true;
            this.listKunder.HideSelection = false;
            this.listKunder.Location = new System.Drawing.Point(3, 16);
            this.listKunder.MultiSelect = false;
            this.listKunder.Name = "listKunder";
            this.listKunder.Size = new System.Drawing.Size(613, 259);
            this.listKunder.TabIndex = 0;
            this.listKunder.UseCompatibleStateImageBehavior = false;
            this.listKunder.View = System.Windows.Forms.View.Details;
            // 
            // colCheck
            // 
            this.colCheck.Text = "";
            this.colCheck.Width = 5;
            // 
            // colId
            // 
            this.colId.Text = "KundNr";
            // 
            // colFNamn
            // 
            this.colFNamn.Text = "Förnamn";
            // 
            // colENamn
            // 
            this.colENamn.Text = "Efternamn";
            // 
            // colAdress
            // 
            this.colAdress.Text = "Adress";
            // 
            // colPostnr
            // 
            this.colPostnr.Text = "Postnummer";
            // 
            // colOrt
            // 
            this.colOrt.Text = "Ort";
            // 
            // colLand
            // 
            this.colLand.Text = "Land";
            // 
            // colTele
            // 
            this.colTele.Text = "Telefonnummer";
            // 
            // colEpost
            // 
            this.colEpost.Text = "ePost";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLadda);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kundkontroll";
            // 
            // btnLadda
            // 
            this.btnLadda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnLadda.Location = new System.Drawing.Point(7, 19);
            this.btnLadda.Name = "btnLadda";
            this.btnLadda.Size = new System.Drawing.Size(89, 23);
            this.btnLadda.TabIndex = 1;
            this.btnLadda.Text = "Ladda Kunder";
            this.btnLadda.UseVisualStyleBackColor = true;
            this.btnLadda.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabNyKund
            // 
            this.tabNyKund.Controls.Add(this.groupBox1);
            this.tabNyKund.Location = new System.Drawing.Point(4, 22);
            this.tabNyKund.Name = "tabNyKund";
            this.tabNyKund.Padding = new System.Windows.Forms.Padding(3);
            this.tabNyKund.Size = new System.Drawing.Size(756, 335);
            this.tabNyKund.TabIndex = 1;
            this.tabNyKund.Text = "Ny Kund";
            this.tabNyKund.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLand);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEpost);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSpara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFnamn);
            this.groupBox1.Controls.Add(this.txtEnamn);
            this.groupBox1.Controls.Add(this.txtTele);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.txtOrt);
            this.groupBox1.Controls.Add(this.txtPostnr);
            this.groupBox1.Location = new System.Drawing.Point(25, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 286);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ny Kund";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Land";
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(86, 162);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(100, 20);
            this.txtLand.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ePost";
            // 
            // txtEpost
            // 
            this.txtEpost.Location = new System.Drawing.Point(86, 219);
            this.txtEpost.Name = "txtEpost";
            this.txtEpost.Size = new System.Drawing.Size(100, 20);
            this.txtEpost.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Postnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gatuadress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Efternamn";
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(86, 245);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(100, 23);
            this.btnSpara.TabIndex = 8;
            this.btnSpara.Text = "Spara kund";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Förnamn";
            // 
            // txtFnamn
            // 
            this.txtFnamn.Location = new System.Drawing.Point(86, 32);
            this.txtFnamn.Name = "txtFnamn";
            this.txtFnamn.Size = new System.Drawing.Size(100, 20);
            this.txtFnamn.TabIndex = 0;
            // 
            // txtEnamn
            // 
            this.txtEnamn.Location = new System.Drawing.Point(86, 58);
            this.txtEnamn.Name = "txtEnamn";
            this.txtEnamn.Size = new System.Drawing.Size(100, 20);
            this.txtEnamn.TabIndex = 1;
            // 
            // txtTele
            // 
            this.txtTele.Location = new System.Drawing.Point(86, 193);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(100, 20);
            this.txtTele.TabIndex = 6;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(86, 84);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(100, 20);
            this.txtAdress.TabIndex = 2;
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(86, 136);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(100, 20);
            this.txtOrt.TabIndex = 4;
            // 
            // txtPostnr
            // 
            this.txtPostnr.Location = new System.Drawing.Point(86, 110);
            this.txtPostnr.Name = "txtPostnr";
            this.txtPostnr.Size = new System.Drawing.Size(100, 20);
            this.txtPostnr.TabIndex = 3;
            // 
            // tabSokKund
            // 
            this.tabSokKund.Location = new System.Drawing.Point(4, 22);
            this.tabSokKund.Margin = new System.Windows.Forms.Padding(2);
            this.tabSokKund.Name = "tabSokKund";
            this.tabSokKund.Padding = new System.Windows.Forms.Padding(2);
            this.tabSokKund.Size = new System.Drawing.Size(756, 335);
            this.tabSokKund.TabIndex = 2;
            this.tabSokKund.Text = "Sök Kund";
            this.tabSokKund.UseVisualStyleBackColor = true;
            // 
            // KundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 361);
            this.Controls.Add(this.tabKunder);
            this.Name = "KundForm";
            this.Text = "Kunder";
            this.tabKunder.ResumeLayout(false);
            this.tabKundLista.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabNyKund.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabKunder;
        private System.Windows.Forms.TabPage tabKundLista;
        private System.Windows.Forms.TabPage tabNyKund;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.TextBox txtPostnr;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtEnamn;
        private System.Windows.Forms.TextBox txtFnamn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listKunder;
        private System.Windows.Forms.ColumnHeader colFNamn;
        private System.Windows.Forms.ColumnHeader colENamn;
        private System.Windows.Forms.ColumnHeader colAdress;
        private System.Windows.Forms.ColumnHeader colPostnr;
        private System.Windows.Forms.ColumnHeader colOrt;
        private System.Windows.Forms.ColumnHeader colTele;
        private System.Windows.Forms.Button btnLadda;
        private System.Windows.Forms.ColumnHeader colEpost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEpost;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.ColumnHeader colLand;
        private System.Windows.Forms.TabPage tabSokKund;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}