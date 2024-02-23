
namespace DawProjectAPI.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number {  get; set; }
        public Student? Student { get; set; }
    }
}
