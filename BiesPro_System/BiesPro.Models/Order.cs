using System;

namespace BiesPro.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        //nav prop
        //TODO Create property in oposite class Relation one-to one
        public int VendorId { get; set; }
        public ClientOrVendor Vendor { get; set; }

        //TODO Create property in oposite class Relation one-to one
        public int ClientId { get; set; }
        public ClientOrVendor Client { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        //TODO Create property in oposite class Relation one-to one
        public int OrderDetailId { get; set; }
        public OrderDetail OrderDetails { get; set; }


    }
}
