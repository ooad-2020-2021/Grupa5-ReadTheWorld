using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Writely.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prijava_Korisnik_PošiljalacId",
                table: "Prijava");

            migrationBuilder.DropForeignKey(
                name: "FK_Prijava_Korisnik_KorisnikId",
                table: "Prijava");

            migrationBuilder.DropForeignKey(
                name: "FK_Prijava_Rad_RadId",
                table: "Prijava");

            migrationBuilder.DropForeignKey(
                name: "FK_Rad_Takmičenje_TakmičenjeId",
                table: "Rad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prijava",
                table: "Prijava");

            migrationBuilder.DropIndex(
                name: "IX_Prijava_KorisnikId",
                table: "Prijava");

            migrationBuilder.DropIndex(
                name: "IX_Prijava_RadId",
                table: "Prijava");

            migrationBuilder.DropColumn(
                name: "kategorija",
                table: "Rad");

            migrationBuilder.DropColumn(
                name: "žanr",
                table: "Rad");

            migrationBuilder.DropColumn(
                name: "AktuelnaTitula",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Prijava");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Prijava");

            migrationBuilder.DropColumn(
                name: "KorisnikId",
                table: "Prijava");

            migrationBuilder.RenameTable(
                name: "Prijava",
                newName: "PrijavaRada");

            migrationBuilder.RenameIndex(
                name: "IX_Prijava_PošiljalacId",
                table: "PrijavaRada",
                newName: "IX_PrijavaRada_PošiljalacId");

            migrationBuilder.AlterColumn<int>(
                name: "RadId",
                table: "PrijavaRada",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrijavaRada",
                table: "PrijavaRada",
                column: "id");

            migrationBuilder.CreateTable(
                name: "PrijavaKorisnika",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false),
                    Sadržaj = table.Column<string>(nullable: false),
                    PošiljalacId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    DatumPrijave = table.Column<DateTime>(nullable: false),
                    PrijavaId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrijavaKorisnika", x => x.id);
                    table.ForeignKey(
                        name: "FK_PrijavaKorisnika_Korisnik_PošiljalacId",
                        column: x => x.PošiljalacId,
                        principalTable: "Korisnik",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrijavaKorisnika_PošiljalacId",
                table: "PrijavaKorisnika",
                column: "PošiljalacId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrijavaRada_Korisnik_PošiljalacId",
                table: "PrijavaRada",
                column: "PošiljalacId",
                principalTable: "Korisnik",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rad_Takmičenje_TakmičenjeId",
                table: "Rad",
                column: "TakmičenjeId",
                principalTable: "Takmičenje",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrijavaRada_Korisnik_PošiljalacId",
                table: "PrijavaRada");

            migrationBuilder.DropForeignKey(
                name: "FK_Rad_Takmičenje_TakmičenjeId",
                table: "Rad");

            migrationBuilder.DropTable(
                name: "PrijavaKorisnika");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrijavaRada",
                table: "PrijavaRada");

            migrationBuilder.RenameTable(
                name: "PrijavaRada",
                newName: "Prijava");

            migrationBuilder.RenameIndex(
                name: "IX_PrijavaRada_PošiljalacId",
                table: "Prijava",
                newName: "IX_Prijava_PošiljalacId");

            migrationBuilder.AddColumn<int>(
                name: "kategorija",
                table: "Rad",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "žanr",
                table: "Rad",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AktuelnaTitula",
                table: "Korisnik",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RadId",
                table: "Prijava",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Prijava",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Prijava",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KorisnikId",
                table: "Prijava",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prijava",
                table: "Prijava",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Prijava_KorisnikId",
                table: "Prijava",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Prijava_RadId",
                table: "Prijava",
                column: "RadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prijava_Korisnik_PošiljalacId",
                table: "Prijava",
                column: "PošiljalacId",
                principalTable: "Korisnik",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prijava_Korisnik_KorisnikId",
                table: "Prijava",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prijava_Rad_RadId",
                table: "Prijava",
                column: "RadId",
                principalTable: "Rad",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rad_Takmičenje_TakmičenjeId",
                table: "Rad",
                column: "TakmičenjeId",
                principalTable: "Takmičenje",
                principalColumn: "id");
        }
    }
}
