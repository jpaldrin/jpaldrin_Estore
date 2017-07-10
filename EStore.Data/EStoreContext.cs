namespace EStore.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EStoreContext : DbContext
    {
        public EStoreContext()
            : base("name=EStoreContext")
        {
        }

        public virtual DbSet<CartLines> CartLines { get; set; }
        public virtual DbSet<DailySpecials> DailySpecials { get; set; }
        public virtual DbSet<Options> Options { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<TaxTables> TaxTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Options>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Options)
                .Map(m => m.ToTable("Product_Option").MapLeftKey("OptionID").MapRightKey("ProductId"));

            modelBuilder.Entity<TaxTables>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.TaxTables)
                .HasForeignKey(e => e.Taxed_TaxId);
        }
    }
}
