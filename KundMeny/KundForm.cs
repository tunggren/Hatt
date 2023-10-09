using DinHatt_CodeFirst.ArtikelMeny;
using DinHatt_CodeFirst.KundMeny;
using Models;
using System;
using System.Windows.Forms;

namespace DinHatt_CodeFirst
{
    public partial class KundForm : Form
    {
        public KundForm()
        {
            InitializeComponent();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {

            using (var db = new DinHatt())
            {

                Kund nyKund = new Kund()
                {
                    FNamn = txtFnamn.Text,
                    ENamn = txtEnamn.Text,
                    Adress = txtAdress.Text,
                    PostalCode = Convert.ToInt32(txtPostnr.Text),
                    City = txtOrt.Text,
                    TelephoneNumber = txtTele.Text,
                    // Land = txtLand.Text,
                    ePost = txtEpost.Text,
                };

                db.Kunder.Add(nyKund);
                db.SaveChanges();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listKunder.BeginUpdate();
            listKunder.Items.Clear();

            using (var db = new DinHatt())
            {

                foreach (var item in db.Kunder)
                {
                    ListViewItem rad = new ListViewItem();

                    rad.SubItems.Add(item.Id.ToString());
                    rad.SubItems.Add(item.FNamn);
                    rad.SubItems.Add(item.ENamn);
                    rad.SubItems.Add(item.Adress);
                    rad.SubItems.Add(item.PostalCode.ToString());
                    rad.SubItems.Add(item.City);
                    rad.SubItems.Add(item.TelephoneNumber.ToString());

                    rad.SubItems.Add(item.ePost);

                    listKunder.Items.Add(rad);
                }

                listKunder.EndUpdate();
                listKunder.Refresh();
            }
        }

        private void tabKunder_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                //Alla Kunder Tabben
                case 0:

                    break;

                //Ny Kund Tabb
                case 1:

                    NyKundTabUserControl nyKundTabUserControl = new NyKundTabUserControl();
                    tabNyKund.Controls.Add(nyKundTabUserControl);

                    break;

                //Visa Kund tab
                case 2:

                    VisaKundTabUserControl visaKundTabUserControl = new VisaKundTabUserControl();

                    tabSokKund.Controls.Add(visaKundTabUserControl);

                    break;


            }
        }


    }
}
