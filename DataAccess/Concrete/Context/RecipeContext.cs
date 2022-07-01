using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Context
{
    public class RecipeContext : DbContext
    {
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
                new Recipe { Id = 1, CategoryId = 1,Title="Falafel",Detail="böyle böyle yapılır",Image = "https://www.nefissyemektarifleri.com/wp-content/uploads/2018/07/falafel-tarifi.jpg"},
                new Recipe { Id = 2, CategoryId = 2,Title="Steak",Detail="böyle böyle yapılır",Image = "https://ozhacibeytepeoren.com/wp-content/uploads/2020/03/Dana-Antrikot-350x200.jpg"},
                new Recipe { Id = 3, CategoryId = 4, Title = "Fırında Lüfer", Detail = "böyle böyle yapılır", Image = "https://www.enpratikbilgiler.com/wp-content/uploads/2020/12/lufer-baligi-nasil-pisirilir-en-kolay-lufer-baligi-pisirme-yontemi-firinda-lufer-tarifi-VBBUiTP9.jpg" },
                new Recipe { Id = 4, CategoryId = 3,Title="Kruvasan",Detail="böyle böyle yapılır",Image = "https://cdn.yemek.com/mncrop/940/625/uploads/2014/10/kruvasan-tarifi.jpg"}
                );
           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Role> Roles { get; set; }
       
        

    }
}
