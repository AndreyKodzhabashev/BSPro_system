using System.Collections.Generic;

namespace BiesPro.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string AddressText { get; set; }

        //navigation properties
        public int TownId { get; set; }
        public Town Town { get; set; }

        public ICollection<Person> Persons { get; set; }

        public ICollection<ClientOrVendor> ClientOrVendors { get; set; }

    }
}