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
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4198572a-1b9e-4dd2-818e-8c795c5b1617", "AQAAAAIAAYagAAAAEKsb8IOMWFVAznsUUB6NkSp14YHUU4F4IqLmrEccUPuTPd03HD1vDnzgfT3Sa4fP8g==", "ce9f0758-4b18-4c06-9e2f-d7ccd38fc87b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87499d3f-0987-4629-9ff5-07d80a995aa2", "AQAAAAIAAYagAAAAEP+eHSiJhEkTlDHhA80rgQ6KGMVivHsJ979efZ4EEfI5TgvuEak8psls/T5ATE0dnw==", "8c3d2776-9f72-406d-a7dd-4b4dea4aaa87" });
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
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bc52f58-ef1e-490b-b25b-d1a0ba152823", "AQAAAAIAAYagAAAAEL6cLM3YCSxuEZl9D3M1jjCM1uqYw56gWm4JmwqThyQsBs/pHR+75jtlqqzcrErk8Q==", "59b5be4f-4469-44b9-8cf7-1be82b249428" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6ce6f78-e353-453a-9b2d-e0a3b1901549", "AQAAAAIAAYagAAAAEGlGykTrf4n5PvkZH5JcMrNiSziR5Y5KwL7JJL1irIYARqY8FtJDAX2BibSx2p1+Aw==", "a1737528-9703-4e2d-8770-4c83f3e2df3c" });
        }
    }
}
