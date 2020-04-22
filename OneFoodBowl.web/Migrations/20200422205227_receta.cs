using Microsoft.EntityFrameworkCore.Migrations;

namespace OneFoodBowl.web.Migrations
{
    public partial class receta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatePlans_RecipeTypes_RecipeTypeId",
                table: "CreatePlans");

            migrationBuilder.RenameColumn(
                name: "RecipeTypeId",
                table: "CreatePlans",
                newName: "RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_CreatePlans_RecipeTypeId",
                table: "CreatePlans",
                newName: "IX_CreatePlans_RecipeId");

            migrationBuilder.AlterColumn<string>(
                name: "Weight",
                table: "Customers",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(double),
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Height",
                table: "Customers",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(double),
                oldMaxLength: 4);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatePlans_Recipes_RecipeId",
                table: "CreatePlans",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatePlans_Recipes_RecipeId",
                table: "CreatePlans");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "CreatePlans",
                newName: "RecipeTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CreatePlans_RecipeId",
                table: "CreatePlans",
                newName: "IX_CreatePlans_RecipeTypeId");

            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Customers",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "Customers",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 4);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatePlans_RecipeTypes_RecipeTypeId",
                table: "CreatePlans",
                column: "RecipeTypeId",
                principalTable: "RecipeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
