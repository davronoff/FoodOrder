using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrder.DataLayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Katagoriyalar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nomi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Katagoriyalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Userlar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FISH = table.Column<string>(type: "text", nullable: false),
                    Nomer = table.Column<string>(type: "text", nullable: false),
                    Manzil = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mahsulotlar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nomi = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Batafsil = table.Column<string>(type: "text", nullable: false),
                    Narxi = table.Column<double>(type: "double precision", nullable: false),
                    Rasmi = table.Column<string>(type: "text", nullable: false),
                    KatagoriyaId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahsulotlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mahsulotlar_Katagoriyalar_KatagoriyaId",
                        column: x => x.KatagoriyaId,
                        principalTable: "Katagoriyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mahsulotlar_Userlar_UserId",
                        column: x => x.UserId,
                        principalTable: "Userlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mahsulotlar_KatagoriyaId",
                table: "Mahsulotlar",
                column: "KatagoriyaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mahsulotlar_UserId",
                table: "Mahsulotlar",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mahsulotlar");

            migrationBuilder.DropTable(
                name: "Katagoriyalar");

            migrationBuilder.DropTable(
                name: "Userlar");
        }
    }
}
