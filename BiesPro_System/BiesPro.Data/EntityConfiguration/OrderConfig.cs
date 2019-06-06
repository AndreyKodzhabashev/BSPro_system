namespace BiesPro.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(o => o.Vendor)
                .WithMany(cv => cv.OrderVendor)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.HasOne(o => o.Client)
                .WithMany(cv => cv.OrderClient)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.DeliveryAddress)
                .WithOne(a => a.Order)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.OrderDetails)
                .WithOne(od => od.Order)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}