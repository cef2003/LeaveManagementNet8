using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedUserRolesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cef2003b-f10a-2024-9caa-90699a155a70", "abc2004a-f10a-2a2b-9caa-90699a155a70" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cff2013b-f10a-2024-9cfa-90699a155b70", "abc2004a-f10a-2a2b-9caa-90699a155a70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f94d925-fa71-4291-83f0-229a6285bdba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4967ba9-b144-4377-8048-a1c6ae88fda0", "AQAAAAIAAYagAAAAEM3qKEXDtmq6uGqWoj/5FCXjpcIdZaY4kKIVxz+GCZSSlJ4srIkYwmWNF7ck/dQxEA==", "ec80f557-f8d8-42a9-b3ae-3798c7940373" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc2004a-f10a-2a2b-9caa-90699a155a70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9af4a09a-f265-4c38-bd04-d5d040645bac", "AQAAAAIAAYagAAAAEH3Bpt2YLNuaooqWXGITdSlBosP8vlYNIm1C3cv7bjlQEs+m/Bhx3DfSdEVr+BKttA==", "5203e312-bdc5-4e13-8723-cbcf56d23a52" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cff2013b-f10a-2024-9cfa-90699a155b70", "abc2004a-f10a-2a2b-9caa-90699a155a70" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cef2003b-f10a-2024-9caa-90699a155a70", "abc2004a-f10a-2a2b-9caa-90699a155a70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f94d925-fa71-4291-83f0-229a6285bdba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60b57d7c-16f3-4f47-a9da-f77efe675c4b", "AQAAAAIAAYagAAAAEFiX7vtH+o0UbUD4hmVIrGyaMaIixV7rB6S+J1Mje8ssPlZI7vk+v6rBAtKWEWFaYQ==", "e65e1888-463a-4cc5-8d62-282146ad52fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc2004a-f10a-2a2b-9caa-90699a155a70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "981bbdd9-b181-4b4e-ba80-7ffa80100f97", "AQAAAAIAAYagAAAAEGSogt26og78JILKsk+Khxc8Tc2zlCSUb5D8cRrNIwFwlruvnCmsdlhO1liNpoVb5Q==", "32270032-cf36-4441-bf9b-100e97afe5c5" });
        }
    }
}
