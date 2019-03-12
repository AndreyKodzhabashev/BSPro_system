namespace BiesPro.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

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

        //also to table Addresses but to different AddressId
        public int DeliveryAddressId { get; set; }
        public Address DeliveryAddress { get; set; }

        [InverseProperty("ClientOrVendor")] public Person ContactPerson { get; set; }

        [InverseProperty("Client")] public Order OrderClient { get; set; }
        [InverseProperty("Vendor")] public Order OrderVendor { get; set; }
    }
}