namespace DinHatt_CodeFirst.LeverantorMeny
{
    partial class LeverantorForm
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
            this.grpbxLeverantorKontroll = new System.Windows.Forms.GroupBox();
            this.btnVisaLeverantorer = new System.Windows.Forms.Button();
            this.grpbxLeverantorList = new System.Windows.Forms.GroupBox();
            this.listLeverantor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForeNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForeNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForeAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForePostNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForeOrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForeLand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForeTele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForeEpost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabLeverantor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabNyLeverantor = new System.Windows.Forms.TabPage();
            this.tabVisaLeverantor = new System.Windows.Forms.TabPage();
            this.grpbxLeverantorKontroll.SuspendLayout();
            this.grpbxLeverantorList.SuspendLayout();
            this.tabLeverantor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxLeverantorKontroll
            // 
            this.grpbxLeverantorKontroll.Controls.Add(this.btnVisaLeverantorer);
            this.grpbxLeverantorKontroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbxLeverantorKontroll.Location = new System.Drawing.Point(3, 3);
            this.grpbxLeverantorKontroll.Name = "grpbxLeverantorKontroll";
            this.grpbxLeverantorKontroll.Size = new System.Drawing.Size(692, 53);
            this.grpbxLeverantorKontroll.TabIndex = 0;
            this.grpbxLeverantorKontroll.TabStop = false;
            this.grpbxLeverantorKontroll.Text = "Leverantörer";
            // 
            // btnVisaLeverantorer
            // 
            this.btnVisaLeverantorer.Location = new System.Drawing.Point(6, 19);
            this.btnVisaLeverantorer.Name = "btnVisaLeverantorer";
            this.btnVisaLeverantorer.Size = new System.Drawing.Size(125, 23);
            this.btnVisaLeverantorer.TabIndex = 0;
            this.btnVisaLeverantorer.Text = "Hämta leverantörer";
            this.btnVisaLeverantorer.UseVisualStyleBackColor = true;
            this.btnVisaLeverantorer.Click += new System.EventHandler(this.btnVisaLeverantorer_Click);
            // 
            // grpbxLeverantorList
            // 
            this.grpbxLeverantorList.Controls.Add(this.listLeverantor);
            this.grpbxLeverantorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxLeverantorList.Location = new System.Drawing.Point(3, 56);
            this.grpbxLeverantorList.Name = "grpbxLeverantorList";
            this.grpbxLeverantorList.Size = new System.Drawing.Size(692, 330);
            this.grpbxLeverantorList.TabIndex = 1;
            this.grpbxLeverantorList.TabStop = false;
            this.grpbxLeverantorList.Text = "Lista på leverantörer";
            // 
            // listLeverantor
            // 
            this.listLeverantor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colForeNr,
            this.colForeNamn,
            this.colForeAdress,
            this.colForePostNr,
            this.colForeOrt,
            this.colForeLand,
            this.colForeTele,
            this.colForeEpost});
            this.listLeverantor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLeverantor.FullRowSelect = true;
            this.listLeverantor.GridLines = true;
            this.listLeverantor.HideSelection = false;
            this.listLeverantor.Location = new System.Drawing.Point(3, 16);
            this.listLeverantor.Name = "listLeverantor";
            this.listLeverantor.Size = new System.Drawing.Size(686, 311);
            this.listLeverantor.TabIndex = 0;
            this.listLeverantor.UseCompatibleStateImageBehavior = false;
            this.listLeverantor.View = System.Windows.Forms.View.Details;
            this.listLeverantor.SelectedIndexChanged += new System.EventHandler(this.listLeverantor_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // colForeNr
            // 
            this.colForeNr.Text = "Företagsnummer";
            this.colForeNr.Width = 93;
            // 
            // colForeNamn
            // 
            this.colForeNamn.Text = "Företag";
            this.colForeNamn.Width = 57;
            // 
            // colForeAdress
            // 
            this.colForeAdress.Text = "Adress";
            this.colForeAdress.Width = 48;
            // 
            // colForePostNr
            // 
            this.colForePostNr.Text = "Postnummer";
            this.colForePostNr.Width = 76;
            // 
            // colForeOrt
            // 
            this.colForeOrt.Text = "Ort";
            this.colForeOrt.Width = 37;
            // 
            // colForeLand
            // 
            this.colForeLand.Text = "Land";
            this.colForeLand.Width = 45;
            // 
            // colForeTele
            // 
            this.colForeTele.Text = "Telefonnummer";
            this.colForeTele.Width = 92;
            // 
            // colForeEpost
            // 
            this.colForeEpost.Text = "ePost";
            this.colForeEpost.Width = 48;
            // 
            // tabLeverantor
            // 
            this.tabLeverantor.AccessibleName = "";
            this.tabLeverantor.Controls.Add(this.tabPage1);
            this.tabLeverantor.Controls.Add(this.tabNyLeverantor);
            this.tabLeverantor.Controls.Add(this.tabVisaLeverantor);
            this.tabLeverantor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLeverantor.Location = new System.Drawing.Point(0, 0);
            this.tabLeverantor.Name = "tabLeverantor";
            this.tabLeverantor.SelectedIndex = 0;
            this.tabLeverantor.Size = new System.Drawing.Size(706, 415);
            this.tabLeverantor.TabIndex = 0;
            this.tabLeverantor.Tag = "";
            this.tabLeverantor.SelectedIndexChanged += new System.EventHandler(this.tabLeverantor_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpbxLeverantorList);
            this.tabPage1.Controls.Add(this.grpbxLeverantorKontroll);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(698, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Leverantör";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabNyLeverantor
            // 
            this.tabNyLeverantor.Location = new System.Drawing.Point(4, 22);
            this.tabNyLeverantor.Name = "tabNyLeverantor";
            this.tabNyLeverantor.Padding = new System.Windows.Forms.Padding(3);
            this.tabNyLeverantor.Size = new System.Drawing.Size(792, 424);
            this.tabNyLeverantor.TabIndex = 1;
            this.tabNyLeverantor.Text = "Ny Leverantör";
            this.tabNyLeverantor.UseVisualStyleBackColor = true;
            // 
            // tabVisaLeverantor
            // 
            this.tabVisaLeverantor.Location = new System.Drawing.Point(4, 22);
            this.tabVisaLeverantor.Name = "tabVisaLeverantor";
            this.tabVisaLeverantor.Size = new System.Drawing.Size(792, 424);
            this.tabVisaLeverantor.TabIndex = 2;
            this.tabVisaLeverantor.Text = "Visa Leverantör";
            this.tabVisaLeverantor.UseVisualStyleBackColor = true;
            // 
            // LeverantorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 415);
            this.Controls.Add(this.tabLeverantor);
            this.Name = "LeverantorForm";
            this.Text = "LeverantorForm";
            this.grpbxLeverantorKontroll.ResumeLayout(false);
            this.grpbxLeverantorList.ResumeLayout(false);
            this.tabLeverantor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLeverantorKontroll;
        private System.Windows.Forms.GroupBox grpbxLeverantorList;
        private System.Windows.Forms.Button btnVisaLeverantorer;
        private System.Windows.Forms.TabControl tabLeverantor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabNyLeverantor;
        private System.Windows.Forms.ListView listLeverantor;
        private System.Windows.Forms.ColumnHeader colForeNr;
        private System.Windows.Forms.ColumnHeader colForeNamn;
        private System.Windows.Forms.ColumnHeader colForeAdress;
        private System.Windows.Forms.ColumnHeader colForePostNr;
        private System.Windows.Forms.ColumnHeader colForeOrt;
        private System.Windows.Forms.ColumnHeader colForeLand;
        private System.Windows.Forms.ColumnHeader colForeTele;
        private System.Windows.Forms.ColumnHeader colForeEpost;
        private System.Windows.Forms.TabPage tabVisaLeverantor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}