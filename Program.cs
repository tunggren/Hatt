using Models;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace DinHatt_CodeFirst
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Tar bort och skapar en ny databas vid schema ändring
           Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DinHatt>());
           

            Application.Run(new StartMenyForm());

        }
    }

}
