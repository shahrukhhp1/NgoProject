using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetIdentityTest.Data.Migrations
{
    public partial class tableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Corporates_CorporateUserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_NGOs_NGOUserId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "NGOUserId",
                table: "AspNetUsers",
                newName: "NGOId");

            migrationBuilder.RenameColumn(
                name: "CorporateUserId",
                table: "AspNetUsers",
                newName: "CorporateId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_NGOUserId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_NGOId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CorporateUserId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_CorporateId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Corporates_CorporateId",
                table: "AspNetUsers",
                column: "CorporateId",
                principalTable: "Corporates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_NGOs_NGOId",
                table: "AspNetUsers",
                column: "NGOId",
                principalTable: "NGOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Corporates_CorporateId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_NGOs_NGOId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "NGOId",
                table: "AspNetUsers",
                newName: "NGOUserId");

            migrationBuilder.RenameColumn(
                name: "CorporateId",
                table: "AspNetUsers",
                newName: "CorporateUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_NGOId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_NGOUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CorporateId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_CorporateUserId");

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
    }
}
