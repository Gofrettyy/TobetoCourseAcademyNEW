using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfigurations;

public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.ToTable("Instructors").HasKey(b => b.Id);
        builder.Property(b => b.Id ).HasColumnName("Id").IsRequired(); 
        builder.Property(b => b.Name ).HasColumnName("Name").IsRequired();
        builder.HasIndex(indexExpression: b => b.Name , name: "UK_Instructors_Instructor").IsUnique();
        builder.HasMany(b => b.Courses);
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}