namespace ConsignmentShopUI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using ConsignmentShopLibrary;

    public partial class InventoryDataContext : DbContext
    {
        public InventoryDataContext()
            : base("name=InventoryDataContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<InventoryTestTableAndrew> InventoryTestTableAndrews { get; set; }
        public virtual DbSet<TestTable> TestTables { get; set; }

        public virtual DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
