using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DawProjectAPI.Models
{
    public class Student 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public Guid AddressId { get; set; }
        public IList<StudentSubject> StudentSubjects { get; set; }
    }
}
