namespace BiesPro.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class OrderDetails : BaseModel
    {  
        public string Description { get; set; }

        //// nav prop
        [InverseProperty("OrderDetails")] public Order Order { get; set; }
    }
}