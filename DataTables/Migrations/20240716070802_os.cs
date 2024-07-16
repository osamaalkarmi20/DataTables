using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataTables.Migrations
{
    /// <inheritdoc />
    public partial class os : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerID", "Address", "City", "CompanyName", "ContactName", "ContactTitle", "Country", "Fax", "Phone", "PostalCode", "Region" },
                values: new object[,]
                {
                    { 1, "123 Main St", "Anytown", "Company A", "John Doe", "Manager", "USA", "555-5678", "555-1234", "12345", "State A" },
                    { 2, "456 Oak St", "Othertown", "Company B", "Jane Smith", "CEO", "USA", "555-6789", "555-2345", "23456", "State B" },
                    { 3, "789 Pine St", "Sometown", "Company C", "Jim Brown", "Director", "USA", "555-7890", "555-3456", "34567", "State C" },
                    { 4, "101 Maple St", "Anycity", "Company D", "Sara White", "CFO", "USA", "555-8901", "555-4567", "45678", "State D" },
                    { 5, "202 Elm St", "Newtown", "Company E", "Mike Green", "CTO", "USA", "555-9012", "555-5678", "56789", "State E" },
                    { 6, "303 Birch St", "Oldtown", "Company F", "Lucy Blue", "COO", "USA", "555-0123", "555-6789", "67890", "State F" },
                    { 7, "404 Cedar St", "Smalltown", "Company G", "Tom Black", "President", "USA", "555-1234", "555-7890", "78901", "State G" },
                    { 8, "505 Cherry St", "Bigcity", "Company H", "Kate Red", "Vice President", "USA", "555-2345", "555-8901", "89012", "State H" },
                    { 9, "606 Walnut St", "Capitown", "Company I", "Paul Yellow", "Executive", "USA", "555-3456", "555-9012", "90123", "State I" },
                    { 10, "707 Hickory St", "Hilltown", "Company J", "Mary Purple", "Administrator", "USA", "555-4567", "555-0123", "01234", "State J" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
