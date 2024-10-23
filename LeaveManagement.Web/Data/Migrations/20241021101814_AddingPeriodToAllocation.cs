using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f94d925-fa71-4291-83f0-229a6285bdba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "377a1358-4f0e-4622-895c-02345de92938", "AQAAAAIAAYagAAAAEGVnDtW752tzjSGG7kh4Blb8LQT90ojsm/+Q4LklVzu++6VUKszPuC3Ml9uzQw0tsA==", "4f89b1a8-dac7-42c4-b2ed-f7de3ab6a7f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc2004a-f10a-2a2b-9caa-90699a155a70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f5c7c53-845c-4609-9bbd-18844eea4f76", "AQAAAAIAAYagAAAAEGubbuz2RbW++qIfWxxRwrfp6LjSXeEOBVg3lqq8lrood5WmdIR9MlHvGdRa4lUL4A==", "2e33ed52-17f1-4d5c-b369-2b31daeda651" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
    }
}
