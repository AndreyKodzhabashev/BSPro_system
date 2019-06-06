namespace BiesPro.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class TownConfig : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode();

            builder.HasOne(t => t.Municipality)
                .WithMany(m => m.Towns)
                .HasForeignKey(t => t.MunicipalityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}