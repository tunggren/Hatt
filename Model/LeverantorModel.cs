using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Leverantor
    {
        [Key]
        //Attribut i tabellen
        public int foretagsId { get; set; }
        public string foretagsNamn { get; set; }
        public string foretagsAdress { get; set; }

        public int foretagsPostNr { get; set; }

        public string foretagsOrt { get; set; }

        public string foretagsLand { get; set; }
        public string foretagsTele { get; set; }
        public string foretagsEpost { get; set; }
    }
}
