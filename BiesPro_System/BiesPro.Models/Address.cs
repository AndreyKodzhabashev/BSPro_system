namespace BiesPro.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string Name { get; set; }

        public string AddressText { get; set; }

        //navigation properties
        public int TownId { get; set; }
        public Town Town { get; set; }
    }
}