namespace DinHatt_CodeFirst
{
    partial class OrderForm
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
            this.tabOrder = new System.Windows.Forms.TabControl();
            this.tabAllaOrder = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKund = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrderbeställare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArtikelId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiscription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPayed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLeveransstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLadda = new System.Windows.Forms.Button();
            this.tabNyOrder = new System.Windows.Forms.TabPage();
            this.tabVisaOrder = new System.Windows.Forms.TabPage();
            this.tabOrder.SuspendLayout();
            this.tabAllaOrder.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.tabAllaOrder);
            this.tabOrder.Controls.Add(this.tabNyOrder);
            this.tabOrder.Controls.Add(this.tabVisaOrder);
            this.tabOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOrder.Location = new System.Drawing.Point(0, 0);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.SelectedIndex = 0;
            this.tabOrder.Size = new System.Drawing.Size(725, 435);
            this.tabOrder.TabIndex = 0;
            this.tabOrder.SelectedIndexChanged += new System.EventHandler(this.tabOrder_SelectedIndexChanged);
            // 
            // tabAllaOrder
            // 
            this.tabAllaOrder.Controls.Add(this.groupBox2);
            this.tabAllaOrder.Controls.Add(this.groupBox1);
            this.tabAllaOrder.Location = new System.Drawing.Point(4, 22);
            this.tabAllaOrder.Name = "tabAllaOrder";
            this.tabAllaOrder.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAllaOrder.Size = new System.Drawing.Size(717, 409);
            this.tabAllaOrder.TabIndex = 0;
            this.tabAllaOrder.Text = "Alla Order";
            this.tabAllaOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewOrder);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 345);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orderlista";
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colKund,
            this.colOrderbeställare,
            this.ArtikelId,
            this.colDiscription,
            this.colTotalPrice,
            this.colPayed,
            this.colFak,
            this.colLeveransstatus,
            this.colDatum,
            this.colMoms});
            this.listViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(3, 16);
            this.listViewOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(705, 326);
            this.listViewOrder.TabIndex = 0;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrder_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "-";
            this.columnHeader1.Width = 0;
            // 
            // colKund
            // 
            this.colKund.Text = "Kund ID";
            this.colKund.Width = 51;
            // 
            // colOrderbeställare
            // 
            this.colOrderbeställare.Text = "Beställare";
            this.colOrderbeställare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colOrderbeställare.Width = 88;
            // 
            // ArtikelId
            // 
            this.ArtikelId.Text = "ArtikelID";
            this.ArtikelId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArtikelId.Width = 68;
            // 
            // colDiscription
            // 
            this.colDiscription.Text = "Beskrivning";
            this.colDiscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDiscription.Width = 80;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Text = "Total pris";
            this.colTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTotalPrice.Width = 64;
            // 
            // colPayed
            // 
            this.colPayed.Text = "Betald";
            this.colPayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPayed.Width = 70;
            // 
            // colFak
            // 
            this.colFak.Text = "Fakturerad";
            this.colFak.Width = 80;
            // 
            // colLeveransstatus
            // 
            this.colLeveransstatus.Text = "Leveransstatus";
            this.colLeveransstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLeveransstatus.Width = 86;
            // 
            // colDatum
            // 
            this.colDatum.Text = "Datum";
            this.colDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDatum.Width = 59;
            // 
            // colMoms
            // 
            this.colMoms.Text = "Moms";
            this.colMoms.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLadda);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orderkontroll";
            // 
            // btnLadda
            // 
            this.btnLadda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnLadda.Location = new System.Drawing.Point(6, 19);
            this.btnLadda.Name = "btnLadda";
            this.btnLadda.Size = new System.Drawing.Size(70, 23);
            this.btnLadda.TabIndex = 2;
            this.btnLadda.Text = "Visa ordrar";
            this.btnLadda.UseVisualStyleBackColor = true;
            this.btnLadda.Click += new System.EventHandler(this.btnLadda_Click);
            // 
            // tabNyOrder
            // 
            this.tabNyOrder.Location = new System.Drawing.Point(4, 22);
            this.tabNyOrder.Name = "tabNyOrder";
            this.tabNyOrder.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabNyOrder.Size = new System.Drawing.Size(1260, 517);
            this.tabNyOrder.TabIndex = 1;
            this.tabNyOrder.Text = "Ny Order";
            this.tabNyOrder.UseVisualStyleBackColor = true;
            // 
            // tabVisaOrder
            // 
            this.tabVisaOrder.Location = new System.Drawing.Point(4, 22);
            this.tabVisaOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabVisaOrder.Name = "tabVisaOrder";
            this.tabVisaOrder.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabVisaOrder.Size = new System.Drawing.Size(1260, 517);
            this.tabVisaOrder.TabIndex = 2;
            this.tabVisaOrder.Text = "Visa order";
            this.tabVisaOrder.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 435);
            this.Controls.Add(this.tabOrder);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tabOrder.ResumeLayout(false);
            this.tabAllaOrder.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOrder;
        private System.Windows.Forms.TabPage tabAllaOrder;
        private System.Windows.Forms.TabPage tabNyOrder;
        private System.Windows.Forms.ColumnHeader colKund;
        private System.Windows.Forms.ColumnHeader colOrderbeställare;
        private System.Windows.Forms.ColumnHeader colTotalPrice;
        private System.Windows.Forms.ColumnHeader colDiscription;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.Button btnLadda;
        private System.Windows.Forms.ColumnHeader colPayed;
        private System.Windows.Forms.ColumnHeader colLeveransstatus;
        private System.Windows.Forms.ColumnHeader colDatum;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colMoms;
        private System.Windows.Forms.TabPage tabVisaOrder;
        private System.Windows.Forms.ColumnHeader ArtikelId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader colFak;
    }
}