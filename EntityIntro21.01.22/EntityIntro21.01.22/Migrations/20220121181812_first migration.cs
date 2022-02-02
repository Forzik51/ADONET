using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityIntro21._01._22.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FootballTeam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Win = table.Column<short>(type: "smallint", nullable: true),
                    Loss = table.Column<short>(type: "smallint", nullable: true),
                    GoalsScored = table.Column<short>(type: "smallint", nullable: true),
                    GoalsConceded = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballTeam", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballTeam");
        }
    }
}
