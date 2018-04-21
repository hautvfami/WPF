namespace Models.EF
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

        public virtual DbSet<BOOK> BOOKS { get; set; }
        public virtual DbSet<USER> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USER>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);
        }
    }
}
