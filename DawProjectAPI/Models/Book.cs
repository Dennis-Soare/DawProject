using DawProjectAPI.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace DawProjectAPI.Models
{
    public class Book : BaseEntity
    {
        [StringLength(100)]
        public string Title { get; set; }
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
