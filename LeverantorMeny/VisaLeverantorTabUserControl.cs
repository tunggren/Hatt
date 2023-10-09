using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinHatt_CodeFirst.LeverantorMeny
{
    public partial class VisaLeverantorTabUserControl : UserControl
    {
        public VisaLeverantorTabUserControl()
        {
            InitializeComponent();
        }

        private void sokForebtn_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int ForetagsID = int.Parse(leverantorIdtxt.Text);
                var Foretag = (from f in db.Leverantorer
                               where f.foretagsId == ForetagsID
                               select f).ToList();

                foreach (var item in Foretag)
                {
                    foreNamntxt.Text = item.foretagsNamn;
                    foreAdresstxt.Text = item.foretagsAdress;
                    forePostNrtxt.Text = Convert.ToString(item.foretagsPostNr);
                    foreOrttxt.Text = item.foretagsOrt;
                    foreLandtxt.Text = item.foretagsLand;
                    foreTeletxt.Text = item.foretagsTele;
                    foreEposttxt.Text = item.foretagsEpost;

                }

            }
        }

        private void UppdateraForetagbtn_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int ForetagsID = int.Parse(leverantorIdtxt.Text);
                var Foretag = (from f in db.Leverantorer
                               where f.foretagsId == ForetagsID
                               select f).ToList();

                foreach (var item in Foretag)
                {
                    item.foretagsNamn = foreNamntxt.Text;
                    item.foretagsAdress = foreAdresstxt.Text;
                    item.foretagsPostNr = int.Parse(forePostNrtxt.Text);
                    item.foretagsOrt = foreOrttxt.Text;
                    item.foretagsLand = foreLandtxt.Text;
                    item.foretagsTele = foreTeletxt.Text;
                    item.foretagsEpost = foreEposttxt.Text;
                }

                db.SaveChanges();

                foreNamntxt.Clear();
                foreAdresstxt.Clear();
                forePostNrtxt.Clear();
                foreOrttxt.Clear();
                foreLandtxt.Clear();
                foreTeletxt.Clear();
                foreEposttxt.Clear();
                MessageBox.Show("Leverantörens information har uppdaterats!");
            }
        }

        private void taBortForebtn_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int ForetagsID = int.Parse(leverantorIdtxt.Text);
                var Foretag = db.Leverantorer.FirstOrDefault(f => f.foretagsId == ForetagsID);

                if (Foretag != null)
                {
                    db.Leverantorer.Remove(Foretag);
                    db.SaveChanges();
                }

                foreNamntxt.Clear();
                foreAdresstxt.Clear();
                forePostNrtxt.Clear();
                foreOrttxt.Clear();
                foreLandtxt.Clear();
                foreTeletxt.Clear();
                foreEposttxt.Clear();
                MessageBox.Show("Leverantören har tagits bort!");

            }
        }
    }
}
