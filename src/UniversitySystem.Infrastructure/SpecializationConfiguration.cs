using UniversitySystem.Domain.Common;

namespace UniversitySystem.Domain.Entities;

public class SpecializationConfiguration : IEntityTypeConfiguration<Specialization>
{
    public void Configure(EntityTypeBuilder<Specialization> builder)
    {
        builder.Property(s => s.Name)
               .HasMaxLength(100)
               .IsRequired();

        builder.HasOne(s => s.Department)
            .WithMany(d => d.Specializations)
            .HasForeignKey(s => s.DepartmentId);

        builder.HasMany(s => s.Students)
            .WithOne(std => std.Specialization)
            .HasForeignKey(std => std.SpecializationId);
    }
}