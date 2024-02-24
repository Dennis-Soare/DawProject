using DawProjectAPI.Data;
using DawProjectAPI.Models;

namespace DawProjectAPI.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private ApplicationDbContext _dbContext;

        public SubjectRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateNewSubject(Subject subject)
        {
            _dbContext.Subjects.Add(subject);
            _dbContext.SaveChanges();
        }
        public void CreateNewBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }
        public List<Subject> GetAllSubjects()
        {
            return _dbContext.Subjects.ToList();
        }
        public List<Book> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }
        public Subject GetSubjectById(Guid id) 
        {
            return _dbContext.Subjects.SingleOrDefault(s => s.Id == id);
        }
        public Subject GetSubjectByName(string name)
        {
            return _dbContext.Subjects.SingleOrDefault(s => s.Name == name);
        }
    }
}
