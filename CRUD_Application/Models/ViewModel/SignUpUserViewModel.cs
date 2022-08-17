using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Application.Models.ViewModel
{
    public class SignUpUserViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Username required")]
        [Remote(action: "UserNameIsExist", controller: "Account")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "please enter valid email")]

        public string Email { get; set; }
        [Required(ErrorMessage = "mobile number required")]
        [RegularExpression(@"^\(?([0-9]{3})?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",ErrorMessage ="mobile number is not valid")]
        public long? Mobile { get; set; }
        [Required(ErrorMessage = "password required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "confirm the password")]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="Confirmed password can't matched")]
        public string ConfirmPassword { get; set; }
        [Display(Name ="Active")]
        public bool IsActive { get; set; }
        
    }
}
