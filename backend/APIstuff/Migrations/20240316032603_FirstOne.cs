using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIstuff.Migrations
{
    /// <inheritdoc />
    public partial class FirstOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bowlers",
                columns: table => new
                {
                    BowlerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BowlerLastName = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerMiddleInit = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerAddress = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerCity = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerState = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerZip = table.Column<string>(type: "TEXT", nullable: true),
                    BowlerPhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    TeamID = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bowlers", x => x.BowlerID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bowlers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
