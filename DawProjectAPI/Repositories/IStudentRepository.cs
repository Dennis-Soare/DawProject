using DawProjectAPI.Models;
using Demo.Repository.GenericRepository;

namespace DawProjectAPI.Repositories
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        public Task<List<Student>> GetStudentsWithSubjecs();
        public Task<List<Student>> FindRange(List<Guid> studentsIds);
    }
}
