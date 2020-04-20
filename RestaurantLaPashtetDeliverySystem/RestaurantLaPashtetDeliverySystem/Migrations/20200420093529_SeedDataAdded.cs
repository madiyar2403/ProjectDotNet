using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantLaPashtetDeliverySystem.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5,
                column: "ShortDescription",
                value: "Chicken Caesar Salads are perfect for packing for lunch or enjoying as a light dinner");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5,
                column: "ShortDescription",
                value: "Chicken Caesar Salads are perfect for packing for lunch or enjoying as a light dinner, especially when topped with this creamy, homemade Caesar dressing");
        }
    }
}
