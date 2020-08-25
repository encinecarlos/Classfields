using Classfields.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Classfields.Data.Mappings
{
    public class PostMapping : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Age)
                .HasColumnType("varchar(10)");

            builder.Property(p => p.Email)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(p => p.Ethnicity)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(p => p.Eyes)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(p => p.SocialNetworks)
                .HasColumnType("varchar(1000)");

            builder.Property(p => p.Gender)
                .IsRequired()
                .HasColumnType("varchar(15)");

            builder.Property(p => p.Height)
                .IsRequired()
                .HasColumnType("varchar(5)");

            builder.Property(p => p.Hips)
                .IsRequired()
                .HasColumnType("varchar(5)");

            builder.Property(p => p.HairColor)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(p => p.Incall)
                .IsRequired()
                .HasColumnType("integer");

            builder.Property(p => p.Outcall)
                .IsRequired()
                .HasColumnType("integer");

            builder.Property(p => p.Affiliation)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(p => p.Phone)
                .IsRequired()
                .HasColumnType("varchar(15)");

            builder.Property(p => p.Country)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(p => p.City)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(p => p.State)
                .IsRequired()
                .HasColumnType("varchar(30)");

            builder.Property(p => p.Status)
                .IsRequired()
                .HasColumnType("varchar(2)");

            builder.Property(p => p.ShortDescription)
                .IsRequired()
                .HasColumnType("varchar(280)");

            builder.Property(p => p.Description)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.Property(p => p.Waist)
                .IsRequired()
                .HasColumnType("varchar(5)");

            builder.Property(p => p.Weight)
                .IsRequired()
                .HasColumnType("varchar(5)");

            builder.Property(p => p.Bust)
                .IsRequired()
                .HasColumnType("varchar(5)");

            builder.Property(p => p.Cup)
                .IsRequired()
                .HasColumnType("varchar(5)");

            builder.Property(p => p.AvailableTo)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.Property(p => p.BumpedAt)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.CreatedAt)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.UpdatedAt)
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(u => u.User)
                .WithOne(p => p.Post);
        }
    }
}