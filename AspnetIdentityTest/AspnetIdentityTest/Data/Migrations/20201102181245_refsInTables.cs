using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetIdentityTest.Data.Migrations
{
    public partial class refsInTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLocked",
                table: "Surveys",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLocked",
                table: "Surveys");
        }
    }
}
