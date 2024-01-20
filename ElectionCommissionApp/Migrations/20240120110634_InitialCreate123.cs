using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectionCommissionApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voters_State_State",
                table: "Voters");

            migrationBuilder.DropIndex(
                name: "IX_Voters_State",
                table: "Voters");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Voters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Voters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Voters_State",
                table: "Voters",
                column: "State");

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_State_State",
                table: "Voters",
                column: "State",
                principalTable: "State",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
