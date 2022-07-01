using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Context
{
    public class RecipeContext : DbContext
    {
        #region recipedetailss
        public readonly string Falafel = "Bir gece önceden suda beklettiğiniz nohutun suyunu süzün ve bir rondonun içine dökün.(Nohutlar haşlanmayacak.)Nohutların üzerine önceden küp küp doğradığınız soğanları, sarımsakları ilave ederek rondoyu bir kez çalıştırın.Ardından doğradığınız maydonozları, taze soğanı ekleyip rondoda karıştırın. Robot malzemeleri çektikten sonra kendiniz de bir spatula yardımıyla mutlaka biraz karıştırın. Karışıma tüm baharatları ve karbonatı da ekleyip tekrar rondoda çekin.Hazırlanan karışımı derin bir kabın içerisine alıp unu ekleyip yoğurun. Hazır olduğunda üzerini bir streç film ile kaplayıp 1 saat buzdolabında bekletin.Bu sırada sosu hazırlamak için süzme yoğurdun içine sarımsağı, tahini, limon suyunu ekleyip güzelce karıştırın.Buzdolabından çıkartttığınız falafel harcından elinizle cevizden küçük parçalar alarak yuvarlayın.Falafel köfteleriniz hazır olduğunda iyice kızdırdığınız yağın içerisine atıp kızartmaya başlayın.Falafelleri kızartırken içlerinin güzelce pişmesi için orta ateşte kızartmaya dikkat edin.Kızarttğınız falafel köftelerini hazırladığınız sos ile birlikte servis edebilirsiniz. Afiyet olsun!";
        public readonly string Kruvasan = "Şeker, ılık su ve mayayı yoğurma kabına alıp mayanın aktif hale gelmesini bekleyin.Daha sonra sütü sıvı yağı yumurtayı ve tuzu da ekleyip güzelce karıştırın.Unu azar azar ekleyerek yoğurmaya başlayın. Hamur kıvama geldikten sonra 5-10 dakika daha yoğurun. 15 dakika üzerini nemli bezle kapatarak dinlendirin.Dinlenen hamuru 14 eşit parçaya bölüp bezeler halime getirin. İlk 7’sini alıp tabak büyüklüğünde nişasta kullanarak açın.Her kata eritilmiş tereyağından sürerek üst üst koyun. En üst hamura yağ sürmüyoruz kenara alıp üzerlerini örtün. Kalan 7 beze içinde aynı işlemi yapın.İlk açtığınız 7’li yağlanmış hamuru alıp ellerinizle bastırıp kenarlarından çekiştirerek açın. Açtığınız hamuru 12 eşit parçaya bölüp içlerine birer tatlı kaşığı nutella sürün ve sarın.Yarım saat tepsi mayası için bekleyin. (bu adımı atlamayın lütfen) Yarım saat dolduktan sonra yumurta sarılarını sürüp 200 derece önceden ısıtılmış fırında üzerleri güzelce kızarana kadar pişirin. Yumuşacık harika bir atıştırmalık olacak kolay gelsin";
        public readonly string FırındaLufer = "Balıkları temizleyip bol suyla yıkayın. Süzgece alıp suyunu süzün. Balıkların üzerinde bıçakla derin olmayan uzunlamasına kesikler yapın.Soğanları soyup yarım halka şeklinde doğrayın.Maydanozu temizleyip kıyın. ivri biberleri temizleyip ince halkalar şeklinde doğrayın.Sebzeleri bir kaba alın. Üzerine tuz ve karabiber ekleyip harmanlayın. Balıkları limon suyu ve zeytinyağıyla ovun. Balıkları dikdörtgen kesilmiş yağlı kağıtların içine yerleştirin.Üzerine domatesli karışımdan yayıp kağıtların kenarlarını sıkıca kapatın.Önceden ısıtılmış 180 dereceye ayarlı fırında 35-40 dakika pişirin.  Sıcak olarak servis yapın.";
        public readonly string Steak = "Biftekleri, ısıttığınız yapışmaz yüzeyli bir tavada mühürleyin. Tereyağını bir tencerede eritin. Piyazlık doğradığınız soğanları ilave edip 3-4 dakika kavurun. Mühürlediğiniz etleri soğanların üzerine alın.Maden suyu, un, salça ve suyu bir kasede pürüzsüz bir kıvam elde edinceye kadar çırpın.Maden sulu harcı bifteklerin üzerine ilave edin.Tuz ve karabiberle tatlandırın.Kısık ateşte 45-50 dakika kadar pişirin.Sıcak servis yapın.";
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=RecipeDB; integrated security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Email = "admin@gmail.com", Password = "1234", UserName = "Admin", RoleId = 1 },
                new User { UserId = 2, Email = "moderator@gmail.com", Password = "1234", UserName = "Moderator", RoleId = 2 }
                );
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Admin" },
                new Role { RoleId = 2, RoleName = "Moderator" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName ="Vegan"},
                new Category { CategoryId = 2, CategoryName ="Meat"},
                new Category { CategoryId = 3, CategoryName ="Breakfast"},
                new Category { CategoryId = 4, CategoryName ="Sea Food"}
                );
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe { Id = 1, CategoryId = 1,Title="Falafel",Detail=Falafel,Image = "https://www.nefissyemektarifleri.com/wp-content/uploads/2018/07/falafel-tarifi.jpg"},
                new Recipe { Id = 2, CategoryId = 2,Title="Steak",Detail=Steak,Image = "https://ozhacibeytepeoren.com/wp-content/uploads/2020/03/Dana-Antrikot-350x200.jpg"},
                new Recipe { Id = 3, CategoryId = 4, Title = "Fırında Lüfer", Detail = FırındaLufer, Image = "https://www.enpratikbilgiler.com/wp-content/uploads/2020/12/lufer-baligi-nasil-pisirilir-en-kolay-lufer-baligi-pisirme-yontemi-firinda-lufer-tarifi-VBBUiTP9.jpg" },
                new Recipe { Id = 4, CategoryId = 3,Title="Kruvasan",Detail=Kruvasan,Image = "https://cdn.yemek.com/mncrop/940/625/uploads/2014/10/kruvasan-tarifi.jpg"}
                );
           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Role> Roles { get; set; }

        

    }
}
