using UniversitySystem.Domain.Common;

namespace UniversitySystem.Domain.Entities;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(s => s.FullName)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(s => s.NationalId)
            .HasMaxLength(14)
            .IsRequired();

        builder.HasIndex(s => s.NationalId)
            .IsUnique();

        builder.Property(s => s.Email)
            .HasMaxLength(70);

        builder.Property(s => s.Gender)
            .HasConversion<string>()
            .IsRequired();

        builder.Property(s => s.BirthDate)
            .IsRequired();

        builder.Property(s => s.AcademicYear)
            .IsRequired();


        builder.HasOne(s => s.University)
            .WithMany(u => u.Students)
            .HasForeignKey(s => s.UniversityId);

        builder.HasOne(s => s.Faculty)
            .WithMany(f => f.Students)
            .HasForeignKey(s => s.FacultyId);

        builder.HasOne(s => s.Department)
            .WithMany(d => d.Students)
            .HasForeignKey(s => s.DepartmentId);

        builder.HasOne(s => s.Specialization)
            .WithMany(sp => sp.Students)
            .HasForeignKey(s => s.SpecializationId);

    }
}

