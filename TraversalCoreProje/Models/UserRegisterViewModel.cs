using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }
    }
}
