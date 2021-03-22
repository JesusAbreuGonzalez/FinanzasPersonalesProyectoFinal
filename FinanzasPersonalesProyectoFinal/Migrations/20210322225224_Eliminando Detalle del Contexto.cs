using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasPersonalesProyectoFinal.Migrations
{
    public partial class EliminandoDetalledelContexto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 22, 18, 52, 23, 66, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 22, 18, 52, 23, 68, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 22, 18, 52, 23, 68, DateTimeKind.Local).AddTicks(378));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 22, 18, 3, 2, 949, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 22, 18, 3, 2, 952, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 22, 18, 3, 2, 952, DateTimeKind.Local).AddTicks(1725));
        }
    }
}
