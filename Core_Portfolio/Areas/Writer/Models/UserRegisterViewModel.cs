using System.ComponentModel.DataAnnotations;

namespace Core_Portfolio.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Surname")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please Enter Your Surname")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage ="Please Enter Your Image Url")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter Your Password Again")]
        [Compare("Password", ErrorMessage ="Passwords Does Not Match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please Enter Your Mail Adress")]
        public string Mail { get; set; }
    }
}
