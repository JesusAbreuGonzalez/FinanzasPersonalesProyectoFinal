using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasPersonalesProyectoFinal.Migrations
{
    public partial class ModificandoEntidadPermisos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 24, 15, 3, 42, 782, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 24, 15, 3, 42, 783, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 24, 15, 3, 42, 783, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 24, 15, 3, 42, 783, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 24, 15, 3, 42, 783, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 24, 15, 3, 42, 783, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 24, 15, 3, 42, 785, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 24, 15, 3, 42, 785, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 24, 15, 3, 42, 785, DateTimeKind.Local).AddTicks(4194));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 23, 21, 18, 5, 310, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 23, 21, 18, 5, 311, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 23, 21, 18, 5, 311, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 23, 21, 18, 5, 311, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 23, 21, 18, 5, 311, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 23, 21, 18, 5, 311, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 23, 21, 18, 5, 312, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 23, 21, 18, 5, 312, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "PermisoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 3, 23, 21, 18, 5, 312, DateTimeKind.Local).AddTicks(9378));
        }
    }
}
