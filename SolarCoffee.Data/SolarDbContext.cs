using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolarCoffee.Data.Models;

namespace SolarCoffee.Data {
    public class SolarDbContext : IdentityDbContext {
        public SolarDbContext() { }

        public SolarDbContext(DbContextOptions options) : base(options) { }
        
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductInventory> ProductInventories { get; set; }
        public virtual DbSet<ProductInventorySnapshot> ProductInventorySnapshots { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<SalesOrderItem> SalesOrderItems { get; set; }
    }
}

/*
 * 1.) In order to perform a DB migration you must install the following Packages:
 *          Microsoft.EntityFrameworkCore
 *          Microsoft.EntityFrameworkCore.Tools
 * 2.) Open the terminal, be in the SolarCoffee.Web project and run the following commands:
 *          dotnet tool install --global dotnet-ef (if dotnet-ef is not already installed)
 *          dotnet ef --startup-project ../SolarCoffee.Web migrations add InitialMigration
 *          dotnet ef --startup-project ../SolarCoffee.Web database update
*/