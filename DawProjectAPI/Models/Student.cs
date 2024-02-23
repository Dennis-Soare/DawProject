using DawProjectAPI.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DawProjectAPI.Models
{
    public class Student : BaseEntity
    {
        [StringLength(100)]
        public string Name { get; set; }
        public string Cnp { get; set; }
        public IList<Subject> Subjects { get; set; }
        public Address Address { get; set; }
    }
}
