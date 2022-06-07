using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddTurma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TurmaId",
                table: "Estudantes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudantes_TurmaId",
                table: "Estudantes",
                column: "TurmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudantes_Turmas_TurmaId",
                table: "Estudantes",
                column: "TurmaId",
                principalTable: "Turmas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudantes_Turmas_TurmaId",
                table: "Estudantes");

            migrationBuilder.DropTable(
                name: "Turmas");

            migrationBuilder.DropIndex(
                name: "IX_Estudantes_TurmaId",
                table: "Estudantes");

            migrationBuilder.DropColumn(
                name: "TurmaId",
                table: "Estudantes");
        }
    }
}
