﻿namespace BiesPro.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public string Description { get; set; }

        //nav prop
        [InverseProperty("OrderDetail")] public Order Order { get; set; }
    }
}