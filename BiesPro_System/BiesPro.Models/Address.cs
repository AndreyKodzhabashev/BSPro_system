﻿namespace BiesPro.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Address : BaseModel
    {
        public Address()
        {
            this.ClientOrVendors = new HashSet<ClientOrVendor>();
        }
              
        public string AddressText { get; set; }

        //// navigation properties
        public uint TownId { get; set; }

        public Town Town { get; set; }

        //// Unable to determine the relationship represented by navigation property 'Address.ClientOrVendors' of type 'ICollection<ClientOrVendor>'. Either manually configure the relationship, or ignore this property using the '[NotMapped]' attribute or by using 'EntityTypeBuilder.Ignore' in 'OnModelCreating'.
        [InverseProperty("Address")] public ICollection<ClientOrVendor> ClientOrVendors { get; set; }

        [InverseProperty("DeliveryAddress")] public Order Order { get; set; }
    }
}