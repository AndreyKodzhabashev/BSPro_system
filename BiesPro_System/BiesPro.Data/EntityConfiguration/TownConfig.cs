namespace BiesPro.Data.EntityConfiguration
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TownConfig : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(t => t.TownId);

            builder.Property(t => t.Name)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();

            builder.HasOne(t => t.Municipality)
                .WithMany(m => m.Towns)
                .HasForeignKey(t => t.MunicipalityId);

        }
    }
}