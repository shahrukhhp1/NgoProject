using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetIdentityTest.Data.Migrations
{
    public partial class ngo_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearFound",
                table: "NGOs");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonTelephoneNumber",
                table: "NGOs",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonEmail",
                table: "NGOs",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonCellNumber",
                table: "NGOs",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fax",
                table: "NGOs",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "NGOs",
                type: "varchar(50)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fax",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "NGOs");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonTelephoneNumber",
                table: "NGOs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonEmail",
                table: "NGOs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonCellNumber",
                table: "NGOs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearFound",
                table: "NGOs",
                nullable: false,
                defaultValue: 0);
        }
    }
}
