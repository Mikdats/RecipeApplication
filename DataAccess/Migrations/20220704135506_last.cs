using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Recipes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Ingredients",
                value: "1,5su bardağı ,nohut(bir gece önceden ıslatılmış),1adet orta boy soğan,2 diş sarımsak,1 çay kaşığı kabartma tozu, 1 çay kaşığı kişniş(arzuya göre),1/4 demet maydanoz,2dal taze soğan,1 çay kaşığı kimyon,1 çay kaşığı tuz,1 çay kaşığı taze çekilmiş tane karabiber,1 çay kaşığı toz kırmızı biber,2 yemek kaşığı un,Kızartmak için:1 su bardağı ayçiçek yağı,Sosu için:1 su bardağı süzme yoğurt,1 yemek kaşığı tahin,2 diş sarımsak ,1yemek kaşığı limon suyu");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Ingredients",
                value: "600-700 gram kontrfile,5 diş sarımsak,1 adet büyük boy soğan,1 dal taze kekik ,1 dal taze biberiye,4-5 top karabiber,1 yemek kaşığı kırmızı şarap sirkesi,1 tatlı kaşığı worcestershire sos,1 çay kaşığı deniz tuzu,2 yemek kaşığı zeytinyağı,2 yemek kaşığı çiçek yağı");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Ingredients",
                value: "1 kilo lüfer,Sarımsak,Kuru Soğan(kendinize göre artırıp azaltabilirsiniz),3-4 adet orta boy patates,Limon,Zeytinyağı,Tuz");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Ingredients",
                value: "1 yemek kaşığı şeker,1 paket yaş maya(kuru maya da olur),1 çay bardağı ılık su,1 su bardağı ılık süt,1 çay bardağı sıvı yağ,1 tane oda sıcaklığında yumurta,1 tatlı kaşığı tuz,4-4, 5 su bardağı un,Hamuru açmak için nişasta,Hamurun aralarına sürmek için eritilmiş tereyağı");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Recipes");
        }
    }
}
