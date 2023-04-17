using System.ComponentModel.DataAnnotations;

namespace NetCore_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen  soyadınızı giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen resim url değeri giriniz")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage="Lütfen kullanıcı adını giriniz")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Mail { get; set; }
    }
}
