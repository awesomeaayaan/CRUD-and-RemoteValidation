using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Application.Models.ViewModel
{
    public class LoginSignUpViewModel
    {
        
        [Required(ErrorMessage ="Username is required")]
       
        public string UserName { get; set; }
        
        
        public string Password { get; set; }
        [Required(ErrorMessage = " password is required")]
        
       
        [Display(Name ="Remember Me")]
        public bool IsRemember { get; set; }
    }
}
