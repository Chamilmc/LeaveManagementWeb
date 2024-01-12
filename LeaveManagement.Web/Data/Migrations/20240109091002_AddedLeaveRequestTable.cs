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
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e4f5a86-7188-4d0e-9b51-09e3a076fe6d", "AQAAAAIAAYagAAAAEEo+ytnWSIqtvZdxgputU5Oqs/n6FGyEdnLqvhvOChcNqXggGExY+MpY2DOZDe35Ig==", "043182de-f212-4e5c-895b-3072693f9e49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b3d42f6-efc1-42e8-9760-2d8424bb7807", "AQAAAAIAAYagAAAAEJzMAymco5EEaEcWLs2DR/duHwejn9wf64t0bZQLVykrXLMHsAdovhF/Hu/vSibtlA==", "86f6b22e-81ba-4680-9762-a8ad510948b6" });

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
    }
}
