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
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "329992f2-8336-4d98-a1b2-0a5eb489839a", null, "User", "USER" },
                    { "caabc169-3aa6-4b7e-a3f2-c20f8beef355", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "329992f2-8336-4d98-a1b2-0a5eb489839b", 0, "271659b2-6e40-4ed9-8495-cc0a690fecd8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEM7CWfL+6f871jgx2ypfSY4k926sg7Nvnwow0E2sT1vsEEYqHztubrhFtbX7Fy8fLQ==", null, false, "e01092ec-bd69-414b-8dd9-c97059bec4e0", null, false, null },
                    { "329992f2-8336-4d98-a1b2-0a5eb489839c", 0, "08e5a5e6-d2ed-4e27-946d-342a3dc19077", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "user", false, null, "USER@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEIj+57dNlJnpfDTPBjJymTYKlJwKMks0J4YvqMMiutNrlryWAFJbIvMbsO4X4a7fqQ==", null, false, "4fc35ce9-ba2d-487f-8f62-0a38f08d5cdc", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "caabc169-3aa6-4b7e-a3f2-c20f8beef355", "329992f2-8336-4d98-a1b2-0a5eb489839b" },
                    { "329992f2-8336-4d98-a1b2-0a5eb489839a", "329992f2-8336-4d98-a1b2-0a5eb489839c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "caabc169-3aa6-4b7e-a3f2-c20f8beef355", "329992f2-8336-4d98-a1b2-0a5eb489839b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "329992f2-8336-4d98-a1b2-0a5eb489839a", "329992f2-8336-4d98-a1b2-0a5eb489839c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caabc169-3aa6-4b7e-a3f2-c20f8beef355");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "329992f2-8336-4d98-a1b2-0a5eb489839c");
        }
    }
}
