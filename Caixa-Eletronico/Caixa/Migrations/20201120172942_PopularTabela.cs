using Microsoft.EntityFrameworkCore.Migrations;

namespace Caixa_Eletronico.Migrations
{
    public partial class PopularTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cedulas(Valor,Quantidade) VALUES(100,10)");
            migrationBuilder.Sql("INSERT INTO Cedulas(Valor,Quantidade) VALUES(50,10)");
            migrationBuilder.Sql("INSERT INTO Cedulas(Valor,Quantidade) VALUES(20,10)");
            migrationBuilder.Sql("INSERT INTO Cedulas(Valor,Quantidade) VALUES(10,10)");
            migrationBuilder.Sql("INSERT INTO Cedulas(Valor,Quantidade) VALUES(5,10)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Cedulas");
          
        }
    }
}
