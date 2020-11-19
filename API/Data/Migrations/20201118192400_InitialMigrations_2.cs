using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InitialMigrations_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.EnsureSchema(
                name: "Security");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "tbl_AppUser",
                newSchema: "Security");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_AppUser",
                schema: "Security",
                table: "tbl_AppUser",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_AppUser",
                schema: "Security",
                table: "tbl_AppUser");

            migrationBuilder.RenameTable(
                name: "tbl_AppUser",
                schema: "Security",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
