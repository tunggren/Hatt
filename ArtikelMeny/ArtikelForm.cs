using DinHatt_CodeFirst.ArtikelMeny;
using System;
using System.Windows.Forms;

namespace DinHatt_CodeFirst
{
    public partial class Artikelform : Form
    {


        public Artikelform()
        {
            InitializeComponent();

        }

        private void Artikelform_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Artikelform_Load(object sender, EventArgs e)
        {

        }

        private void tabNyArtikel_Click(object sender, EventArgs e)
        {

        }

        private void Artikelform_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }
           //
        private void btnVisaArtiklar_Click(object sender, EventArgs e)
        {
            listArtikel.BeginUpdate();
            listArtikel.Items.Clear();

            using (var db = new DinHatt())
            {
                foreach (var item in db.Artiklar)
                {
                    ListViewItem rad = new ListViewItem();

                    rad.SubItems.Add(item.Name);
                    rad.SubItems.Add(item.Id.ToString());
                    rad.SubItems.Add(item.Description);
                    rad.SubItems.Add(item.HeadSize.ToString());
                    if(item.Begagnad == true)
                    {
                        item.Pris = (item.Pris * 1.125);
                        rad.SubItems.Add(item.Pris.ToString());

                    }
                    else if(item.Begagnad == false)
                    {
                        item.Pris = (item.Pris * 1.25);
                        rad.SubItems.Add(item.Pris.ToString());
                    }
                    
                    rad.SubItems.Add(item.BildNamn);
                    rad.SubItems.Add(item.AntalILager.ToString());
                    

                    if
                        (item.Begagnad == true)
                    {
                        rad.SubItems.Add("Ja");
                        
                    }
                    
                    else {
                        rad.SubItems.Add("Nej");
                        
                    };

                    if(item.Begagnad == true)
                    {
                        item.Moms = item.Moms + 12.5;
                        rad.SubItems.Add(item.Moms.ToString());
                    }
                    else
                    {
                        item.Moms = item.Moms + 25;
                        rad.SubItems.Add(item.Moms.ToString());
                    }

                    listArtikel.Items.Add(rad);
                }
                listArtikel.EndUpdate();
                listArtikel.Refresh();
            }
        }

        private void tabArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {
			switch ((sender as TabControl).SelectedIndex)
			{
				//Alla Artiklar Tab
				case 0:
                    //Gör inget eftersom det är default tab som öppnas just nu.
					break;

				//Ny Artikel Tab
				case 1:

					NyArtikelTabUserControl nyArtikelUserControl = new NyArtikelTabUserControl();
					tabNyArtikel.Controls.Add(nyArtikelUserControl);

					break;


				//Visa Artikel tab
				case 2:

					VisaArtikelTabUserControl visaArtikelTabUserControl = new VisaArtikelTabUserControl();
					tabVisaArtikel.Controls.Add(visaArtikelTabUserControl);

					break;

            }
        }

        private void listArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
