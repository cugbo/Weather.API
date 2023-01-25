using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weather.API.Migrations
{
    public partial class InitialWeatherMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c52f86df-b0ff-461d-9160-73bc2f6310b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51ebd93-d7ac-429e-babe-45632562b62d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e037fe6-034c-4811-8db1-22bb71f3b511", "c5b69bbc-08c8-4f2b-88b8-1a2147317291", "Administrator", "ADMINISTRARTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecf18233-cfbf-4403-9f0e-85b8d2e21c03", "7b0eae68-4415-4a43-a993-7f37be8089c7", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e037fe6-034c-4811-8db1-22bb71f3b511");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecf18233-cfbf-4403-9f0e-85b8d2e21c03");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c52f86df-b0ff-461d-9160-73bc2f6310b5", "c07c1c6f-e56b-40bc-a7b9-590661d1b179", "Administrator", "ADMINISTRARTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d51ebd93-d7ac-429e-babe-45632562b62d", "1f1bd9cf-bf22-44bf-b34c-f0afc1d5ae44", "User", "USER" });
        }
    }
}
