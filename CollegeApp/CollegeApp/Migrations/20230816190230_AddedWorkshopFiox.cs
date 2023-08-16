using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedWorkshopFiox : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_Directors_DirectorId",
                table: "Workshop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workshop",
                table: "Workshop");

            migrationBuilder.RenameTable(
                name: "Workshop",
                newName: "Workshops");

            migrationBuilder.RenameIndex(
                name: "IX_Workshop_DirectorId",
                table: "Workshops",
                newName: "IX_Workshops_DirectorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workshops",
                table: "Workshops",
                column: "Section");

            migrationBuilder.AddForeignKey(
                name: "FK_Workshops_Directors_DirectorId",
                table: "Workshops",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workshops_Directors_DirectorId",
                table: "Workshops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workshops",
                table: "Workshops");

            migrationBuilder.RenameTable(
                name: "Workshops",
                newName: "Workshop");

            migrationBuilder.RenameIndex(
                name: "IX_Workshops_DirectorId",
                table: "Workshop",
                newName: "IX_Workshop_DirectorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workshop",
                table: "Workshop",
                column: "Section");

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_Directors_DirectorId",
                table: "Workshop",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
