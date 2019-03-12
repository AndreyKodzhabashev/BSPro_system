namespace BiesPro.Data.EntityConfiguration
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.OrderId);

            builder.HasOne(o => o.Vendor)
                .WithOne(cv => cv.OrderVendor);
            
            builder.HasOne(o => o.Client)
                .WithOne(cv => cv.OrderClient);

            builder.HasOne(o => o.DeliveryAddress)
                .WithOne(a => a.Order);

            builder.HasOne(o => o.OrderDetails)
                .WithOne(od => od.Order);
        }
    }
}