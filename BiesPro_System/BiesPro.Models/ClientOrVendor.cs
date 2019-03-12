namespace BiesPro.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;

    public class ClientOrVendor
    {
        public int ClientOrVendorId { get; set; }

        public string Name { get; set; }

        public string BULSTAT { get; set; }

        //navigation properties
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("ClientOrVendors")]
        public Address Address { get; set; }

        [InverseProperty("ClientOrVendor")] public Person ContactPerson { get; set; }

        [InverseProperty("Client")] public ICollection<Order> OrderClient { get; set; } = new List<Order>();
        [InverseProperty("Vendor")] public ICollection<Order> OrderVendor { get; set; } = new List<Order>();
    }
}