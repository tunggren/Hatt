using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MaterialModel
    {   //Attribut i tabellen
        public int Id { get; set; }
        public string MaterialNamn { get; set; }
        public double Langd { get; set; }

        public double Bredd { get; set; }

        public string Farg { get; set; }

    }
}
