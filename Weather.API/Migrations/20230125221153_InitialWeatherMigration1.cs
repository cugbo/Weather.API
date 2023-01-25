using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weather.API.Migrations
{
    public partial class InitialWeatherMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "194b1022-9378-4885-8a8c-7751560c0400", "88509e71-9b26-436c-a43b-d8bbef912e47", "Administrator", "ADMINISTRARTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c62d75ea-63e4-4fea-8bc0-f2fb88d68a65", "6639e95f-21a2-4dac-a251-858247a52d32", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "194b1022-9378-4885-8a8c-7751560c0400");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c62d75ea-63e4-4fea-8bc0-f2fb88d68a65");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e037fe6-034c-4811-8db1-22bb71f3b511", "c5b69bbc-08c8-4f2b-88b8-1a2147317291", "Administrator", "ADMINISTRARTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecf18233-cfbf-4403-9f0e-85b8d2e21c03", "7b0eae68-4415-4a43-a993-7f37be8089c7", "User", "USER" });
        }
    }
}
