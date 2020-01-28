namespace WebApplication6
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

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Table>()
                .Property(e => e.Mama)
                .IsFixedLength();

            modelBuilder.Entity<Table>()
                .Property(e => e.Papa)
                .IsFixedLength();
        }
    }
}
