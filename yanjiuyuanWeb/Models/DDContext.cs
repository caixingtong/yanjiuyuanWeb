namespace yanjiuyuanWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DDContext : DbContext
    {
        public DDContext()
            : base("name=DDContext")
        {
        }

        public virtual DbSet<LeaveWord> LeaveWord { get; set; }
        public virtual DbSet<NewsAndCases> NewsAndCases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LeaveWord>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveWord>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveWord>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveWord>()
                .Property(e => e.CreateTime)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.Contents)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.CreateTime)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.BigType)
                .IsUnicode(false);

            modelBuilder.Entity<NewsAndCases>()
                .Property(e => e.Abstract)
                .IsUnicode(false);
        }
    }
}
