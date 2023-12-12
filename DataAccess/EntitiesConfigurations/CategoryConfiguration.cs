using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfigurations;


    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories").HasKey(b => b.Id);
            builder.Property(b => b.Id ).HasColumnName("Id").IsRequired(); 
            builder.Property(b => b.Name ).HasColumnName("Name").IsRequired();
            builder.HasIndex(indexExpression: b => b.Name , name: "UK_Categories_Name").IsUnique();
            builder.HasMany(b => b.Courses);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
