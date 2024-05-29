using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingInstances : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Electronics", "Latest iPhone model", "Apple iPhone 14", 999.00m },
                    { 2, "Sports", "High-performance basketball shoes", "Nike Air Jordan", 180.00m },
                    { 3, "Electronics", "High-definition TV with 4K resolution", "Samsung 4K TV", 1299.00m },
                    { 4, "Clothing", "Classic denim jeans", "Levi's Jeans", 60.00m },
                    { 5, "Electronics", "Professional-grade digital camera", "Canon EOS Camera", 899.00m },
                    { 6, "Sports", "Classic basketball shoes", "Adidas Superstar Shoes", 80.00m },
                    { 7, "Electronics", "Next-generation gaming console", "Sony PlayStation 5", 499.00m },
                    { 8, "Clothing", "High-quality cotton T-shirt", "Calvin Klein T-Shirt", 20.00m },
                    { 9, "Electronics", "High-performance laptop for business", "Dell Laptop", 799.00m },
                    { 10, "Sports", "High-performance cross-training shoes", "Reebok CrossFit Shoes", 120.00m },
                    { 11, "Home Appliances", "High-capacity refrigerator with advanced features", "LG Refrigerator", 2499.00m },
                    { 12, "Clothing", "High-quality athletic hoodie", "Under Armour Hoodie", 40.00m },
                    { 13, "Software", "Productivity software suite", "Microsoft Office Software", 149.00m },
                    { 14, "Electronics", "High-quality wireless headphones", "Bose Headphones", 299.00m },
                    { 15, "Sports", "High-performance soccer cleats", "Puma Soccer Cleats", 150.00m },
                    { 16, "Home Appliances", "High-capacity washing machine with advanced features", "Whirlpool Washing Machine", 999.00m },
                    { 17, "Accessories", "High-quality sunglasses with polarized lenses", "Ray-Ban Sunglasses", 180.00m },
                    { 18, "Electronics", "High-quality inkjet printer for home use", "HP Printer", 99.00m },
                    { 19, "Clothing", "High-quality waterproof jacket for outdoor activities", "The North Face Jacket", 120.00m },
                    { 20, "Electronics", "High-performance smartwatch with fitness tracking features", "Fitbit Smartwatch", 249.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
