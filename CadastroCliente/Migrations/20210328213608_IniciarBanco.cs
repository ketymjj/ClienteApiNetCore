using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroCliente.Migrations
{
    public partial class IniciarBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientesWeb",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(maxLength: 2, nullable: false),
                    Logradouro = table.Column<string>(nullable: false),
                    Nacionalidade = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: false),
                    Sobrenome = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesWeb", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesWeb");
        }
    }
}
