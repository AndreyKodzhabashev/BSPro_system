namespace BiesPro.Data.EntityConfiguration
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;


    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(e => e.OrderDetailId);

            builder.Property(e => e.Description)
                .IsRequired()
                .IsUnicode();
        }
    }
}