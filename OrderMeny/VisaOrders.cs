using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.Web.UI;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace DinHatt_CodeFirst.OrderMeny
{

    public partial class VisaOrders : UserControl
    {


        public VisaOrders()
        {

            InitializeComponent();
                    }

        private void btnDeletOrder_Click(object sender, EventArgs e)
        {

            using (var db = new DinHatt())
            {
                int OrderId = int.Parse(tbxOrderId.Text);
                var Order = (from k in db.Ordrar
                               where k.Id == OrderId
                               select k).ToList();

                foreach (var item in Order)
                {
                    item.Aktiv = false;

                }

                db.SaveChanges();

             

                MessageBox.Show("Du har tagit bort order!");

                Clear();


            }

        }

        private void Clear()
        {
            tbSökOrderId.Clear();
            tbxOrderDes.Clear();
            tbxOrderId.Clear();
            tbxTotalPrice.Clear();
            ArtikelList.Items.Clear();
            cbxSkickad.Checked = false;
            cbxBetalad.Checked = false;
            cbxFak.Checked = false;

        }

        private void btnSökOrderId_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int OrderId = int.Parse(tbSökOrderId.Text);
                var Order = (from k in db.Ordrar
                             where k.Id == OrderId
                             select k).ToList();

                foreach (var item in Order)
                {
                    if (item.Aktiv == true)
                    {
                        tbxOrderId.Text = item.Id.ToString();

                        ArtikelList.Items.AddRange(item.ArtikelTitle.ToString().Split(','));

                        tbxOrderDes.Text = item.Description;

                        tbxTotalPrice.Text = item.PrelimPrice.ToString();

                        cbxBetalad.Checked = item.Payed;

                        cbxSkickad.Checked = item.Delivered;

                        cbxFak.Checked = item.Fakturerad;
                    }
                    else
                    {
                        MessageBox.Show("Thier is no order to show!");
                    }







                }
            }
        }

        private void btnÄndraOrder_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int OrderId = int.Parse(tbSökOrderId.Text);
                var Order = (from k in db.Ordrar
                             where k.Id == OrderId
                             select k).ToList();



                foreach (var item in Order)
                {

                    item.Description = tbxOrderDes.Text;
                    item.Payed = cbxBetalad.Checked;
                    item.Delivered = cbxSkickad.Checked;
                    item.PrelimPrice = int.Parse(tbxTotalPrice.Text);
                    item.Fakturerad = cbxFak.Checked;
                  

                }

                db.SaveChanges();

                MessageBox.Show("Beställningen har blivit ändrad!");

                Clear();

            }

            
        }


        private void btnFak_Click(object sender, EventArgs e)
        {
            
            using (var db = new DinHatt())
            {
                int OrderId = int.Parse(tbSökOrderId.Text);
                var Order = (from k in db.Ordrar
                             where k.Id == OrderId
                             select k).ToList();
               // var doc1 = new Document();

               
                foreach (var item in Order)
                {
                    cbxFak.Checked = true;
                    item.Fakturerad = cbxFak.Checked;
                   
                }


                db.SaveChanges();
                MessageBox.Show("Beställningen är nu fakturerad!");

                Clear();
            }





        }
           
           
           
            
            }
      }
    

