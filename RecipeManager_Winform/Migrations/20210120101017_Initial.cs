using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeManager_Winform.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "food_category",
                columns: table => new
                {
                    food_category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    food_category_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_food_category", x => x.food_category_id);
                });

            migrationBuilder.CreateTable(
                name: "ingredients",
                columns: table => new
                {
                    ingredient_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ingredient_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    caloriesper100g = table.Column<double>(name: "calories (per 100g)", type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredients", x => x.ingredient_id);
                });

            migrationBuilder.CreateTable(
                name: "measurements",
                columns: table => new
                {
                    measurement_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    measurement_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_measurements", x => x.measurement_id);
                });

            migrationBuilder.CreateTable(
                name: "quantity",
                columns: table => new
                {
                    quantity_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantity = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quantity", x => x.quantity_id);
                });

            migrationBuilder.CreateTable(
                name: "recipe_source",
                columns: table => new
                {
                    recipe_source_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    recipe_source_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    recipe_source_URL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe_source", x => x.recipe_source_id);
                });

            migrationBuilder.CreateTable(
                name: "recipe",
                columns: table => new
                {
                    recipe_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    food_category_id = table.Column<int>(type: "int", nullable: false),
                    recipe_source_id = table.Column<int>(type: "int", nullable: false),
                    recipe_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    recipe_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duration = table.Column<int>(type: "int", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe", x => x.recipe_id);
                    table.ForeignKey(
                        name: "FK__recipe__food_cat__4222D4EF",
                        column: x => x.food_category_id,
                        principalTable: "food_category",
                        principalColumn: "food_category_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_recipe_recipe_source",
                        column: x => x.recipe_source_id,
                        principalTable: "recipe_source",
                        principalColumn: "recipe_source_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "recipe_ingredients",
                columns: table => new
                {
                    recipe_Ingredient_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    recipe_id = table.Column<int>(type: "int", nullable: false),
                    ingredient_id = table.Column<int>(type: "int", nullable: false),
                    quantity_id = table.Column<int>(type: "int", nullable: true),
                    measurement_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe_ingredients", x => x.recipe_Ingredient_id);
                    table.ForeignKey(
                        name: "FK__recipe_in__ingre__14270015",
                        column: x => x.ingredient_id,
                        principalTable: "ingredients",
                        principalColumn: "ingredient_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__recipe_in__measu__160F4887",
                        column: x => x.measurement_id,
                        principalTable: "measurements",
                        principalColumn: "measurement_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__recipe_in__quant__151B244E",
                        column: x => x.quantity_id,
                        principalTable: "quantity",
                        principalColumn: "quantity_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__recipe_in__recip__1332DBDC",
                        column: x => x.recipe_id,
                        principalTable: "recipe",
                        principalColumn: "recipe_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "recipe_steps",
                columns: table => new
                {
                    step_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    recipe_id = table.Column<int>(type: "int", nullable: false),
                    step_number = table.Column<int>(type: "int", nullable: true),
                    step_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Recipe_s__B2E1DE81D1F8BA13", x => x.step_id);
                    table.ForeignKey(
                        name: "FK__Recipe_st__recip__5CD6CB2B",
                        column: x => x.recipe_id,
                        principalTable: "recipe",
                        principalColumn: "recipe_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "food_category",
                columns: new[] { "food_category_id", "food_category_name" },
                values: new object[,]
                {
                    { 2, "Efterrätt" },
                    { 1, "Huvudrätt" }
                });

            migrationBuilder.InsertData(
                table: "ingredients",
                columns: new[] { "ingredient_id", "calories (per 100g)", "ingredient_name" },
                values: new object[,]
                {
                    { 1, 130.0, "ris" },
                    { 15, 298.0, "kruka koriander" },
                    { 14, 251.0, "peppar" },
                    { 13, 0.0, "salt" },
                    { 12, 18.0, "körsbärstomater" },
                    { 11, 21.0, "sambal oelek" },
                    { 10, 125.0, "torkade röda linser" },
                    { 9, 437.80000000000001, "grönsaksbuljongtärning" },
                    { 7, 229.90000000000001, "kokosmjölk" },
                    { 6, 82.0, "tomatpure" },
                    { 5, 325.0, "curry" },
                    { 4, 160.0, "vitlöksklyfta" },
                    { 3, 884.10000000000002, "olja" },
                    { 2, 39.700000000000003, "gul lök" },
                    { 8, 0.0, "vatten" }
                });

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "measurement_id", "measurement_name" },
                values: new object[,]
                {
                    { 5, "g" },
                    { 1, "msk" },
                    { 3, "ml" },
                    { 2, "tsk" },
                    { 4, "dl" }
                });

            migrationBuilder.InsertData(
                table: "quantity",
                columns: new[] { "quantity_id", "quantity" },
                values: new object[,]
                {
                    { 1, 100.0 },
                    { 2, 10.0 },
                    { 3, 200.0 },
                    { 4, 400.0 },
                    { 5, 500.0 },
                    { 6, 250.0 },
                    { 7, 450.0 },
                    { 8, 15.0 }
                });

            migrationBuilder.InsertData(
                table: "recipe_source",
                columns: new[] { "recipe_source_id", "recipe_source_name", "recipe_source_URL" },
                values: new object[,]
                {
                    { 1, "ICA", "https://www.ica.se/recept" },
                    { 2, "Arla", "https://www.arla.se/recept" }
                });

            migrationBuilder.InsertData(
                table: "recipe",
                columns: new[] { "recipe_id", "duration", "food_category_id", "rating", "recipe_description", "recipe_name", "recipe_source_id" },
                values: new object[] { 1, 45, 1, 302, "Krämig och matig linsgryta värmer skönt en kall höstkväll. Grytan är smaksatt med vitlök, curry och sambal oelek och gjord med kokosmjölk för extra krämighet. Servera med ris, halverade körsbärstomater och toppa med färsk koriander.", "Linsgryta med kokosmjölk", 1 });

            migrationBuilder.InsertData(
                table: "recipe_ingredients",
                columns: new[] { "recipe_Ingredient_id", "ingredient_id", "measurement_id", "quantity_id", "recipe_id" },
                values: new object[,]
                {
                    { 1, 1, null, 1, 1 },
                    { 15, 15, null, 2, 1 },
                    { 14, 14, null, null, 1 },
                    { 13, 13, null, null, 1 },
                    { 12, 1, 5, 6, 1 },
                    { 11, 11, 5, 2, 1 },
                    { 9, 9, null, 2, 1 },
                    { 10, 10, 5, 3, 1 },
                    { 7, 7, 5, 4, 1 },
                    { 6, 6, 5, 3, 1 },
                    { 5, 5, 5, 2, 1 },
                    { 4, 4, null, 2, 1 },
                    { 3, 3, 5, 2, 1 },
                    { 2, 2, null, 2, 1 },
                    { 8, 8, 5, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "recipe_steps",
                columns: new[] { "step_id", "recipe_id", "step_description", "step_number" },
                values: new object[,]
                {
                    { 4, 1, "Dela tomaterna och vänd ner dem i grytan mot slutet av koktiden eller servera dem till. Smaka av grytan med salt och peppar. ", 4 },
                    { 1, 1, "Koka riset enligt anvisningen på förpackningen.", 1 },
                    { 2, 1, "Skala och hacka löken. Fräs den i oljan i en gryta.Pressa i vitlök och tillsätt curry och tomatpuré och fräs ytterligare någon minut.", 2 },
                    { 3, 1, "Rör i kokosmjölk, vatten, smulad buljongtärning, linser och sambal oelek.Låt koka ca 10 minuter eller enligt anvisningen på linsförpackningen.", 3 },
                    { 5, 1, "Servera grytan med ris och tomater och toppa med koriander.", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_recipe_food_category_id",
                table: "recipe",
                column: "food_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_recipe_source_id",
                table: "recipe",
                column: "recipe_source_id");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_ingredients_ingredient_id",
                table: "recipe_ingredients",
                column: "ingredient_id");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_ingredients_measurement_id",
                table: "recipe_ingredients",
                column: "measurement_id");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_ingredients_quantity_id",
                table: "recipe_ingredients",
                column: "quantity_id");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_ingredients_recipe_id",
                table: "recipe_ingredients",
                column: "recipe_id");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_steps_recipe_id",
                table: "recipe_steps",
                column: "recipe_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recipe_ingredients");

            migrationBuilder.DropTable(
                name: "recipe_steps");

            migrationBuilder.DropTable(
                name: "ingredients");

            migrationBuilder.DropTable(
                name: "measurements");

            migrationBuilder.DropTable(
                name: "quantity");

            migrationBuilder.DropTable(
                name: "recipe");

            migrationBuilder.DropTable(
                name: "food_category");

            migrationBuilder.DropTable(
                name: "recipe_source");
        }
    }
}
