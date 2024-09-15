using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalk.API.Migrations.NZWalksAuthDb
{
    /// <inheritdoc />
    public partial class SeedingidentityRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c687b387-5d97-4025-a359-51d49411da3b",
                column: "Name",
                value: "Writer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c687b387-5d97-4025-a359-51d49411da3b",
                column: "Name",
                value: "c687b387-5d97-4025-a359-51d49411da3b");
        }
    }
}
