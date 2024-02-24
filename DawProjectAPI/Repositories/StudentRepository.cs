using DawProjectAPI.Data;
using DawProjectAPI.Models;
using Demo.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace DawProjectAPI.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context) { }
        
        public async Task<List<Student>> GetStudentsWithSubjecs()
        {
            return await _table.Include(x => x.StudentSubjects).ThenInclude(x => x.Student).ToListAsync();
        }
    }
}
