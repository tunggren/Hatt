using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinHatt_CodeFirst
{
    public class DinHatt : DbContext
    {
        //Här initialiseras alla tabeller i databasen när program körs. 
        //Finns det något här så skapas det en tabell.
        public DbSet<Artikel> Artiklar { get; set; }
        public DbSet<Order> Ordrar { get; set; }
        public DbSet<Kund> Kunder { get; set; }
        public DbSet<MaterialModel> Material { get; set; }

        public DbSet<Leverantor> Leverantorer { get; set; }

    }
}
