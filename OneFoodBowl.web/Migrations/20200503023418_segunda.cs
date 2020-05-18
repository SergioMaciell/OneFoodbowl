using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OneFoodBowl.web.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatePlans_Recipes_RecipeId",
                table: "CreatePlans");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_RecipeTypes_RecipeTypeId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.RenameTable(
                name: "Recipes",
                newName: "Recipe");

            migrationBuilder.RenameIndex(
                name: "IX_Recipes_RecipeTypeId",
                table: "Recipe",
                newName: "IX_Recipe_RecipeTypeId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RecipeDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 1000, nullable: false),
                    Instruction = table.Column<string>(maxLength: 1000, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Ingredients = table.Column<string>(maxLength: 1000, nullable: false),
                    RecipeTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeDetail_RecipeTypes_RecipeTypeId",
                        column: x => x.RecipeTypeId,
                        principalTable: "RecipeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeDetail_RecipeTypeId",
                table: "RecipeDetail",
                column: "RecipeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatePlans_Recipe_RecipeId",
                table: "CreatePlans",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_RecipeTypes_RecipeTypeId",
                table: "Recipe",
                column: "RecipeTypeId",
                principalTable: "RecipeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatePlans_Recipe_RecipeId",
                table: "CreatePlans");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_RecipeTypes_RecipeTypeId",
                table: "Recipe");

            migrationBuilder.DropTable(
                name: "RecipeDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe");

            migrationBuilder.RenameTable(
                name: "Recipe",
                newName: "Recipes");

            migrationBuilder.RenameIndex(
                name: "IX_Recipe_RecipeTypeId",
                table: "Recipes",
                newName: "IX_Recipes_RecipeTypeId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatePlans_Recipes_RecipeId",
                table: "CreatePlans",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_RecipeTypes_RecipeTypeId",
                table: "Recipes",
                column: "RecipeTypeId",
                principalTable: "RecipeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
