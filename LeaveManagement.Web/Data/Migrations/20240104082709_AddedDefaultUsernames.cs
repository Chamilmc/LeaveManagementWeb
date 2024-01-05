using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsernames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6bc52f58-ef1e-490b-b25b-d1a0ba152823", true, "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEL6cLM3YCSxuEZl9D3M1jjCM1uqYw56gWm4JmwqThyQsBs/pHR+75jtlqqzcrErk8Q==", "59b5be4f-4469-44b9-8cf7-1be82b249428", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c6ce6f78-e353-453a-9b2d-e0a3b1901549", true, "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGlGykTrf4n5PvkZH5JcMrNiSziR5Y5KwL7JJL1irIYARqY8FtJDAX2BibSx2p1+Aw==", "a1737528-9703-4e2d-8770-4c83f3e2df3c", "user@localhost.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "271659b2-6e40-4ed9-8495-cc0a690fecd8", false, null, "AQAAAAIAAYagAAAAEM7CWfL+6f871jgx2ypfSY4k926sg7Nvnwow0E2sT1vsEEYqHztubrhFtbX7Fy8fLQ==", "e01092ec-bd69-414b-8dd9-c97059bec4e0", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "08e5a5e6-d2ed-4e27-946d-342a3dc19077", false, null, "AQAAAAIAAYagAAAAEIj+57dNlJnpfDTPBjJymTYKlJwKMks0J4YvqMMiutNrlryWAFJbIvMbsO4X4a7fqQ==", "4fc35ce9-ba2d-487f-8f62-0a38f08d5cdc", null });
        }
    }
}
