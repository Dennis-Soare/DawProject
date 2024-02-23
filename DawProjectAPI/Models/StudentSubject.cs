using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DawProjectAPI.Models
{
    public class StudentSubject
    {
        [Key]
        public Guid StudentSubjectId { get; set; }
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }
        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
    }
}
