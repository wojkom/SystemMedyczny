using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemMedyczny.Model.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apteki",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true),
                    Adres = table.Column<string>(type: "TEXT", nullable: true),
                    Telefon = table.Column<string>(type: "TEXT", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Uwagi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apteki", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FirmyFarmaceutyczne",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true),
                    Telefon = table.Column<string>(type: "TEXT", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Uwagi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmyFarmaceutyczne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lekarze",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Specjalizacja = table.Column<string>(type: "TEXT", nullable: true),
                    DataRozpoczeciaPracy = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Uwagi = table.Column<string>(type: "TEXT", nullable: true),
                    NrUbezpieczenia = table.Column<string>(type: "TEXT", nullable: true),
                    Imie = table.Column<string>(type: "TEXT", nullable: true),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: true),
                    Adres = table.Column<string>(type: "TEXT", nullable: true),
                    DataUrodzenia = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lekarze", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leki",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NazwaHandlowa = table.Column<string>(type: "TEXT", nullable: true),
                    SubstancjaAktywna = table.Column<string>(type: "TEXT", nullable: true),
                    FirmaFarmaceutycznaId = table.Column<long>(type: "INTEGER", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Uwagi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leki_FirmyFarmaceutyczne_FirmaFarmaceutycznaId",
                        column: x => x.FirmaFarmaceutycznaId,
                        principalTable: "FirmyFarmaceutyczne",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pacjenci",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LekarzId = table.Column<long>(type: "INTEGER", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Uwagi = table.Column<string>(type: "TEXT", nullable: true),
                    NrUbezpieczenia = table.Column<string>(type: "TEXT", nullable: true),
                    Imie = table.Column<string>(type: "TEXT", nullable: true),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: true),
                    Adres = table.Column<string>(type: "TEXT", nullable: true),
                    DataUrodzenia = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacjenci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacjenci_Lekarze_LekarzId",
                        column: x => x.LekarzId,
                        principalTable: "Lekarze",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LekApteka",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LekId = table.Column<long>(type: "INTEGER", nullable: true),
                    AptekaId = table.Column<long>(type: "INTEGER", nullable: true),
                    Cena = table.Column<decimal>(type: "TEXT", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Uwagi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LekApteka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LekApteka_Apteki_AptekaId",
                        column: x => x.AptekaId,
                        principalTable: "Apteki",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LekApteka_Leki_LekId",
                        column: x => x.LekId,
                        principalTable: "Leki",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Recepty",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PacjentId = table.Column<long>(type: "INTEGER", nullable: true),
                    LekarzId = table.Column<long>(type: "INTEGER", nullable: true),
                    DataWystawienia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Uwagi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recepty_Lekarze_LekarzId",
                        column: x => x.LekarzId,
                        principalTable: "Lekarze",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Recepty_Pacjenci_PacjentId",
                        column: x => x.PacjentId,
                        principalTable: "Pacjenci",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LekRecepta",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LekId = table.Column<long>(type: "INTEGER", nullable: true),
                    ReceptaId = table.Column<long>(type: "INTEGER", nullable: true),
                    Ilosc = table.Column<int>(type: "INTEGER", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Uwagi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LekRecepta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LekRecepta_Leki_LekId",
                        column: x => x.LekId,
                        principalTable: "Leki",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LekRecepta_Recepty_ReceptaId",
                        column: x => x.ReceptaId,
                        principalTable: "Recepty",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LekApteka_AptekaId",
                table: "LekApteka",
                column: "AptekaId");

            migrationBuilder.CreateIndex(
                name: "IX_LekApteka_LekId",
                table: "LekApteka",
                column: "LekId");

            migrationBuilder.CreateIndex(
                name: "IX_Leki_FirmaFarmaceutycznaId",
                table: "Leki",
                column: "FirmaFarmaceutycznaId");

            migrationBuilder.CreateIndex(
                name: "IX_LekRecepta_LekId",
                table: "LekRecepta",
                column: "LekId");

            migrationBuilder.CreateIndex(
                name: "IX_LekRecepta_ReceptaId",
                table: "LekRecepta",
                column: "ReceptaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacjenci_LekarzId",
                table: "Pacjenci",
                column: "LekarzId");

            migrationBuilder.CreateIndex(
                name: "IX_Recepty_LekarzId",
                table: "Recepty",
                column: "LekarzId");

            migrationBuilder.CreateIndex(
                name: "IX_Recepty_PacjentId",
                table: "Recepty",
                column: "PacjentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LekApteka");

            migrationBuilder.DropTable(
                name: "LekRecepta");

            migrationBuilder.DropTable(
                name: "Apteki");

            migrationBuilder.DropTable(
                name: "Leki");

            migrationBuilder.DropTable(
                name: "Recepty");

            migrationBuilder.DropTable(
                name: "FirmyFarmaceutyczne");

            migrationBuilder.DropTable(
                name: "Pacjenci");

            migrationBuilder.DropTable(
                name: "Lekarze");
        }
    }
}
