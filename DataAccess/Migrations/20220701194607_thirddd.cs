using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class thirddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Detail",
                value: "Bir gece önceden suda beklettiğiniz nohutun suyunu süzün ve bir rondonun içine dökün.(Nohutlar haşlanmayacak.)Nohutların üzerine önceden küp küp doğradığınız soğanları, sarımsakları ilave ederek rondoyu bir kez çalıştırın.Ardından doğradığınız maydonozları, taze soğanı ekleyip rondoda karıştırın. Robot malzemeleri çektikten sonra kendiniz de bir spatula yardımıyla mutlaka biraz karıştırın. Karışıma tüm baharatları ve karbonatı da ekleyip tekrar rondoda çekin.Hazırlanan karışımı derin bir kabın içerisine alıp unu ekleyip yoğurun. Hazır olduğunda üzerini bir streç film ile kaplayıp 1 saat buzdolabında bekletin.Bu sırada sosu hazırlamak için süzme yoğurdun içine sarımsağı, tahini, limon suyunu ekleyip güzelce karıştırın.Buzdolabından çıkartttığınız falafel harcından elinizle cevizden küçük parçalar alarak yuvarlayın.Falafel köfteleriniz hazır olduğunda iyice kızdırdığınız yağın içerisine atıp kızartmaya başlayın.Falafelleri kızartırken içlerinin güzelce pişmesi için orta ateşte kızartmaya dikkat edin.Kızarttğınız falafel köftelerini hazırladığınız sos ile birlikte servis edebilirsiniz. Afiyet olsun!");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Detail",
                value: "Biftekleri, ısıttığınız yapışmaz yüzeyli bir tavada mühürleyin. Tereyağını bir tencerede eritin. Piyazlık doğradığınız soğanları ilave edip 3-4 dakika kavurun. Mühürlediğiniz etleri soğanların üzerine alın.Maden suyu, un, salça ve suyu bir kasede pürüzsüz bir kıvam elde edinceye kadar çırpın.Maden sulu harcı bifteklerin üzerine ilave edin.Tuz ve karabiberle tatlandırın.Kısık ateşte 45-50 dakika kadar pişirin.Sıcak servis yapın.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Detail",
                value: "Balıkları temizleyip bol suyla yıkayın. Süzgece alıp suyunu süzün. Balıkların üzerinde bıçakla derin olmayan uzunlamasına kesikler yapın.Soğanları soyup yarım halka şeklinde doğrayın.Maydanozu temizleyip kıyın. ivri biberleri temizleyip ince halkalar şeklinde doğrayın.Sebzeleri bir kaba alın. Üzerine tuz ve karabiber ekleyip harmanlayın. Balıkları limon suyu ve zeytinyağıyla ovun. Balıkları dikdörtgen kesilmiş yağlı kağıtların içine yerleştirin.Üzerine domatesli karışımdan yayıp kağıtların kenarlarını sıkıca kapatın.Önceden ısıtılmış 180 dereceye ayarlı fırında 35-40 dakika pişirin.  Sıcak olarak servis yapın.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Detail",
                value: "Şeker, ılık su ve mayayı yoğurma kabına alıp mayanın aktif hale gelmesini bekleyin.Daha sonra sütü sıvı yağı yumurtayı ve tuzu da ekleyip güzelce karıştırın.Unu azar azar ekleyerek yoğurmaya başlayın. Hamur kıvama geldikten sonra 5-10 dakika daha yoğurun. 15 dakika üzerini nemli bezle kapatarak dinlendirin.Dinlenen hamuru 14 eşit parçaya bölüp bezeler halime getirin. İlk 7’sini alıp tabak büyüklüğünde nişasta kullanarak açın.Her kata eritilmiş tereyağından sürerek üst üst koyun. En üst hamura yağ sürmüyoruz kenara alıp üzerlerini örtün. Kalan 7 beze içinde aynı işlemi yapın.İlk açtığınız 7’li yağlanmış hamuru alıp ellerinizle bastırıp kenarlarından çekiştirerek açın. Açtığınız hamuru 12 eşit parçaya bölüp içlerine birer tatlı kaşığı nutella sürün ve sarın.Yarım saat tepsi mayası için bekleyin. (bu adımı atlamayın lütfen) Yarım saat dolduktan sonra yumurta sarılarını sürüp 200 derece önceden ısıtılmış fırında üzerleri güzelce kızarana kadar pişirin. Yumuşacık harika bir atıştırmalık olacak kolay gelsin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientsId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    Slug = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialsId);
                    table.ForeignKey(
                        name: "FK_Materials_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Detail",
                value: "böyle böyle yapılır");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Detail",
                value: "böyle böyle yapılır");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Detail",
                value: "böyle böyle yapılır");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Detail",
                value: "böyle böyle yapılır");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_RecipeId",
                table: "Materials",
                column: "RecipeId");
        }
    }
}
