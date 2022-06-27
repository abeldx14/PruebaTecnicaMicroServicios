using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaTecnicaMicroServicios.Migrations
{
    public partial class InicioEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    identificacion = table.Column<int>(type: "int", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    clienteid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeronsaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.clienteid);
                    table.ForeignKey(
                        name: "FK_Clientes_Personas_PeronsaId",
                        column: x => x.PeronsaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroCuenta = table.Column<int>(type: "int", nullable: false),
                    tipoCuenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    saldoInicial = table.Column<double>(type: "float", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clientesclienteid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cuentas_Clientes_Clientesclienteid",
                        column: x => x.Clientesclienteid,
                        principalTable: "Clientes",
                        principalColumn: "clienteid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipoMovimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    saldo = table.Column<double>(type: "float", nullable: false),
                    Clientesclienteid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimientos_Clientes_Clientesclienteid",
                        column: x => x.Clientesclienteid,
                        principalTable: "Clientes",
                        principalColumn: "clienteid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PeronsaId",
                table: "Clientes",
                column: "PeronsaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_Clientesclienteid",
                table: "Cuentas",
                column: "Clientesclienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_Clientesclienteid",
                table: "Movimientos",
                column: "Clientesclienteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "Movimientos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
