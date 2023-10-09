using System.IO;
using System.Windows.Forms;

namespace DinHatt_CodeFirst
{
    public partial class StatistikForm : Form
    {
        public StatistikForm()
        {
            InitializeComponent();
        }

        private void btnVisaStatistik_Click(object sender, System.EventArgs e)
        {
            btnExport.Enabled = true;
            listViewOrder.BeginUpdate();
            listViewOrder.Items.Clear();

            using (var db = new DinHatt())
            {
                double summa = 0;
                double moms = 0;

                foreach (var item in db.Ordrar)
                {
                    ListViewItem rad = new ListViewItem();
                    
                    if (item.OrderDate >= dateTimeStart.Value.Date && item.OrderDate <= dateTimeSlut.Value.Date && item.Delivered == true && item.Payed == true)
                    {

                        rad.SubItems.Add(item.Id.ToString());
                        rad.SubItems.Add(item.PrelimPrice.ToString());
                        rad.SubItems.Add(item.OrderDate.ToShortDateString());

                        summa = summa + item.PrelimPrice;
                        moms = moms + (item.Moms * 0.2);





                        listViewOrder.Items.Add(rad);
                    }
                }
                txtboxMoms.Text = moms.ToString();
                txtboxTotalBetal.Text = summa.ToString();
                listViewOrder.EndUpdate();
                listViewOrder.Refresh();
            }
        }

        private void btnExport_Click(object sender, System.EventArgs e)
        {

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter("EkonomiExport.txt"))
            {
               
                sw.WriteLine("Antal Ordrar:");
                sw.WriteLine(listViewOrder.Items.Count);
                sw.WriteLine("Startdatum:");
                sw.WriteLine(dateTimeStart.Value.Date.ToString());
                sw.WriteLine("Slutdatum:");
                sw.WriteLine(dateTimeSlut.Value.Date.ToString());
                sw.WriteLine("Total Summa (kr):");
                sw.WriteLine(txtboxTotalBetal.Text);
                sw.WriteLine("Total moms (kr):");
                sw.WriteLine(txtboxMoms.Text);
            
            }

            btnExport.Enabled = false;

        }
    }
}