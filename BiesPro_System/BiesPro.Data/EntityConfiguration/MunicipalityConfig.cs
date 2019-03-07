namespace BiesPro.Data.EntityConfiguration
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class MunicipalityConfig : IEntityTypeConfiguration<Municipality>
    {
        public void Configure(EntityTypeBuilder<Municipality> builder)
        {
            builder.HasKey(m => m.MunicipalityId);

            builder.Property(m => m.Name)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();
        }
    }
}