namespace BiesPro.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Person
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EGN { get; set; }

        public string PhoneNumber { get; set; }


        //nav property one-to-one with the corresponding ClientOrVendor
        public int ClientOrVendorId { get; set; }

        [ForeignKey(nameof(ClientOrVendorId))]
        [InverseProperty("ContactPerson")]
        public ClientOrVendor ClientOrVendor { get; set; }
    }
}