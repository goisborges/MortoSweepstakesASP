using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MortoSweepstakes.Data.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Team1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Team2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScoreTeam1 = table.Column<int>(type: "int", nullable: false),
                    ScoreTeam2 = table.Column<int>(type: "int", nullable: false),
                    MatchDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchId);
                });

            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    BetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BetTeam1 = table.Column<int>(type: "int", nullable: false),
                    BetTeam2 = table.Column<int>(type: "int", nullable: false),
                    BetPoints = table.Column<int>(type: "int", nullable: false),
                    BetDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.BetId);
                    table.ForeignKey(
                        name: "FK_Bets_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bets_MatchId",
                table: "Bets",
                column: "MatchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bets");

            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
