using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZeniStudioWebBlazor.Data.Migrations
{
    public partial class BasedeDAtosZen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyect",
                columns: table => new
                {
                    CodigoProyecto = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    idEstado = table.Column<int>(type: "int", nullable: false),
                    prioridad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    fechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    razonCancelacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyect", x => x.CodigoProyecto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proyect");
        }
    }
}
