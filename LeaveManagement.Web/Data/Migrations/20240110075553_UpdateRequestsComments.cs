using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRequestsComments : Migration
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
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "327e0a3b-8d29-44de-bbc0-3f18b56e7eed", "AQAAAAIAAYagAAAAEEWhNAA1hEpb7XCkG/XWWgzmqwMneb0gE1EVbWndChkwyTCv/LumAc+io95GwCThSA==", "9eb7e1b8-775c-46c2-a7bf-6ae695fcd483" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba286816-c6c2-4398-a8ed-5cfcfd982fe7", "AQAAAAIAAYagAAAAEOnBUVrWy61W3YXamxIBGGcoPSP0Qty32txZ8WL22EcrHcfI84LirxMSpYFTkpxVMQ==", "6ca0c956-62b3-40f1-a5d6-e26c98b4bb19" });
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
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e4f5a86-7188-4d0e-9b51-09e3a076fe6d", "AQAAAAIAAYagAAAAEEo+ytnWSIqtvZdxgputU5Oqs/n6FGyEdnLqvhvOChcNqXggGExY+MpY2DOZDe35Ig==", "043182de-f212-4e5c-895b-3072693f9e49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b3d42f6-efc1-42e8-9760-2d8424bb7807", "AQAAAAIAAYagAAAAEJzMAymco5EEaEcWLs2DR/duHwejn9wf64t0bZQLVykrXLMHsAdovhF/Hu/vSibtlA==", "86f6b22e-81ba-4680-9762-a8ad510948b6" });
        }
    }
}
