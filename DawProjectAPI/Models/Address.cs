using DawProjectAPI.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace DawProjectAPI.Models
{
    public class Address : BaseEntity
    {
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string Street { get; set; }
        public int Number {  get; set; }
        public Student? Student { get; set; }
    }
}
