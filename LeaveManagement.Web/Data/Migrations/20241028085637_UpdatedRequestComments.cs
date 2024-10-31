using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f94d925-fa71-4291-83f0-229a6285bdba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e22223d1-8b5f-46db-9d74-2f1c6990f909", "AQAAAAIAAYagAAAAEBUK4eLKNM9MSoQurW3VfGnI7cPxyU09CWoOQeTNeoCu3vyiNK0MrssA3BwGnzbs7Q==", "9dbcc23b-67c1-414c-9b9b-67f1a119cc84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc2004a-f10a-2a2b-9caa-90699a155a70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de5c5235-3da1-4892-80e6-5d0590b68ad8", "AQAAAAIAAYagAAAAEEvTUIEajtwa5ihB/VaY6bUIy/NPWCEqFOa9DdWVQn5ZKpss1OgZSLxBpL2ZEy3WNg==", "b589f04d-553e-415c-b26f-31cadfdee200" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
