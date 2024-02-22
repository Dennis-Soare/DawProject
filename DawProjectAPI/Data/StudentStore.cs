using DawProjectAPI.Models.DTOs;

namespace DawProjectAPI.Data
{
    public static class StudentStore
    {
        public static List<StudentDTO> studetList = new List<StudentDTO>
        {
            new StudentDTO{Id=1, Name="Name 1"} ,
            new StudentDTO{Id=2, Name="Name 2"}
        };
    }
}
