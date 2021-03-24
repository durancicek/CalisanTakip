using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CalisanTakipDAL.Migrations
{
    public partial class AddCalisanTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IzinTipis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VarsayilanGun = table.Column<int>(type: "int", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzinTipis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IzinTaleps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TalepEdenCalisanId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OnaylayanId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IzinTipiId = table.Column<int>(type: "int", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TalepTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TalepNot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnayDurumu = table.Column<bool>(type: "bit", nullable: true),
                    IzinDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzinTaleps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IzinTaleps_AspNetUsers_OnaylayanId",
                        column: x => x.OnaylayanId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IzinTaleps_AspNetUsers_TalepEdenCalisanId",
                        column: x => x.TalepEdenCalisanId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IzinTaleps_IzinTipis_IzinTipiId",
                        column: x => x.IzinTipiId,
                        principalTable: "IzinTipis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IzinTanims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GunSayisi = table.Column<int>(type: "int", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Periyot = table.Column<int>(type: "int", nullable: false),
                    CalisanId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IzinTipiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzinTanims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IzinTanims_AspNetUsers_CalisanId",
                        column: x => x.CalisanId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IzinTanims_IzinTipis_IzinTipiId",
                        column: x => x.IzinTipiId,
                        principalTable: "IzinTipis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IzinTaleps_IzinTipiId",
                table: "IzinTaleps",
                column: "IzinTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_IzinTaleps_OnaylayanId",
                table: "IzinTaleps",
                column: "OnaylayanId");

            migrationBuilder.CreateIndex(
                name: "IX_IzinTaleps_TalepEdenCalisanId",
                table: "IzinTaleps",
                column: "TalepEdenCalisanId");

            migrationBuilder.CreateIndex(
                name: "IX_IzinTanims_CalisanId",
                table: "IzinTanims",
                column: "CalisanId");

            migrationBuilder.CreateIndex(
                name: "IX_IzinTanims_IzinTipiId",
                table: "IzinTanims",
                column: "IzinTipiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IzinTaleps");

            migrationBuilder.DropTable(
                name: "IzinTanims");

            migrationBuilder.DropTable(
                name: "IzinTipis");
        }
    }
}
