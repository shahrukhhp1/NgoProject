using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetIdentityTest.Data.Migrations
{
    public partial class user_corporate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CEOName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NGO_IntId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NGO_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NGO_UserType",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<long>(
                name: "CorporateUserId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NGOUserId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Corporates",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NGOs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CEOName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NGOs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CorporateUserId",
                table: "AspNetUsers",
                column: "CorporateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NGOUserId",
                table: "AspNetUsers",
                column: "NGOUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Corporates_CorporateUserId",
                table: "AspNetUsers",
                column: "CorporateUserId",
                principalTable: "Corporates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_NGOs_NGOUserId",
                table: "AspNetUsers",
                column: "NGOUserId",
                principalTable: "NGOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Corporates_CorporateUserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_NGOs_NGOUserId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Corporates");

            migrationBuilder.DropTable(
                name: "NGOs");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CorporateUserId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NGOUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CorporateUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NGOUserId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CEOName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NGO_IntId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NGO_Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NGO_UserType",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
