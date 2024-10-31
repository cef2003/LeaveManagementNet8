using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f94d925-fa71-4291-83f0-229a6285bdba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92309334-8966-4b4f-ad05-01d1e850b23c", "AQAAAAIAAYagAAAAECUCJH+WbofRX5jni9Pp60lzIgubawhYURaNp5rdoNIlLQRK17zf+vavXUfT0zZMgw==", "d12c12a4-307f-4a29-9851-b5348884f40f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc2004a-f10a-2a2b-9caa-90699a155a70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c19896b5-b146-4322-89e9-425bddb36ad9", "AQAAAAIAAYagAAAAEMqK3822cteLdBpequdEa1R8rFs7wweQ1OFKAUv1qGhRQPH5w9QQymMuWqylA7UIAg==", "c6187d19-516d-4b0c-8869-92dc4af37ec8" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
