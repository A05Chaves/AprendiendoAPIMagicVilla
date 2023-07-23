using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaAcualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "iniciando con los registros", new DateTime(2023, 7, 22, 7, 47, 32, 737, DateTimeKind.Local).AddTicks(7987), new DateTime(2023, 7, 22, 7, 47, 32, 737, DateTimeKind.Local).AddTicks(7973), "", 5.0, "Primera villa", 5, 2000.0 },
                    { 2, "", "segundo registro", new DateTime(2023, 7, 22, 7, 47, 32, 737, DateTimeKind.Local).AddTicks(7991), new DateTime(2023, 7, 22, 7, 47, 32, 737, DateTimeKind.Local).AddTicks(7990), "", 15.0, "segunda villa", 15, 25000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
