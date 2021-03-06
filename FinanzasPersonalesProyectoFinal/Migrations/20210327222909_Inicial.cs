using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanzasPersonalesProyectoFinal.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    PermisoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    VecesAsignado = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.PermisoId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    esActivo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Alias = table.Column<string>(type: "TEXT", nullable: true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false),
                    RolId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "RolesDetalle",
                columns: table => new
                {
                    RolDetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RolId = table.Column<int>(type: "INTEGER", nullable: false),
                    PermisoId = table.Column<int>(type: "INTEGER", nullable: false),
                    EsAsignado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesDetalle", x => x.RolDetalleId);
                    table.ForeignKey(
                        name: "FK_RolesDetalle_Permisos_PermisoId",
                        column: x => x.PermisoId,
                        principalTable: "Permisos",
                        principalColumn: "PermisoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolesDetalle_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreCategoria = table.Column<string>(type: "TEXT", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                    table.ForeignKey(
                        name: "FK_Categorias_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Presupuestos",
                columns: table => new
                {
                    PresupuestoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombrePresupuesto = table.Column<string>(type: "TEXT", nullable: true),
                    MontoPresupuesto = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presupuestos", x => x.PresupuestoId);
                    table.ForeignKey(
                        name: "FK_Presupuestos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gastos",
                columns: table => new
                {
                    GastoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescripcionGasto = table.Column<string>(type: "TEXT", nullable: true),
                    PresupuestoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => x.GastoId);
                    table.ForeignKey(
                        name: "FK_Gastos_Presupuestos_PresupuestoId",
                        column: x => x.PresupuestoId,
                        principalTable: "Presupuestos",
                        principalColumn: "PresupuestoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingresos",
                columns: table => new
                {
                    IngresoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PresupuestoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DescripcionIngreso = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingresos", x => x.IngresoId);
                    table.ForeignKey(
                        name: "FK_Ingresos_Presupuestos_PresupuestoId",
                        column: x => x.PresupuestoId,
                        principalTable: "Presupuestos",
                        principalColumn: "PresupuestoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GastosDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GastoId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaGasto = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MontoGasto = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastosDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_GastosDetalle_Gastos_GastoId",
                        column: x => x.GastoId,
                        principalTable: "Gastos",
                        principalColumn: "GastoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngresosDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IngresoId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MontoIngreso = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresosDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_IngresosDetalle_Ingresos_IngresoId",
                        column: x => x.IngresoId,
                        principalTable: "Ingresos",
                        principalColumn: "IngresoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "FechaCreacion", "NombreCategoria", "UsuarioId" },
                values: new object[] { 1, new DateTime(2021, 3, 27, 18, 29, 9, 292, DateTimeKind.Local).AddTicks(4608), "Alimentación", null });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "FechaCreacion", "NombreCategoria", "UsuarioId" },
                values: new object[] { 2, new DateTime(2021, 3, 27, 18, 29, 9, 294, DateTimeKind.Local).AddTicks(9269), "Educación", null });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "FechaCreacion", "NombreCategoria", "UsuarioId" },
                values: new object[] { 3, new DateTime(2021, 3, 27, 18, 29, 9, 294, DateTimeKind.Local).AddTicks(9315), "Entretenimiento", null });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "FechaCreacion", "NombreCategoria", "UsuarioId" },
                values: new object[] { 4, new DateTime(2021, 3, 27, 18, 29, 9, 294, DateTimeKind.Local).AddTicks(9321), "Pagos", null });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "FechaCreacion", "NombreCategoria", "UsuarioId" },
                values: new object[] { 5, new DateTime(2021, 3, 27, 18, 29, 9, 294, DateTimeKind.Local).AddTicks(9346), "Ropa", null });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "FechaCreacion", "NombreCategoria", "UsuarioId" },
                values: new object[] { 6, new DateTime(2021, 3, 27, 18, 29, 9, 294, DateTimeKind.Local).AddTicks(9349), "Vivienda", null });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "PermisoId", "Descripcion", "FechaCreacion", "VecesAsignado" },
                values: new object[] { 1, "Agrega o Modifica", new DateTime(2021, 3, 27, 18, 29, 9, 297, DateTimeKind.Local).AddTicks(6297), 0 });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "PermisoId", "Descripcion", "FechaCreacion", "VecesAsignado" },
                values: new object[] { 2, "Consulta", new DateTime(2021, 3, 27, 18, 29, 9, 297, DateTimeKind.Local).AddTicks(8922), 0 });

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "PermisoId", "Descripcion", "FechaCreacion", "VecesAsignado" },
                values: new object[] { 3, "Elimina", new DateTime(2021, 3, 27, 18, 29, 9, 297, DateTimeKind.Local).AddTicks(8935), 0 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolId", "Descripcion", "FechaCreacion", "esActivo" },
                values: new object[] { 1, "Registrador", new DateTime(2021, 3, 27, 18, 29, 9, 298, DateTimeKind.Local).AddTicks(4586), true });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Activo", "Alias", "Clave", "Email", "FechaIngreso", "Nombres", "RolId" },
                values: new object[] { 1, true, "", "4ee1d94f2cc476688105a776dcc6d36c32ad00aa68b901baeff71b115676f45d", "", new DateTime(2021, 3, 27, 18, 29, 9, 298, DateTimeKind.Local).AddTicks(9562), "Username", 0 });

            migrationBuilder.InsertData(
                table: "RolesDetalle",
                columns: new[] { "RolDetalleId", "EsAsignado", "PermisoId", "RolId" },
                values: new object[] { 1, true, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_UsuarioId",
                table: "Categorias",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_PresupuestoId",
                table: "Gastos",
                column: "PresupuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_GastosDetalle_GastoId",
                table: "GastosDetalle",
                column: "GastoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_PresupuestoId",
                table: "Ingresos",
                column: "PresupuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_IngresosDetalle_IngresoId",
                table: "IngresosDetalle",
                column: "IngresoId");

            migrationBuilder.CreateIndex(
                name: "IX_Presupuestos_CategoriaId",
                table: "Presupuestos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesDetalle_PermisoId",
                table: "RolesDetalle",
                column: "PermisoId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesDetalle_RolId",
                table: "RolesDetalle",
                column: "RolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastosDetalle");

            migrationBuilder.DropTable(
                name: "IngresosDetalle");

            migrationBuilder.DropTable(
                name: "RolesDetalle");

            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropTable(
                name: "Ingresos");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Presupuestos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
