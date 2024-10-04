using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace b5.Model
{
    public partial class Studentdbcontent : DbContext
    {
        public Studentdbcontent()
            : base("name=Studentdbcontent")
        {
        }

        public virtual DbSet<faculty> faculties { get; set; }
        public virtual DbSet<student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<faculty>()
                .HasMany(e => e.students)
                .WithRequired(e => e.faculty)
                .WillCascadeOnDelete(false);
        }
    }
}
