using System.ComponentModel.DataAnnotations;

namespace DawProjectAPI.Models
{
    public class Subject
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public IList<Book>? Books { get; set; }
        public IList<StudentSubject> StudentSubjects { get; set; }
    }
}
