using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetIdentityTest.Data.Migrations
{
    public partial class theme_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NGOThemes_Theme_ThemeId",
                table: "NGOThemes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Theme",
                table: "Theme");

            migrationBuilder.RenameTable(
                name: "Theme",
                newName: "Themes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Themes",
                table: "Themes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NGOThemes_Themes_ThemeId",
                table: "NGOThemes",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NGOThemes_Themes_ThemeId",
                table: "NGOThemes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Themes",
                table: "Themes");

            migrationBuilder.RenameTable(
                name: "Themes",
                newName: "Theme");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Theme",
                table: "Theme",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NGOThemes_Theme_ThemeId",
                table: "NGOThemes",
                column: "ThemeId",
                principalTable: "Theme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
