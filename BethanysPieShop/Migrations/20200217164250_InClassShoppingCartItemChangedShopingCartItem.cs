using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class InClassShoppingCartItemChangedShopingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoopingCartItems_Pies_PieId",
                table: "ShoopingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoopingCartItems",
                table: "ShoopingCartItems");

            migrationBuilder.DropColumn(
                name: "ShoopingCardId",
                table: "ShoopingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoopingCartItems",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoopingCartItems_PieId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_PieId");

            migrationBuilder.AddColumn<string>(
                name: "ShoopingCartId",
                table: "ShoppingCartItems",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoopingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Pies_PieId",
                table: "ShoppingCartItems",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Pies_PieId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "ShoopingCartId",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "ShoopingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_PieId",
                table: "ShoopingCartItems",
                newName: "IX_ShoopingCartItems_PieId");

            migrationBuilder.AddColumn<string>(
                name: "ShoopingCardId",
                table: "ShoopingCartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoopingCartItems",
                table: "ShoopingCartItems",
                column: "ShoopingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoopingCartItems_Pies_PieId",
                table: "ShoopingCartItems",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
