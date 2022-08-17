using System.ComponentModel.DataAnnotations;

namespace CRUD_Application.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

    }
}
