namespace BiesPro.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Address
    {
        public Address()
        {
            this.Persons = new List<Person>();
            this.ClientOrVendors = new List<ClientOrVendor>();
        }

        public int AddressId { get; set; }

        public string AddressText { get; set; }

        //navigation properties
        public int TownId { get; set; }
        public Town Town { get; set; }

        public ICollection<Person> Persons { get; set; }

        public ICollection<ClientOrVendor> ClientOrVendors { get; set; }

        [InverseProperty("DeliveryAddress")] public Order Order { get; set; }
    }
}