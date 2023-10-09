using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinHatt_CodeFirst.ArtikelMeny
{
    public partial class NyArtikelTabUserControl : UserControl
    {
        public NyArtikelTabUserControl()
        {
            InitializeComponent();
        }


        private void btnSparaNyArtikel_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string bildNamn = random.Next(1000,9999).ToString()+".jpg";
            string bildMapp = "..\\..\\Bilder";
            string pathstring = Path.Combine(bildMapp, bildNamn);

   

            File.Copy(txtBildNamn.Text,pathstring);
            
           

            using (var db = new DinHatt())
            {

                Artikel nyArtikel = new Artikel()
                {
                    Name = txtArtikelNamn.Text,
                    Description = txtBeskrivning.Text,
                    AntalILager = int.Parse(txtAntalILager.Text),
                    Begagnad = chkBegagnad.Checked,
                    BildNamn = bildNamn,
                    Pris = double.Parse(txtPris.Text)

                };

                db.Artiklar.Add(nyArtikel);
                db.SaveChanges();
            }

        }

        private void btnLaddaInBild_Click(object sender, EventArgs e)
        {



            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                picboxArtikel.Image = Image.FromFile(fileOpen.FileName);
                txtBildNamn.Text = fileOpen.FileName;
            }
            fileOpen.Dispose();

        }

        private void txtBeskrivning_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBegagnad_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
