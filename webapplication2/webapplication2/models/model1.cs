using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Admin_Name)
                .IsFixedLength();

            modelBuilder.Entity<Admin>()
                .Property(e => e.Admin_Email)
                .IsFixedLength();

            modelBuilder.Entity<Admin>()
                .Property(e => e.Admin_address)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.cat_name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_salePrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_purchasePrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Pic)
                .IsFixedLength();
        }
    }
}
