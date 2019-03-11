using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace BiesPro.Models
{
    public class ClientOrVendor
    {
        public int ClientOrVendorId { get; set; }

        public string Name { get; set; }

        public string BULSTAT { get; set; }

        //navigation properties
        public int AddressId { get; set; }
        public Address Address { get; set; }

        //also to table Addresses but to different AddressId
        public int DeliveryAddressId { get; set; }
        public Address DeliveryAddress { get; set; }

        [InverseProperty("ClientOrVendor")]
       public Person ContactPerson { get; set; }
    }
}