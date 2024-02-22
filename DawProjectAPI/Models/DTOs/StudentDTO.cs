using System.ComponentModel.DataAnnotations;

namespace DawProjectAPI.Models.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
