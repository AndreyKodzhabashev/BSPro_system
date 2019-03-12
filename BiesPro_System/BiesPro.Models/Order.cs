namespace BiesPro.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Order
    {
        public int OrderId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        //nav prop
        public int VendorId { get; set; }

        [ForeignKey(nameof(VendorId))]
        [InverseProperty("OrderVendor")]
        public ClientOrVendor Vendor { get; set; }

        //navprop
        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        [InverseProperty("OrderClient")]
        public ClientOrVendor Client { get; set; }

        //navprop = one order has one delivery address
        public int AddressId { get; set; }
        [ForeignKey(nameof(AddressId))]
        [InverseProperty("Order")]
        public Address DeliveryAddress { get; set; }

        //navprop
        public int OrderDetailId { get; set; }
        
        [ForeignKey(nameof(OrderDetailId))]
        [InverseProperty("Order")]
        public OrderDetail OrderDetails { get; set; }
    }
}