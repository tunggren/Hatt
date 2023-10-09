namespace Models
{
    public class Kund
    {
        //Attribut i tabellen
        public int Id { get; set; }
        public string FNamn { get; set; }
        public string ENamn { get; set; }

        public string TelephoneNumber { get; set; }

        public string Adress { get; set; }

        public int PostalCode { get; set; }
        public string City { get; set; }

        //public string Land { get; set; }
        public string ePost { get; set; }

        public bool Aktiv { get; set; }

    }

}
