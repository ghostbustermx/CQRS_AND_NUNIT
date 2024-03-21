using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Education.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EducationMigrationInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "Descripcion", "FechaCreacion", "FechaPublicacion", "Precio", "Titulo" },
                values: new object[,]
                {
                    { new Guid("37f02456-36b0-4079-b3fe-fd6165e2d4e3"), "Curso de UnitTest para NET core", new DateTime(2024, 3, 20, 16, 56, 18, 417, DateTimeKind.Local).AddTicks(9792), new DateTime(2026, 3, 20, 16, 56, 18, 417, DateTimeKind.Local).AddTicks(9792), 1000m, "Master en UnitTest con CQRS" },
                    { new Guid("8bb7afab-9933-41d3-862b-30c9d16cab74"), "Curso de Java", new DateTime(2024, 3, 20, 16, 56, 18, 417, DateTimeKind.Local).AddTicks(9766), new DateTime(2026, 3, 20, 16, 56, 18, 417, DateTimeKind.Local).AddTicks(9767), 25m, "Master en Java Spring desde las raices" },
                    { new Guid("f3b7268c-5bcb-4126-af5b-743d2272a945"), "Curso de c# basico", new DateTime(2024, 3, 20, 16, 56, 18, 417, DateTimeKind.Local).AddTicks(9708), new DateTime(2026, 3, 20, 16, 56, 18, 417, DateTimeKind.Local).AddTicks(9720), 56m, "C# desde cero hasta avanzado" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
