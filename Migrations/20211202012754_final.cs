using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pruebaTecnica.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    primerNombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    segundoNombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    primerApellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    segundoApellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    tipoDocumento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    numeroDocumento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    celular = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    correoElectronico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mecanico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    primerNombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    segundoNombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    primerApellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    segundoApellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    tipoDocumento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    numeroDocumento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    celular = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    correoElectronico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    estado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    MecanicoId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factura_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factura_Mecanico_MecanicoId",
                        column: x => x.MecanicoId,
                        principalTable: "Mecanico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesgloseRepuestos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    precioUnidad = table.Column<float>(type: "real", nullable: false),
                    numeroUnidades = table.Column<int>(type: "int", nullable: false),
                    descuento = table.Column<int>(type: "int", nullable: false),
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesgloseRepuestos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesgloseRepuestos_Factura_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Factura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DesgloseServicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreServicio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    precioManoDeObra = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descuento = table.Column<int>(type: "int", nullable: false),
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesgloseServicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesgloseServicios_Factura_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Factura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DesgloseRepuestos_FacturaId",
                table: "DesgloseRepuestos",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_DesgloseServicios_FacturaId",
                table: "DesgloseServicios",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_ClienteId",
                table: "Factura",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_MecanicoId",
                table: "Factura",
                column: "MecanicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DesgloseRepuestos");

            migrationBuilder.DropTable(
                name: "DesgloseServicios");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Mecanico");
        }
    }
}
