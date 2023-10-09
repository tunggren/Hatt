using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinHatt_CodeFirst.OrderMeny
{
    public partial class NyOrderTabUserControl : UserControl
    {
        private int counter = 0;

       
       private double priset = 0;
        string allItems = "";
        public NyOrderTabUserControl()
        {
            InitializeComponent();
        }

        private void btnNyOrder_Click(object sender, EventArgs e)
        {

            if(!rdBtnJudith.Checked && !rdBtnOtto.Checked)
            {
                MessageBox.Show("Var vänlig och fyll in vem som skapar ordern.");
            }

            else
            {

                string radionamn = FindOrderHandler();

                float momssats = FindMomsSats();

                string allItems = Hamta();

                using (var db = new DinHatt())
                {




                    Order nyOrder = new Order()
                    {

                        Description = tbxDescription.Text,

                        PrelimPrice = double.Parse(tbxTotPris.Text),

                        ArtikelTitle = allItems,

                        Payed = cbxPayed.Checked,

                        Delivered = cbxDelivered.Checked,

                        OrderDate = dateTimePicker1.Value.Date,

                        Orderbeställare = radionamn,

                        KundId = Convert.ToInt32(txSökKund.Text),

                        Moms = momssats,

                        Aktiv = true,

                    };
                    

                    db.Ordrar.Add(nyOrder);


                    //Uppdatera artikel lager saldo efter att ha lagt order
                    int artikelID = int.Parse(txbSökArtikel.Text);
                    var artikel = (from a in db.Artiklar
                                   where a.Id == artikelID
                                   select a).ToList();

                    foreach (var item in artikel)
                    {
                        item.AntalILager = int.Parse(tbxAntalLager.Text);

                    }

                    db.SaveChanges();


                    tbxDescription.Clear();
                    tbxPrice.Clear();
                    cbxDelivered.Checked= false;
                    cbxPayed.Checked = false;
                    rdBtnJudith.Checked= false;
                    rdBtnOtto.Checked= false;
                    dateTimePicker1.Value = DateTime.Now;
                    txSökKund.Clear();
                    tbKundNamn.Clear();
                    txbSökArtikel.Clear();
                    lstbxArtikel.Items.Clear();
                    tbxAntalLager.Clear();
                    tbxTotPris.Text = 0.ToString();








                    MessageBox.Show("Du har skapat ny order!");

                }

            }

        }

        private string FindOrderHandler()
        {
            string radionamn = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
            switch (radionamn)
            {
                case "rdBtnJudith":
                    radionamn = "Judith";
                    break;
                case "rdBtnOtto":
                    radionamn = "Otto";
                    break;
                default:
                    MessageBox.Show("Var vänlig och fyll in vem som skapar ordern.");
                    break;
            }

            return radionamn;
        }

        

        private float FindMomsSats()
        {
            float prePris = 0;
            prePris = float.Parse(tbxPrice.Text);
            float momssats = (prePris * 1.25F);

            return momssats;

        }

        private void btnSökKund_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int KundID = int.Parse(txSökKund.Text);
                var Kund = (from k in db.Kunder
                            where k.Id == KundID
                            select k).ToList();

                foreach (var item in Kund)
                {
                    tbKundNamn.Text = item.FNamn + item.ENamn;
                  
                }
            }

        }

        private string Hamta()
        {
            foreach (var item in lstbxArtikel.Items)
            {

      
                 allItems = string.Join(" , ", lstbxArtikel.Items.OfType<object>());

            }
            return allItems;
        }

        private void NyOrderTabUserControl_Load(object sender, EventArgs e)
        {

        }

        


        private void button1_Click(object sender, EventArgs e, string sum, string summation)
        {

          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxAntalLager_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grbxAntalLager.Show();
            counter++;

            using (var db = new DinHatt())
            {
                int ArtikelId = int.Parse(txbSökArtikel.Text);
                var Artikel = (from k in db.Artiklar
                               where k.Id == ArtikelId
                               select k).ToList();

               

                foreach (var item in Artikel)
                {
                   
               
                    lstbxArtikel.Items.Add(item.Name);
                  tbxPrice.Text = item.Pris.ToString();
                    tbxTotPris.Text = item.Pris.ToString();
                    tbxAntalLager.Text = (item.AntalILager).ToString();
                    
                    //todo fixa lagersaldo 



                    for (int i = 1; i < counter; i++)
                    {

                         priset = double.Parse(tbxPrice.Text);

                        double sum = double.Parse(tbxTotPris.Text);

                      //  doSum = double.Parse(tbxTotPris.Text);

                        sum = priset + sum;
                        tbxTotPris.Text = sum.ToString();

                     
                    
                        tbxAntalLager.Text = Convert.ToString(item.AntalILager - 1);

                        item.AntalILager = int.Parse(tbxAntalLager.Text);



                    }

                   


                }



            }
        }

        private void tbxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
