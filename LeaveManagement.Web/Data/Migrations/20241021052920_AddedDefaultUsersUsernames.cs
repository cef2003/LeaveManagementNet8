using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersUsernames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f94d925-fa71-4291-83f0-229a6285bdba",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "60b57d7c-16f3-4f47-a9da-f77efe675c4b", true, "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFiX7vtH+o0UbUD4hmVIrGyaMaIixV7rB6S+J1Mje8ssPlZI7vk+v6rBAtKWEWFaYQ==", "e65e1888-463a-4cc5-8d62-282146ad52fe", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc2004a-f10a-2a2b-9caa-90699a155a70",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "981bbdd9-b181-4b4e-ba80-7ffa80100f97", true, "ADMIN@USER.COM", "AQAAAAIAAYagAAAAEGSogt26og78JILKsk+Khxc8Tc2zlCSUb5D8cRrNIwFwlruvnCmsdlhO1liNpoVb5Q==", "32270032-cf36-4441-bf9b-100e97afe5c5", "admin@user.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f94d925-fa71-4291-83f0-229a6285bdba",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d70ffa0a-d383-4f2a-b6c4-50530564ca22", false, null, "AQAAAAIAAYagAAAAENltfcOzI2UYQg91f9XPbZL0SXX6QGqRkYlQpAq/OIDdMgc4OdD3Z64l9AvuL1OUYw==", "0306348c-03ee-42b0-8f6c-febe8d6fb6e6", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc2004a-f10a-2a2b-9caa-90699a155a70",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8d98ddba-7abf-4765-9300-d4d4a181177e", false, null, "AQAAAAIAAYagAAAAEOzJ3+0SLTxqcn5Ekb5PAJuTc0Asxb/CSJ25jX+225fevBacpgcL6SUbD27Hrchcsw==", "58855eeb-ec79-48c2-aa97-310fce6257d0", null });
        }
    }
}
