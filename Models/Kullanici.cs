using System.ComponentModel.DataAnnotations;

namespace ViewHelpers.Models
{
    public class Kullanici
    {
        //DataAnnotation yöntemi ile helper metotlarımız burada eklediğimiz özellikleri html olarka render eder..
        [Required(ErrorMessage ="Kullanıcı Adı Zorunludur")]
        [Display(Name ="Kullanıcı Adınız")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage ="Şifre Zorunludur")]
        [Display(Name = "Şifreniz")]
        public string Sifre { get; set; }
    }
}
