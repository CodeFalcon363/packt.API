using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace packt.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bdfd87c-5b8a-4360-9024-5db21e492195");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39a9f146-bf22-46f5-a14e-14a702f94b0e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "411efdff-1929-4d3b-89c9-997395383882", null, "Administrator", "ADMINISTRATOR" },
                    { "96e4f784-cf2d-4b42-8848-fa41ad85475e", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "411efdff-1929-4d3b-89c9-997395383882");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96e4f784-cf2d-4b42-8848-fa41ad85475e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2bdfd87c-5b8a-4360-9024-5db21e492195", null, "Adminiistrator", "ADMINISTRATOR" },
                    { "39a9f146-bf22-46f5-a14e-14a702f94b0e", null, "User", "USER" }
                });
        }
    }
}
