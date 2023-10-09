namespace DinHatt_CodeFirst
{
    partial class StatistikForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnVisaStatistik = new System.Windows.Forms.Button();
            this.lblBetaldaOrdrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxTotalBetal = new System.Windows.Forms.TextBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeSlut = new System.Windows.Forms.DateTimePicker();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrdNmr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSumma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxMoms = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(764, 361);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnVisaStatistik
            // 
            this.btnVisaStatistik.Location = new System.Drawing.Point(323, 92);
            this.btnVisaStatistik.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisaStatistik.Name = "btnVisaStatistik";
            this.btnVisaStatistik.Size = new System.Drawing.Size(91, 24);
            this.btnVisaStatistik.TabIndex = 1;
            this.btnVisaStatistik.Text = "Visa statistik";
            this.btnVisaStatistik.UseVisualStyleBackColor = true;
            this.btnVisaStatistik.Click += new System.EventHandler(this.btnVisaStatistik_Click);
            // 
            // lblBetaldaOrdrar
            // 
            this.lblBetaldaOrdrar.Location = new System.Drawing.Point(5, 6);
            this.lblBetaldaOrdrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBetaldaOrdrar.Name = "lblBetaldaOrdrar";
            this.lblBetaldaOrdrar.Size = new System.Drawing.Size(155, 15);
            this.lblBetaldaOrdrar.TabIndex = 3;
            this.lblBetaldaOrdrar.Text = "Betalda och levererade ordrar";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total summa";
            // 
            // txtboxTotalBetal
            // 
            this.txtboxTotalBetal.Location = new System.Drawing.Point(115, 229);
            this.txtboxTotalBetal.Multiline = true;
            this.txtboxTotalBetal.Name = "txtboxTotalBetal";
            this.txtboxTotalBetal.Size = new System.Drawing.Size(87, 16);
            this.txtboxTotalBetal.TabIndex = 5;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(424, 29);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(135, 20);
            this.dateTimeStart.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(321, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Startdatum";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(321, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Slutdatum";
            // 
            // dateTimeSlut
            // 
            this.dateTimeSlut.Location = new System.Drawing.Point(424, 58);
            this.dateTimeSlut.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeSlut.Name = "dateTimeSlut";
            this.dateTimeSlut.Size = new System.Drawing.Size(135, 20);
            this.dateTimeSlut.TabIndex = 9;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colOrdNmr,
            this.colSumma,
            this.colDatum});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(8, 29);
            this.listViewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(303, 189);
            this.listViewOrder.TabIndex = 10;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "-";
            this.columnHeader1.Width = 13;
            // 
            // colOrdNmr
            // 
            this.colOrdNmr.Text = "Ordernummer";
            this.colOrdNmr.Width = 113;
            // 
            // colSumma
            // 
            this.colSumma.Text = "Summa";
            this.colSumma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSumma.Width = 88;
            // 
            // colDatum
            // 
            this.colDatum.Text = "Datum";
            this.colDatum.Width = 72;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total moms";
            // 
            // txtboxMoms
            // 
            this.txtboxMoms.Location = new System.Drawing.Point(115, 257);
            this.txtboxMoms.Multiline = true;
            this.txtboxMoms.Name = "txtboxMoms";
            this.txtboxMoms.Size = new System.Drawing.Size(87, 16);
            this.txtboxMoms.TabIndex = 12;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(316, 195);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 23);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Exportera till fil";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // StatistikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 361);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtboxMoms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.dateTimeSlut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.txtboxTotalBetal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBetaldaOrdrar);
            this.Controls.Add(this.btnVisaStatistik);
            this.Controls.Add(this.listView1);
            this.Name = "StatistikForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "StatistikForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnVisaStatistik;
        private System.Windows.Forms.Label lblBetaldaOrdrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxTotalBetal;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeSlut;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colOrdNmr;
        private System.Windows.Forms.ColumnHeader colSumma;
        private System.Windows.Forms.ColumnHeader colDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxMoms;
        private System.Windows.Forms.Button btnExport;
    }
}