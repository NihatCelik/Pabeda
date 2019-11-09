using Microsoft.EntityFrameworkCore.Migrations;

namespace Pabeda.Projem.DataAccess.Migrations
{
    public partial class PabedaProjemDataAccessConcreteEntityFrameworkProjemContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Okuls",
                columns: table => new
                {
                    OkulId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OkulAdi = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    Sehir = table.Column<string>(nullable: true),
                    Ilce = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okuls", x => x.OkulId);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(nullable: true),
                    Soyisim = table.Column<string>(nullable: true),
                    TCKimlikNo = table.Column<string>(nullable: true),
                    OkuduguOkulOkulId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.OgrenciId);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Okuls_OkuduguOkulOkulId",
                        column: x => x.OkuduguOkulOkulId,
                        principalTable: "Okuls",
                        principalColumn: "OkulId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmens",
                columns: table => new
                {
                    OgretmenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(nullable: true),
                    Soyisim = table.Column<string>(nullable: true),
                    TCKimlikNo = table.Column<string>(nullable: true),
                    OkulId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmens", x => x.OgretmenId);
                    table.ForeignKey(
                        name: "FK_Ogretmens_Okuls_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okuls",
                        principalColumn: "OkulId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OgretmenOgrencis",
                columns: table => new
                {
                    OgretmenId = table.Column<int>(nullable: false),
                    OgrenciId = table.Column<int>(nullable: false),
                    OgretmenOgrenciId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretmenOgrencis", x => new { x.OgretmenId, x.OgrenciId });
                    table.ForeignKey(
                        name: "FK_OgretmenOgrencis_Ogrencis_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrencis",
                        principalColumn: "OgrenciId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgretmenOgrencis_Ogretmens_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Ogretmens",
                        principalColumn: "OgretmenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_OkuduguOkulOkulId",
                table: "Ogrencis",
                column: "OkuduguOkulOkulId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenOgrencis_OgrenciId",
                table: "OgretmenOgrencis",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmens_OkulId",
                table: "Ogretmens",
                column: "OkulId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgretmenOgrencis");

            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Ogretmens");

            migrationBuilder.DropTable(
                name: "Okuls");
        }
    }
}
