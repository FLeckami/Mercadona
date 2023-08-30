using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Mercadona.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ctgcategorie",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nom = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ctgcategorie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "prmpromotion",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datedebut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    datefin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    pctpromotion = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prmpromotion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usrutilisateur",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nom = table.Column<string>(type: "text", nullable: true),
                    mdp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usrutilisateur", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "prdproduit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    titre = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    prix = table.Column<float>(type: "real", nullable: true),
                    image = table.Column<string>(type: "text", nullable: true),
                    prd_ctg_id = table.Column<int>(type: "integer", nullable: false),
                    prd_prm_id = table.Column<int>(type: "integer", nullable: true),
                    Categorieid = table.Column<int>(type: "integer", nullable: true),
                    Promotionid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prdproduit", x => x.id);
                    table.ForeignKey(
                        name: "FK_prdproduit_ctgcategorie_Categorieid",
                        column: x => x.Categorieid,
                        principalTable: "ctgcategorie",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_prdproduit_prmpromotion_Promotionid",
                        column: x => x.Promotionid,
                        principalTable: "prmpromotion",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_prdproduit_Categorieid",
                table: "prdproduit",
                column: "Categorieid");

            migrationBuilder.CreateIndex(
                name: "IX_prdproduit_Promotionid",
                table: "prdproduit",
                column: "Promotionid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "prdproduit");

            migrationBuilder.DropTable(
                name: "usrutilisateur");

            migrationBuilder.DropTable(
                name: "ctgcategorie");

            migrationBuilder.DropTable(
                name: "prmpromotion");
        }
    }
}
