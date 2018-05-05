using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Sansagol.CyberFox.CyberFoxApi.Models
{
    public partial class CyberFox_DevContext : DbContext
    {
        public virtual DbSet<SnGroup> SnGroup { get; set; }
        public virtual DbSet<SnUser> SnUser { get; set; }
        public virtual DbSet<SocialNetwork> SocialNetwork { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SnGroup>(entity =>
            {
                entity.HasKey(e => e.IdSnGroup);

                entity.ToTable("Sn_Group");

                entity.HasIndex(e => e.IdSocialNetwork)
                    .HasName("IXFK_Sn_Group_Social_Network");

                entity.Property(e => e.IdSnGroup).HasColumnName("Id_Sn_Group");

                entity.Property(e => e.IdSocialNetwork).HasColumnName("Id_Social_Network");

                entity.Property(e => e.Name).HasMaxLength(512);

                entity.Property(e => e.SnGroupId)
                    .IsRequired()
                    .HasColumnName("Sn_Group_Id")
                    .HasMaxLength(256);

                entity.HasOne(d => d.IdSocialNetworkNavigation)
                    .WithMany(p => p.SnGroup)
                    .HasForeignKey(d => d.IdSocialNetwork)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sn_Group_Social_Network");
            });

            modelBuilder.Entity<SnUser>(entity =>
            {
                entity.HasKey(e => e.IdSnUser);

                entity.ToTable("Sn_User");

                entity.HasIndex(e => e.IdSocialNetwork)
                    .HasName("IXFK_Sn_User_Social_Network");

                entity.Property(e => e.IdSnUser).HasColumnName("Id_Sn_User");

                entity.Property(e => e.IdSocialNetwork)
                    .HasColumnName("Id_Social_Network")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.SnUserId)
                    .IsRequired()
                    .HasColumnName("Sn_User_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(256);

                entity.HasOne(d => d.IdSocialNetworkNavigation)
                    .WithMany(p => p.SnUser)
                    .HasForeignKey(d => d.IdSocialNetwork)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sn_User_Social_Network");
            });

            modelBuilder.Entity<SocialNetwork>(entity =>
            {
                entity.HasKey(e => e.IdSocialNetwork);

                entity.ToTable("Social_Network");

                entity.Property(e => e.IdSocialNetwork)
                    .HasColumnName("Id_Social_Network")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.TargetSite)
                    .IsRequired()
                    .HasColumnName("Target_Site")
                    .HasMaxLength(256);
            });
        }
    }
}
