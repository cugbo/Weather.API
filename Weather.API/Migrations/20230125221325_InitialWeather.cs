using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weather.API.Migrations
{
    public partial class InitialWeather : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "0ac93fb2-e4c5-4492-8eda-040ea74c08dd", "76645f4b-ff10-4f48-b88e-a0a3d837b1f6", "Administrator", "ADMINISTRARTOR" },
                    { "1d1c345c-d326-43f4-9837-95fb300bc108", "61af9483-f1bb-4799-9ece-fc8bfee48edf", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 25, 23, 13, 24, 964, DateTimeKind.Local).AddTicks(9057), "Cool", 24 },
                    { 2, new DateTime(2023, 1, 25, 23, 13, 24, 964, DateTimeKind.Local).AddTicks(9087), "Hot", 22 },
                    { 3, new DateTime(2023, 1, 25, 23, 13, 24, 964, DateTimeKind.Local).AddTicks(9090), "Warm", 34 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ac93fb2-e4c5-4492-8eda-040ea74c08dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d1c345c-d326-43f4-9837-95fb300bc108");

            migrationBuilder.DeleteData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weathers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "194b1022-9378-4885-8a8c-7751560c0400", "88509e71-9b26-436c-a43b-d8bbef912e47", "Administrator", "ADMINISTRARTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c62d75ea-63e4-4fea-8bc0-f2fb88d68a65", "6639e95f-21a2-4dac-a251-858247a52d32", "User", "USER" });
        }
    }
}
