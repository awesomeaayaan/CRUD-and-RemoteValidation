using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Application.Models.ViewModel
{
    public class ImageCreateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name="Choose images")]
        public IFormFile ImagePath { get; set; }

    }
}
