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

namespace DinHatt_CodeFirst.LeverantorMeny
{
    public partial class NyLeverantorTabUserControl : UserControl
    {
        public NyLeverantorTabUserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nyLeverantorbtn_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {

                Leverantor nyLeverantor = new Leverantor()
                {
                    //foretagsId = int.Parse(foreIdtxt.Text),
                    foretagsNamn = foreNamntxt.Text,
                    foretagsAdress = foreAdresstxt.Text,
                    foretagsPostNr = int.Parse(forePostNrtxt.Text),
                    foretagsOrt = foreOrttxt.Text,
                    foretagsLand = foreLandtxt.Text,
                    foretagsTele = foreTeletxt.Text,
                    foretagsEpost = foreEposttxt.Text

                };

                db.Leverantorer.Add(nyLeverantor);
                db.SaveChanges();

                foreNamntxt.Clear();
                foreAdresstxt.Clear();
                forePostNrtxt.Clear();
                foreOrttxt.Clear();
                foreLandtxt.Clear();
                foreTeletxt.Clear();
                foreEposttxt.Clear();
                MessageBox.Show("Vald leverantör är nu tillagd!");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
