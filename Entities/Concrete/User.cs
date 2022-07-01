using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "E-Posta alanı gereklidir!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı kısmı gereklidir!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir!")]
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }


    }
}
