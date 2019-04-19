using Microsoft.EntityFrameworkCore.Migrations;

namespace MafiaFlix.Migrations
{
    public partial class MafiaFlixModelsMafiaFlixContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Cover", "Description", "Direction", "Duration", "Name", "ReleaseYear" },
                values: new object[] { 1L, "godfather", "A saga conta a história de uma família mafiosa que luta para estabelecer sua supremacia na América depois da Segunda Guerra. Uma tentativa de assassinato deixa Vito Corleone incapacitado e força os filhos Michael e Sonny a assumirem os negócios.", "Francis Ford Coppola", 175, "The Godfather", 1972 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Cover", "Description", "Direction", "Duration", "Name", "ReleaseYear" },
                values: new object[] { 2L, "bonnie-clyde", "Bonnie Parker se apaixona por um ex-presidiário, Clyde Barrow e decide acompanhá-lo. Juntos, iniciam uma carreira de crimes roubando carros e assaltando bancos até serem perseguidos pela polícia por todo o país.", "Arthur Penn", 112, "Bonnie & Clyde", 1967 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2L);
        }
    }
}
