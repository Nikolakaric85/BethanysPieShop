using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class ShoppingCardItemTOOShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoopingCardItems");

            migrationBuilder.CreateTable(
                name: "ShoopingCartItems",
                columns: table => new
                {
                    ShoopingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PieId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoopingCardId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoopingCartItems", x => x.ShoopingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoopingCartItems_Pies_PieId",
                        column: x => x.PieId,
                        principalTable: "Pies",
                        principalColumn: "PieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoopingCartItems_PieId",
                table: "ShoopingCartItems",
                column: "PieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoopingCartItems");

            migrationBuilder.CreateTable(
                name: "ShoopingCardItems",
                columns: table => new
                {
                    ShoopingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    PieId = table.Column<int>(type: "int", nullable: true),
                    ShoopingCardId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoopingCardItems", x => x.ShoopingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoopingCardItems_Pies_PieId",
                        column: x => x.PieId,
                        principalTable: "Pies",
                        principalColumn: "PieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoopingCardItems_PieId",
                table: "ShoopingCardItems",
                column: "PieId");
        }
    }
}
