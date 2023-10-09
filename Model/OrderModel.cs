using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Order
    {
        //Attribut i databasen
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }
        public double PrelimPrice { get; set; }
        public bool Delivered { get; set; }
        public bool Payed { get; set; }
        public bool Canceled { get; set; }
        public string Description { get; set; }

        public string Orderbeställare { get; set; }

        public float Moms { get; set; }

        //1-till-många samband. Varje order måste ha en kund.
        public virtual Kund Kund { get; set; }

        [ForeignKey("Kund")]
        public int KundId { get; set; }

         //Säger till databasen att det ska vara FK
        public ICollection<Artikel> Artikel { get; set; }

        //Kod för att Entityframwork ska förstå många-till-många samband

        [ForeignKey("Artikel")]
        public int ArtikelTd { get; set; }

        public string ArtikelTitle { get; set; }

        public bool Aktiv { get; set; }

        public bool Fakturerad { get; set; }    


        public Order()
        {
            Artikel = new HashSet<Artikel>();
        }

    }
}
