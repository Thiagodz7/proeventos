using Microsoft.EntityFrameworkCore.Migrations;

namespace ProEventos.API.Data.Migrations
{
    public partial class Criaçãoinicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    eventoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataEvento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qtdPessoas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagemUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.eventoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
