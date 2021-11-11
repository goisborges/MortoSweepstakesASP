using Microsoft.EntityFrameworkCore.Migrations;

namespace MortoSweepstakes.Data.Migrations
{
    public partial class TeamsIncluded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_MatchId",
                table: "Teams",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Matches_MatchId",
                table: "Teams",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "MatchId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Matches_MatchId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_MatchId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Teams");
        }
    }
}
