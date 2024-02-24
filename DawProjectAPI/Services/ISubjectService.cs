using DawProjectAPI.Models;

namespace DawProjectAPI.Services
{
    public interface ISubjectService
    {
        public void CreateNewSubject(Subject s);
        public void CreateNewBook(Book b);
        public List<Book> GetAllBooks();
        public List<Subject> GetAllSubjects();
        public Subject GetSubjectById(Guid id);
        public Subject GetSubjectByName(string name);
    }
}
