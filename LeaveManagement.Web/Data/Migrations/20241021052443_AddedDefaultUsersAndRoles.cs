using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cef2003b-f10a-2024-9caa-90699a155a70", null, "Administrator", "ADMINISTRATOR" },
                    { "cff2013b-f10a-2024-9cfa-90699a155b70", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f94d925-fa71-4291-83f0-229a6285bdba", 0, "d70ffa0a-d383-4f2a-b6c4-50530564ca22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System2", "Admin2", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAENltfcOzI2UYQg91f9XPbZL0SXX6QGqRkYlQpAq/OIDdMgc4OdD3Z64l9AvuL1OUYw==", null, false, "0306348c-03ee-42b0-8f6c-febe8d6fb6e6", null, false, null },
                    { "abc2004a-f10a-2a2b-9caa-90699a155a70", 0, "8d98ddba-7abf-4765-9300-d4d4a181177e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@user.com", false, "System", "Admin", false, null, "ADMIN@USER.COM", null, "AQAAAAIAAYagAAAAEOzJ3+0SLTxqcn5Ekb5PAJuTc0Asxb/CSJ25jX+225fevBacpgcL6SUbD27Hrchcsw==", null, false, "58855eeb-ec79-48c2-aa97-310fce6257d0", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cef2003b-f10a-2024-9caa-90699a155a70", "3f94d925-fa71-4291-83f0-229a6285bdba" },
                    { "cef2003b-f10a-2024-9caa-90699a155a70", "abc2004a-f10a-2a2b-9caa-90699a155a70" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cff2013b-f10a-2024-9cfa-90699a155b70");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cef2003b-f10a-2024-9caa-90699a155a70", "3f94d925-fa71-4291-83f0-229a6285bdba" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cef2003b-f10a-2024-9caa-90699a155a70", "abc2004a-f10a-2a2b-9caa-90699a155a70" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cef2003b-f10a-2024-9caa-90699a155a70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f94d925-fa71-4291-83f0-229a6285bdba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc2004a-f10a-2a2b-9caa-90699a155a70");

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
