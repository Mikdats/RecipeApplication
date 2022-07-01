using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 2, "Meat" },
                    { 3, "Breakfast" },
                    { 4, "Sea Food" }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Title" },
                values: new object[] { "https://www.nefissyemektarifleri.com/wp-content/uploads/2018/07/falafel-tarifi.jpg", "Falafel" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Detail", "Image", "Slug", "Title" },
                values: new object[] { 2, 2, "böyle böyle yapılır", "https://ozhacibeytepeoren.com/wp-content/uploads/2020/03/Dana-Antrikot-350x200.jpg", 2, "Steak" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Detail", "Image", "Slug", "Title" },
                values: new object[] { 4, 3, "böyle böyle yapılır", "https://cdn.yemek.com/mncrop/940/625/uploads/2014/10/kruvasan-tarifi.jpg", 2, "Kruvasan" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Detail", "Image", "Slug", "Title" },
                values: new object[] { 3, 4, "böyle böyle yapılır", "https://www.enpratikbilgiler.com/wp-content/uploads/2020/12/lufer-baligi-nasil-pisirilir-en-kolay-lufer-baligi-pisirme-yontemi-firinda-lufer-tarifi-VBBUiTP9.jpg", 2, "Fırında Lüfer" });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes");

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Title" },
                values: new object[] { "http://www.veganyemekler.com/wp-content/uploads/2013/08/vegan-aksam-yemegi2.jpg", "Kinoalı salata" });
        }
    }
}
