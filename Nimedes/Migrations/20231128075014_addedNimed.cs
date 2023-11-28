using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nimedes.Migrations
{
    /// <inheritdoc />
    public partial class addedNimed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nimed",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sugu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emakeelne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voorkeelne = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nimed", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nimed");
        }
    }
}
