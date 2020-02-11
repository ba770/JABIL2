namespace JABIL2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<fixture_define> fixture_define { get; set; }
        public virtual DbSet<fixture_entity> fixture_entity { get; set; }
        public virtual DbSet<inandoutrecords> inandoutrecords { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<fixture_define>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_define>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_define>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_define>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_define>()
                .Property(e => e.UsedFor)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_define>()
                .Property(e => e.Owner)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_define>()
                .Property(e => e.RecBy)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_define>()
                .Property(e => e.EditBy)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_define>()
                .Property(e => e.Workcell)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_entity>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_entity>()
                .Property(e => e.BillNo)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_entity>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<fixture_entity>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<inandoutrecords>()
                .Property(e => e.TakenBy)
                .IsUnicode(false);

            modelBuilder.Entity<inandoutrecords>()
                .Property(e => e.ProductLine)
                .IsUnicode(false);

            modelBuilder.Entity<inandoutrecords>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Privilege)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Tel)
                .IsUnicode(false);
        }
    }
}
