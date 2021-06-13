using Microsoft.EntityFrameworkCore.Migrations;

namespace Writely.Migrations
{
    public partial class Rand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rad_Takmičenje_TakmičenjeId",
                table: "Rad");

            migrationBuilder.AlterColumn<int>(
                name: "TakmičenjeId",
                table: "Rad",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Rad_Takmičenje_TakmičenjeId",
                table: "Rad",
                column: "TakmičenjeId",
                principalTable: "Takmičenje",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rad_Takmičenje_TakmičenjeId",
                table: "Rad");

            migrationBuilder.AlterColumn<int>(
                name: "TakmičenjeId",
                table: "Rad",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rad_Takmičenje_TakmičenjeId",
                table: "Rad",
                column: "TakmičenjeId",
                principalTable: "Takmičenje",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
