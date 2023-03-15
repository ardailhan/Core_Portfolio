using System.ComponentModel.DataAnnotations;

namespace Core_Portfolio.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Username")]
        [Required(ErrorMessage ="Please Enter Your Username")]
        public string Username { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }
    }
}
