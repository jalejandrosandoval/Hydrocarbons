using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_REST.Migrations
{
    public partial class IM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Line_Hydrocarbons",
                columns: table => new
                {
                    Id_LineHydrocarbon = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Line = table.Column<string>(nullable: false),
                    Length_Line = table.Column<decimal>(nullable: false),
                    Diameter_Line = table.Column<decimal>(nullable: false),
                    InstalationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Line_Hydrocarbons", x => x.Id_LineHydrocarbon);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Line_Hydrocarbons");
        }
    }
}
