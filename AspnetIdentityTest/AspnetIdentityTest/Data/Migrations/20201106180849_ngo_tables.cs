using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetIdentityTest.Data.Migrations
{
    public partial class ngo_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CEOName",
                table: "NGOs",
                newName: "Website");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NGOs",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonCellNumber",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonEmail",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonName",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonTelephoneNumber",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonTitle",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FBRCertificate",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FinancialTransparency",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FounderName",
                table: "NGOs",
                type: "varchar(250)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HowToDonate",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mission",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NumberOfEmployees",
                table: "NGOs",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "OfficeAddress",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PCFPCertificate",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "NGOs",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "NGOs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearFound",
                table: "NGOs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Theme",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ProvinceId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NGOProvinces",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProvinceId = table.Column<long>(nullable: true),
                    NGOId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NGOProvinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NGOProvinces_NGOs_NGOId",
                        column: x => x.NGOId,
                        principalTable: "NGOs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NGOProvinces_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NGOThemes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NGOId = table.Column<long>(nullable: true),
                    ThemeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NGOThemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NGOThemes_NGOs_NGOId",
                        column: x => x.NGOId,
                        principalTable: "NGOs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NGOThemes_Theme_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Theme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NGOCitys",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityId = table.Column<long>(nullable: true),
                    NGOId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NGOCitys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NGOCitys_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NGOCitys_NGOs_NGOId",
                        column: x => x.NGOId,
                        principalTable: "NGOs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceId",
                table: "Cities",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_NGOCitys_CityId",
                table: "NGOCitys",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_NGOCitys_NGOId",
                table: "NGOCitys",
                column: "NGOId");

            migrationBuilder.CreateIndex(
                name: "IX_NGOProvinces_NGOId",
                table: "NGOProvinces",
                column: "NGOId");

            migrationBuilder.CreateIndex(
                name: "IX_NGOProvinces_ProvinceId",
                table: "NGOProvinces",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_NGOThemes_NGOId",
                table: "NGOThemes",
                column: "NGOId");

            migrationBuilder.CreateIndex(
                name: "IX_NGOThemes_ThemeId",
                table: "NGOThemes",
                column: "ThemeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NGOCitys");

            migrationBuilder.DropTable(
                name: "NGOProvinces");

            migrationBuilder.DropTable(
                name: "NGOThemes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Theme");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropColumn(
                name: "ContactPersonCellNumber",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "ContactPersonEmail",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "ContactPersonName",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "ContactPersonTelephoneNumber",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "ContactPersonTitle",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "FBRCertificate",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "FinancialTransparency",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "FounderName",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "HowToDonate",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "Mission",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "NumberOfEmployees",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "OfficeAddress",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "PCFPCertificate",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "YearFound",
                table: "NGOs");

            migrationBuilder.RenameColumn(
                name: "Website",
                table: "NGOs",
                newName: "CEOName");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "NGOs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true);
        }
    }
}
