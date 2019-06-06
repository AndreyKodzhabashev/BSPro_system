namespace BiesPro.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ClientOrVendor : BaseModel
    {
        public ClientOrVendor()
        {
            this.OrderClient = new HashSet<Order>();
            this.OrderVendor = new HashSet<Order>();
        }

        public string Name { get; set; }

        public string BULSTAT { get; set; }

        //// navigation properties
        public uint AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("ClientOrVendors")]
        public Address Address { get; set; }

        [InverseProperty("ClientOrVendor")] public Person ContactPerson { get; set; }

        [InverseProperty("Client")] public ICollection<Order> OrderClient { get; set; }

        [InverseProperty("Vendor")] public ICollection<Order> OrderVendor { get; set; }
    }
}