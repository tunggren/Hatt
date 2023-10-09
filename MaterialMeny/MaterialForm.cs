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

namespace DinHatt_CodeFirst.MaterialMeny
{
    public partial class MaterialForm : Form
    {
        public MaterialForm()
        {
            InitializeComponent();
        }

        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {

                MaterialModel nyttMaterial = new MaterialModel()
                {
                    MaterialNamn = txtMaterial.Text,
                    Langd = Convert.ToDouble(txtLangd.Text),
                    Bredd = Convert.ToDouble(txtBredd.Text),
                    Farg = txtFarg.Text,
                    
                };

                db.Material.Add(nyttMaterial);
                db.SaveChanges();


                txtMaterial.Clear();
                txtLangd.Clear();
                txtBredd.Clear();
                txtFarg.Clear();


                MessageBox.Show("Materialet har lagts till!");

            }
        }

        private void btnMateriallista_Click(object sender, EventArgs e)
        {
            lvMaterial.BeginUpdate();
            lvMaterial.Items.Clear();

            using (var db = new DinHatt())
            {

                foreach (var item in db.Material)
                {
                    ListViewItem rad = new ListViewItem();

                    rad.SubItems.Add(item.Id.ToString());
                    rad.SubItems.Add(item.MaterialNamn);
                    rad.SubItems.Add(item.Langd.ToString());
                    rad.SubItems.Add(item.Bredd.ToString());
                    rad.SubItems.Add(item.Farg);
                    


                    lvMaterial.Items.Add(rad);
                }

                lvMaterial.EndUpdate();
                lvMaterial.Refresh();
            }
        }

        private void lvMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHamtaInfo_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int MaterialID = int.Parse(txtMaterialId.Text);
                var Material = (from m in db.Material
                            where m.Id == MaterialID
                            select m).ToList();

                foreach (var item in Material)
                {
                    txtHanteraMaterial.Text = item.MaterialNamn;
                    txtHanteraLangd.Text = Convert.ToString(item.Langd);
                    txtHanteraBredd.Text = Convert.ToString(item.Bredd);
                    txtHanteraFarg.Text = item.Farg;                  

                }

            }
        }

        private void btnAndra_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int MaterialID = int.Parse(txtMaterialId.Text);
                var Material = (from m in db.Material
                                where m.Id == MaterialID
                                select m).ToList();

                foreach (var item in Material)
                {
                    item.MaterialNamn = txtHanteraMaterial.Text;
                    item.Langd = double.Parse(txtHanteraLangd.Text);
                    item.Bredd = double.Parse(txtHanteraBredd.Text);
                    item.Farg = txtHanteraFarg.Text;

                }

                txtHanteraMaterial.Clear();
                txtHanteraLangd.Clear();
                txtHanteraBredd.Clear();
                txtHanteraFarg.Clear();

                db.SaveChanges();

                MessageBox.Show("Materialets information har uppdaterats!");
            }
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int MaterialID = int.Parse(txtMaterialId.Text);
                var Material = db.Material.FirstOrDefault(m => m.Id == MaterialID);

                if (Material != null)
                {
                    db.Material.Remove(Material);
                    db.SaveChanges();
                }

                txtHanteraMaterial.Clear();
                txtHanteraLangd.Clear();
                txtHanteraBredd.Clear();
                txtHanteraFarg.Clear();


                MessageBox.Show("Materialet har tagits bort!");


            }
        }
    }
}
