using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetIdentityTest.Data.Migrations
{
    public partial class ngo_update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "YearFound",
                table: "NGOs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearFound",
                table: "NGOs");
        }
    }
}
