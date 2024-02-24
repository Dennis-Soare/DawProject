using System.ComponentModel.DataAnnotations.Schema;

namespace DawProjectAPI.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
