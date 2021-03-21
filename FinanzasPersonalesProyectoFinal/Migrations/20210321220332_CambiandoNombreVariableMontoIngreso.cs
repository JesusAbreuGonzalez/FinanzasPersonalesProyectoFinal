using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasPersonalesProyectoFinal.Migrations
{
    public partial class CambiandoNombreVariableMontoIngreso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MontoIgreso",
                table: "IngresosDetalle",
                newName: "MontoIngreso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MontoIngreso",
                table: "IngresosDetalle",
                newName: "MontoIgreso");
        }
    }
}
