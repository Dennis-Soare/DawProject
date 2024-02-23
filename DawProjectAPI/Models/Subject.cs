using DawProjectAPI.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace DawProjectAPI.Models
{
    public class Subject : BaseEntity
    {
        [StringLength(100)]
        public string Name { get; set; }

        public IList<Student>? Students { get; set; }
        public IList<Book> Books { get; set; }
    }
}
