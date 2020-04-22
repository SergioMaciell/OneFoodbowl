using Microsoft.EntityFrameworkCore.Migrations;

namespace OneFoodBowl.web.Migrations
{
    public partial class Nutriologo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecipeTypeId",
                table: "Recipes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_RecipeTypeId",
                table: "Recipes",
                column: "RecipeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_RecipeTypes_RecipeTypeId",
                table: "Recipes",
                column: "RecipeTypeId",
                principalTable: "RecipeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_RecipeTypes_RecipeTypeId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_RecipeTypeId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "RecipeTypeId",
                table: "Recipes");
        }
    }
}
