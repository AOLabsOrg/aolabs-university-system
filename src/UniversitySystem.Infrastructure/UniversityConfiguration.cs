using System;

public class UniversityConfiguration : IEntityTypeConfiguration<University>
{
    public void Configure(EntityTypeBuilder<University> builder)
    {
        builder.Property(u => u.Name)
               .HasMaxLength(100)
               .IsRequired();

        builder.Property(u => u.Location)
               .HasMaxLength(200)
               .IsRequired();

        builder.HasMany(u => u.Faculties)
            .WithOne(f => f.University)
            .HasForeignKey(f => f.UniversityId);

        builder.HasMany(u => u.Students)
            .WithOne(s => s.University)
            .HasForeignKey(s => s.UniversityId);
    }
}