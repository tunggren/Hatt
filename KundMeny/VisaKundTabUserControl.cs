using System;
using System.Windows.Forms;
using Models;
using System.Linq;
using DinHatt_CodeFirst.KundMeny;

namespace DinHatt_CodeFirst.KundMeny
{
    public partial class VisaKundTabUserControl : UserControl
    {
        public VisaKundTabUserControl()
        {
            InitializeComponent();
        }


        //Metod för att kunna söka efter en specifik kund i systemet baserat på dess kund ID
        private void btnSok_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int KundID = int.Parse(txtKundID.Text);
                var Kund = (from k in db.Kunder
                            where k.Id == KundID
                            select k).ToList();

                foreach(var item in Kund)
                {
                    txtFnamn.Text = item.FNamn;
                    txtEnamn.Text = item.ENamn;
                    txtAdress.Text = item.Adress;
                    txtPostnr.Text = Convert.ToString(item.PostalCode);
                    txtOrt.Text = item.City;
                    txtTele.Text = item.TelephoneNumber;
                    //txtLand.Text = item.Land;
                    txtEpost.Text = item.ePost;
                    
                }
                
            }

        }

        //Metod för att kunna ändra kundinformation
        private void btnAndra_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int KundID = int.Parse(txtKundID.Text);
                var Kund = (from k in db.Kunder
                            where k.Id == KundID
                            select k).ToList();

                foreach (var item in Kund)
                {
                    item.FNamn = txtFnamn.Text;
                    item.ENamn = txtEnamn.Text;
                    item.Adress = txtAdress.Text;
                    item.PostalCode = int.Parse(txtPostnr.Text);
                    item.City = txtOrt.Text;
                    item.TelephoneNumber = txtTele.Text;
                    //txtLand.Text = item.Land;
                    item.ePost = txtEpost.Text;

                }

                txtFnamn.Clear();
                txtEnamn.Clear();
                txtAdress.Clear();
                txtPostnr.Clear();
                txtOrt.Clear();
                txtTele.Clear();
                //txtLand.Clear();
                txtEpost.Clear();

                db.SaveChanges();

                MessageBox.Show("Kundens information har uppdaterats!");
            }
        }

        //Metod för att kunna ta bort en kund ur systemet
        private void btnTaBort_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int KundID = int.Parse(txtKundID.Text);
                var Kund = db.Kunder.FirstOrDefault(k => k.Id == KundID);

                if (Kund != null)
                {
                    db.Kunder.Remove(Kund);
                    db.SaveChanges();
                }

                txtFnamn.Clear();
                txtEnamn.Clear();
                txtAdress.Clear();
                txtPostnr.Clear();
                txtOrt.Clear();
                txtTele.Clear();
                //txtLand.Clear();
                txtEpost.Clear();

                MessageBox.Show("Kunden har tagits bort!");


            }

        }
  

        private void txtFnamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
