using UniversitySystem.Domain.Common;

namespace UniversitySystem.Domain.Entities;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.Property(d => d.Name)
               .HasMaxLength(100)
               .IsRequired();

        builder.HasOne(d => d.Faculty)
            .WithMany(f => f.Departments)
            .HasForeignKey(d => d.FacultyId);

        builder.HasMany(d => d.Specializations)
            .WithOne(s => s.Department)
            .HasForeignKey(s => s.DepartmentId);
    }
}