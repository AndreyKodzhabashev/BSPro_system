namespace BiesPro.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Order : BaseModel
    {
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        //nav prop
        public uint VendorId { get; set; }

        [ForeignKey(nameof(VendorId))]
        [InverseProperty("OrderVendor")]
        public ClientOrVendor Vendor { get; set; }

        //navprop
        public uint ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        [InverseProperty("OrderClient")]
        public ClientOrVendor Client { get; set; }

        //navprop = one order has one delivery address
        public uint AddressId { get; set; }
        [ForeignKey(nameof(AddressId))]
        [InverseProperty("Order")]
        public Address DeliveryAddress { get; set; }

        //navprop
        public uint OrderDetailsId { get; set; }
        
        [ForeignKey(nameof(OrderDetailsId))]
        [InverseProperty("Order")]
        public OrderDetails OrderDetails { get; set; }
    }
}