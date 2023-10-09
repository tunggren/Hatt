namespace DinHatt_CodeFirst.KundMeny
{
    partial class VisaKundTabUserControl
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
            this.txtKundID = new System.Windows.Forms.TextBox();
            this.btnSok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEpost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAndra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFnamn = new System.Windows.Forms.TextBox();
            this.txtEnamn = new System.Windows.Forms.TextBox();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.txtPostnr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKundID
            // 
            this.txtKundID.Location = new System.Drawing.Point(13, 44);
            this.txtKundID.Name = "txtKundID";
            this.txtKundID.Size = new System.Drawing.Size(121, 20);
            this.txtKundID.TabIndex = 2;
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(13, 90);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(121, 23);
            this.btnSok.TabIndex = 3;
            this.btnSok.Text = "Sök Kund";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.btnSok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaBort);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLand);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEpost);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAndra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFnamn);
            this.groupBox1.Controls.Add(this.txtEnamn);
            this.groupBox1.Controls.Add(this.txtTele);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.txtOrt);
            this.groupBox1.Controls.Add(this.txtPostnr);
            this.groupBox1.Location = new System.Drawing.Point(156, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 306);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kundinformation";
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(86, 274);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(100, 23);
            this.btnTaBort.TabIndex = 17;
            this.btnTaBort.Text = "Ta bort kund";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 168);
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
            this.label7.Location = new System.Drawing.Point(34, 219);
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
            this.label6.Location = new System.Drawing.Point(25, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Postnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gatuadress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Efternamn";
            // 
            // btnAndra
            // 
            this.btnAndra.Location = new System.Drawing.Point(86, 245);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(100, 23);
            this.btnAndra.TabIndex = 8;
            this.btnAndra.Text = "Ändra kund";
            this.btnAndra.UseVisualStyleBackColor = true;
            this.btnAndra.Click += new System.EventHandler(this.btnAndra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
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
            this.txtFnamn.TextChanged += new System.EventHandler(this.txtFnamn_TextChanged);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ange kundnummer";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // VisaKundTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSok);
            this.Controls.Add(this.txtKundID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VisaKundTabUserControl";
            this.Size = new System.Drawing.Size(683, 437);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKundID;
        private System.Windows.Forms.Button btnSok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEpost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAndra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFnamn;
        private System.Windows.Forms.TextBox txtEnamn;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.TextBox txtPostnr;
        private System.Windows.Forms.Label label9;
    }
}
