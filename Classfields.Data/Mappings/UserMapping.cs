using Classfields.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Classfields.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(u => u.Email)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(u => u.Password)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(u => u.Role)
                .IsRequired()
                .HasColumnType("varchar(1)");

            builder.Property(u => u.Verified)
                .HasColumnType("bit")
                .HasDefaultValue(0);

            builder.HasMany(u => u.Post)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

        }
    }
}