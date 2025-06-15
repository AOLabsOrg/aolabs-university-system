using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversitySystem.Domain.Entities;

namespace UniversitySystem.Infrastructure.Persistence.Configurations
{
    public class SpecializationConfiguration : IEntityTypeConfiguration<Specialization>
    {
        public void Configure(EntityTypeBuilder<Specialization> builder)
        {
            //builder.ToTable("Specializations");

            builder.Property(u => u.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasOne(s => s.Department)
                   .WithMany(d => d.Specializations)
                   .HasForeignKey(s => s.DepartmentId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(s => s.Students)
                   .WithOne(s => s.Specialization)
                   .HasForeignKey(s => s.SpecializationId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
