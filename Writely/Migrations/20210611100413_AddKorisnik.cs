using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Writely.Migrations
{
    public partial class AddKorisnik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(maxLength: 25, nullable: false),
                    DatumRegistracije = table.Column<DateTime>(nullable: false),
                    DodijeljeneTitule = table.Column<string>(nullable: true),
                    AktuelnaTitula = table.Column<int>(nullable: false),
                    WritelyMoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Takmičenje",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 30, nullable: false),
                    DatumPocetka = table.Column<DateTime>(nullable: false),
                    DatumKraja = table.Column<DateTime>(nullable: false),
                    DozvoljeneKategorije = table.Column<string>(nullable: false),
                    Opis = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takmičenje", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rad",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 30, nullable: false),
                    AutorId = table.Column<int>(nullable: false),
                    žanr = table.Column<int>(nullable: false),
                    ŽanrId = table.Column<int>(nullable: false),
                    kategorija = table.Column<int>(nullable: false),
                    KategorijaId = table.Column<int>(nullable: false),
                    Sadržaj = table.Column<string>(nullable: false),
                    DatumObjave = table.Column<DateTime>(nullable: false),
                    tagovi = table.Column<string>(nullable: true),
                    TakmičenjeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rad", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rad_Korisnik_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Korisnik",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rad_Takmičenje_TakmičenjeId",
                        column: x => x.TakmičenjeId,
                        principalTable: "Takmičenje",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Prijava",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false),
                    Sadržaj = table.Column<string>(nullable: false),
                    PošiljalacId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    DatumPrijave = table.Column<DateTime>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: true),
                    RadId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prijava", x => x.id);
                    table.ForeignKey(
                        name: "FK_Prijava_Korisnik_PošiljalacId",
                        column: x => x.PošiljalacId,
                        principalTable: "Korisnik",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prijava_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Prijava_Rad_RadId",
                        column: x => x.RadId,
                        principalTable: "Rad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ocjena = table.Column<int>(nullable: false),
                    Komentar = table.Column<string>(maxLength: 500, nullable: true),
                    KorisnikId = table.Column<int>(nullable: false),
                    RadId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recenzija_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recenzija_Rad_RadId",
                        column: x => x.RadId,
                        principalTable: "Rad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prijava_PošiljalacId",
                table: "Prijava",
                column: "PošiljalacId");

            migrationBuilder.CreateIndex(
                name: "IX_Prijava_KorisnikId",
                table: "Prijava",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Prijava_RadId",
                table: "Prijava",
                column: "RadId");

            migrationBuilder.CreateIndex(
                name: "IX_Rad_AutorId",
                table: "Rad",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Rad_TakmičenjeId",
                table: "Rad",
                column: "TakmičenjeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_KorisnikId",
                table: "Recenzija",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_RadId",
                table: "Recenzija",
                column: "RadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prijava");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "Rad");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Takmičenje");
        }
    }
}
