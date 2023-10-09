using DinHatt_CodeFirst.LeverantorMeny;
using DinHatt_CodeFirst.MaterialMeny;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DinHatt_CodeFirst
{
    public partial class StartMenyForm : Form
    {


        //Sprint2
        //ExportForm exportForm = new ExportForm();

        public StartMenyForm()
        {
            InitializeComponent();
        }

        private void btnArtikelMeny_Click(object sender, EventArgs e)
        {
            //Kolla om formen är öppen
            //https://stackoverflow.com/questions/3861602/how-to-check-if-a-windows-form-is-already-open-and-close-it-if-it-is
            if (Application.OpenForms.OfType<Artikelform>().Count() == 1)
            {
                Application.OpenForms.OfType<Artikelform>().First().BringToFront();

            }
            else
            {
                Artikelform artikelform = new Artikelform
                {
                    TopLevel = false,
                    AutoScroll = true
                };
                // artikelform.Dock = DockStyle.Fill;
                pnlStart.Controls.Add(artikelform);
                artikelform.BringToFront();
                artikelform.Show();
                //btnArtikelMeny.Enabled = false;
            }
            //Application.OpenForms.OfType<Artikelform>().First().Close();


        }

        private void btnNyKundMeny_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<KundForm>().Count() == 1)
            {
                Application.OpenForms.OfType<KundForm>().First().BringToFront();
            }

            else
            {
                KundForm kundForm = new KundForm
                {
                    TopLevel = false,
                    AutoScroll = true

                };
                //kundForm.Dock = DockStyle.Fill;
                pnlStart.Controls.Add(kundForm);
                kundForm.BringToFront();
                kundForm.Show();
            }
        }
        private void btnNyOrderMeny_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<OrderForm>().Count() == 1)
            {
                Application.OpenForms.OfType<OrderForm>().First().BringToFront();
            }
            else
            {


                OrderForm orderForm = new OrderForm
                {
                    TopLevel = false,
                    AutoScroll = true
                };
                //orderForm.Dock = DockStyle.Fill;
                pnlStart.Controls.Add(orderForm);
                orderForm.BringToFront();
                orderForm.Show();
            }

        }


        private void btnStatistikMeny_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<StatistikForm>().Count() == 1)
            {
                Application.OpenForms.OfType<StatistikForm>().First().BringToFront();

            }
            else
            {
                StatistikForm statistikForm = new StatistikForm
                {
                    TopLevel = false,
                    AutoScroll = true
                };
                pnlStart.Controls.Add(statistikForm);
                statistikForm.BringToFront();
                statistikForm.Show();

            }
      

        }

        private void btnMaterialMeny_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<MaterialForm>().Count() == 1)
            {
                Application.OpenForms.OfType<MaterialForm>().First().BringToFront();

            }
            else
            {
                MaterialForm form = new MaterialForm
                {
                    TopLevel = false,
                    AutoScroll = true
                };
                pnlStart.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }


        }

        private void btnLeverantorMeny_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<LeverantorForm>().Count() == 1)
            {
                Application.OpenForms.OfType<LeverantorForm>().First().BringToFront();

            }
            else
            {


            }
            LeverantorForm form = new LeverantorForm
            {
                TopLevel = false,
                AutoScroll = true
            };
            pnlStart.Controls.Add(form);
            form.BringToFront();
            form.Show();

        }
    }
}
