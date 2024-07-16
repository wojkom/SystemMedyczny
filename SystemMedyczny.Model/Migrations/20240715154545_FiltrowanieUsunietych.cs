using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemMedyczny.Model.Migrations
{
    /// <inheritdoc />
    public partial class FiltrowanieUsunietych : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recepty_Lekarze_LekarzId",
                table: "Recepty");

            migrationBuilder.DropForeignKey(
                name: "FK_Recepty_Pacjenci_PacjentId",
                table: "Recepty");

            migrationBuilder.DropTable(
                name: "LekApteka");

            migrationBuilder.DropTable(
                name: "LekRecepta");

            migrationBuilder.DropTable(
                name: "Pacjenci");

            migrationBuilder.DropTable(
                name: "Apteki");

            migrationBuilder.DropTable(
                name: "Leki");

            migrationBuilder.DropTable(
                name: "Lekarze");

            migrationBuilder.DropTable(
                name: "FirmyFarmaceutyczne");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recepty",
                table: "Recepty");

            migrationBuilder.RenameTable(
                name: "Recepty",
                newName: "Encja");

            migrationBuilder.RenameIndex(
                name: "IX_Recepty_PacjentId",
                table: "Encja",
                newName: "IX_Encja_PacjentId");

            migrationBuilder.RenameIndex(
                name: "IX_Recepty_LekarzId",
                table: "Encja",
                newName: "IX_Encja_LekarzId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataWystawienia",
                table: "Encja",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "AptekaId",
                table: "Encja",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Cena",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataRozpoczeciaPracy",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataUrodzenia",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Encja",
                type: "TEXT",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "FirmaFarmaceutycznaId",
                table: "Encja",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaFarmaceutyczna_Nazwa",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaFarmaceutyczna_Telefon",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ilosc",
                table: "Encja",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imie",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LekId",
                table: "Encja",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LekRecepta_LekId",
                table: "Encja",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lekarz_Adres",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nazwa",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NazwaHandlowa",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nazwisko",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NrUbezpieczenia",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pacjent_Adres",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ReceptaId",
                table: "Encja",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Recepta_LekarzId",
                table: "Encja",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specjalizacja",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubstancjaAktywna",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Encja",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Usunieta",
                table: "Encja",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Encja",
                table: "Encja",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Encja_AptekaId",
                table: "Encja",
                column: "AptekaId");

            migrationBuilder.CreateIndex(
                name: "IX_Encja_FirmaFarmaceutycznaId",
                table: "Encja",
                column: "FirmaFarmaceutycznaId");

            migrationBuilder.CreateIndex(
                name: "IX_Encja_LekId",
                table: "Encja",
                column: "LekId");

            migrationBuilder.CreateIndex(
                name: "IX_Encja_LekRecepta_LekId",
                table: "Encja",
                column: "LekRecepta_LekId");

            migrationBuilder.CreateIndex(
                name: "IX_Encja_Recepta_LekarzId",
                table: "Encja",
                column: "Recepta_LekarzId");

            migrationBuilder.CreateIndex(
                name: "IX_Encja_ReceptaId",
                table: "Encja",
                column: "ReceptaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Encja_Encja_AptekaId",
                table: "Encja",
                column: "AptekaId",
                principalTable: "Encja",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Encja_Encja_FirmaFarmaceutycznaId",
                table: "Encja",
                column: "FirmaFarmaceutycznaId",
                principalTable: "Encja",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Encja_Encja_LekId",
                table: "Encja",
                column: "LekId",
                principalTable: "Encja",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Encja_Encja_LekRecepta_LekId",
                table: "Encja",
                column: "LekRecepta_LekId",
                principalTable: "Encja",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Encja_Encja_LekarzId",
                table: "Encja",
                column: "LekarzId",
                principalTable: "Encja",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Encja_Encja_PacjentId",
                table: "Encja",
                column: "PacjentId",
                principalTable: "Encja",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Encja_Encja_ReceptaId",
                table: "Encja",
                column: "ReceptaId",
                principalTable: "Encja",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Encja_Encja_Recepta_LekarzId",
                table: "Encja",
                column: "Recepta_LekarzId",
                principalTable: "Encja",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encja_Encja_AptekaId",
                table: "Encja");

            migrationBuilder.DropForeignKey(
                name: "FK_Encja_Encja_FirmaFarmaceutycznaId",
                table: "Encja");

            migrationBuilder.DropForeignKey(
                name: "FK_Encja_Encja_LekId",
                table: "Encja");

            migrationBuilder.DropForeignKey(
                name: "FK_Encja_Encja_LekRecepta_LekId",
                table: "Encja");

            migrationBuilder.DropForeignKey(
                name: "FK_Encja_Encja_LekarzId",
                table: "Encja");

            migrationBuilder.DropForeignKey(
                name: "FK_Encja_Encja_PacjentId",
                table: "Encja");

            migrationBuilder.DropForeignKey(
                name: "FK_Encja_Encja_ReceptaId",
                table: "Encja");

            migrationBuilder.DropForeignKey(
                name: "FK_Encja_Encja_Recepta_LekarzId",
                table: "Encja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Encja",
                table: "Encja");

            migrationBuilder.DropIndex(
                name: "IX_Encja_AptekaId",
                table: "Encja");

            migrationBuilder.DropIndex(
                name: "IX_Encja_FirmaFarmaceutycznaId",
                table: "Encja");

            migrationBuilder.DropIndex(
                name: "IX_Encja_LekId",
                table: "Encja");

            migrationBuilder.DropIndex(
                name: "IX_Encja_LekRecepta_LekId",
                table: "Encja");

            migrationBuilder.DropIndex(
                name: "IX_Encja_Recepta_LekarzId",
                table: "Encja");

            migrationBuilder.DropIndex(
                name: "IX_Encja_ReceptaId",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "AptekaId",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Cena",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "DataRozpoczeciaPracy",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "DataUrodzenia",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "FirmaFarmaceutycznaId",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "FirmaFarmaceutyczna_Nazwa",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "FirmaFarmaceutyczna_Telefon",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Ilosc",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Imie",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "LekId",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "LekRecepta_LekId",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Lekarz_Adres",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Nazwa",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "NazwaHandlowa",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Nazwisko",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "NrUbezpieczenia",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Pacjent_Adres",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "ReceptaId",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Recepta_LekarzId",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Specjalizacja",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "SubstancjaAktywna",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Encja");

            migrationBuilder.DropColumn(
                name: "Usunieta",
                table: "Encja");

            migrationBuilder.RenameTable(
                name: "Encja",
                newName: "Recepty");

            migrationBuilder.RenameIndex(
                name: "IX_Encja_PacjentId",
                table: "Recepty",
                newName: "IX_Recepty_PacjentId");

            migrationBuilder.RenameIndex(
                name: "IX_Encja_LekarzId",
                table: "Recepty",
                newName: "IX_Recepty_LekarzId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataWystawienia",
                table: "Recepty",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recepty",
                table: "Recepty",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Apteki",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Adres = table.Column<string>(type: "TEXT", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true),
                    Telefon = table.Column<string>(type: "TEXT", nullable: true),
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
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true),
                    Telefon = table.Column<string>(type: "TEXT", nullable: true),
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
                    Adres = table.Column<string>(type: "TEXT", nullable: true),
                    DataRozpoczeciaPracy = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataUrodzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Imie = table.Column<string>(type: "TEXT", nullable: true),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: true),
                    NrUbezpieczenia = table.Column<string>(type: "TEXT", nullable: true),
                    Specjalizacja = table.Column<string>(type: "TEXT", nullable: true),
                    Uwagi = table.Column<string>(type: "TEXT", nullable: true)
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
                    FirmaFarmaceutycznaId = table.Column<long>(type: "INTEGER", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NazwaHandlowa = table.Column<string>(type: "TEXT", nullable: true),
                    SubstancjaAktywna = table.Column<string>(type: "TEXT", nullable: true),
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
                    Adres = table.Column<string>(type: "TEXT", nullable: true),
                    DataUrodzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Imie = table.Column<string>(type: "TEXT", nullable: true),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: true),
                    NrUbezpieczenia = table.Column<string>(type: "TEXT", nullable: true),
                    Uwagi = table.Column<string>(type: "TEXT", nullable: true)
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
                    AptekaId = table.Column<long>(type: "INTEGER", nullable: true),
                    LekId = table.Column<long>(type: "INTEGER", nullable: true),
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
                name: "LekRecepta",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LekId = table.Column<long>(type: "INTEGER", nullable: true),
                    ReceptaId = table.Column<long>(type: "INTEGER", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Ilosc = table.Column<int>(type: "INTEGER", nullable: false),
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

            migrationBuilder.AddForeignKey(
                name: "FK_Recepty_Lekarze_LekarzId",
                table: "Recepty",
                column: "LekarzId",
                principalTable: "Lekarze",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recepty_Pacjenci_PacjentId",
                table: "Recepty",
                column: "PacjentId",
                principalTable: "Pacjenci",
                principalColumn: "Id");
        }
    }
}
