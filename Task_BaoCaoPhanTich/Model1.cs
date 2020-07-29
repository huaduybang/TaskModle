namespace Task_BaoCaoPhanTich
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelEntity")
        {
           
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.img1)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.img2)
                .IsUnicode(false);
        }
    }
}
