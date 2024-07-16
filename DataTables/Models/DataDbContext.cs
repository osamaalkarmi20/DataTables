using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace DataTables.Models
{

    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }

      
            // Seed data for Customers
                 protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1, CompanyName = "Company A", ContactName = "John Doe", ContactTitle = "Manager", Address = "123 Main St", City = "Anytown", Region = "State A", PostalCode = "12345", Country = "USA", Phone = "555-1234", Fax = "555-5678" },
                new Customer { CustomerID = 2, CompanyName = "Company B", ContactName = "Jane Smith", ContactTitle = "CEO", Address = "456 Oak St", City = "Othertown", Region = "State B", PostalCode = "23456", Country = "USA", Phone = "555-2345", Fax = "555-6789" },
                new Customer { CustomerID = 3, CompanyName = "Company C", ContactName = "Jim Brown", ContactTitle = "Director", Address = "789 Pine St", City = "Sometown", Region = "State C", PostalCode = "34567", Country = "USA", Phone = "555-3456", Fax = "555-7890" },
                new Customer { CustomerID = 4, CompanyName = "Company D", ContactName = "Sara White", ContactTitle = "CFO", Address = "101 Maple St", City = "Anycity", Region = "State D", PostalCode = "45678", Country = "USA", Phone = "555-4567", Fax = "555-8901" },
                new Customer { CustomerID = 5, CompanyName = "Company E", ContactName = "Mike Green", ContactTitle = "CTO", Address = "202 Elm St", City = "Newtown", Region = "State E", PostalCode = "56789", Country = "USA", Phone = "555-5678", Fax = "555-9012" },
                new Customer { CustomerID = 6, CompanyName = "Company F", ContactName = "Lucy Blue", ContactTitle = "COO", Address = "303 Birch St", City = "Oldtown", Region = "State F", PostalCode = "67890", Country = "USA", Phone = "555-6789", Fax = "555-0123" },
                new Customer { CustomerID = 7, CompanyName = "Company G", ContactName = "Tom Black", ContactTitle = "President", Address = "404 Cedar St", City = "Smalltown", Region = "State G", PostalCode = "78901", Country = "USA", Phone = "555-7890", Fax = "555-1234" },
                new Customer { CustomerID = 8, CompanyName = "Company H", ContactName = "Kate Red", ContactTitle = "Vice President", Address = "505 Cherry St", City = "Bigcity", Region = "State H", PostalCode = "89012", Country = "USA", Phone = "555-8901", Fax = "555-2345" },
                new Customer { CustomerID = 9, CompanyName = "Company I", ContactName = "Paul Yellow", ContactTitle = "Executive", Address = "606 Walnut St", City = "Capitown", Region = "State I", PostalCode = "90123", Country = "USA", Phone = "555-9012", Fax = "555-3456" },
                new Customer { CustomerID = 10, CompanyName = "Company J", ContactName = "Mary Purple", ContactTitle = "Administrator", Address = "707 Hickory St", City = "Hilltown", Region = "State J", PostalCode = "01234", Country = "USA", Phone = "555-0123", Fax = "555-4567" }
            );
        }

    }
}


