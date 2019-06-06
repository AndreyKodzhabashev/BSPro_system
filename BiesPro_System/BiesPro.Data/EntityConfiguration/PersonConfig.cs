namespace BiesPro.Data.EntityConfiguration
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PersonConfig : IEntityTypeConfiguration<Person>

    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.FirstName)
                .HasMaxLength(20)
                .IsRequired()
                .IsUnicode();

            builder.Property(p => p.LastName)
                .HasMaxLength(20)
                .IsRequired()
                .IsUnicode();

            builder.Property(p => p.EGN)
                .HasMaxLength(20)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(20)
                .IsRequired()
                .IsUnicode(false);

            builder.HasOne(p => p.ClientOrVendor)
                .WithOne(cv => cv.ContactPerson)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}