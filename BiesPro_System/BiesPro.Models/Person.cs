namespace BiesPro.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EGN { get; set; }

        public string PhoneNumber { get; set; }
        

        //navigation properties
        public int AddressId { get; set; }
        public Address Address { get; set; }

        public int ClientOrVendorId { get; set; }
        public ClientOrVendor ClientOrVendor { get; set; }
    }
}