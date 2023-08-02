using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmesApi.Migrations
{
    public partial class RecreateCinemaEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Cinemas_CinemaId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_CinemaId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Enderecos");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Cinemas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_EnderecoId",
                table: "Cinemas",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Enderecos_EnderecoId",
                table: "Cinemas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Enderecos_EnderecoId",
                table: "Cinemas");

            migrationBuilder.DropIndex(
                name: "IX_Cinemas_EnderecoId",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Cinemas");

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Enderecos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_CinemaId",
                table: "Enderecos",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Cinemas_CinemaId",
                table: "Enderecos",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
