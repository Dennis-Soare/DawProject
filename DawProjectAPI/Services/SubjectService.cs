using DawProjectAPI.Models;
using DawProjectAPI.Repositories;

namespace DawProjectAPI.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;
        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public void CreateNewSubject(Subject s)
        {
            _subjectRepository.CreateNewSubject(s);
        }
        public void CreateNewBook(Book b)
        {
            _subjectRepository.CreateNewBook(b);
        }
        public List<Book> GetAllBooks()
        {
            return _subjectRepository.GetAllBooks();
        }
        public List<Subject> GetAllSubjects()
        {
            return _subjectRepository.GetAllSubjects();
        }
        public Subject GetSubjectById(Guid id)
        {
            return _subjectRepository.GetSubjectById(id);
        }
        public Subject GetSubjectByName(string name)
        {
            return _subjectRepository.GetSubjectByName(name);
        }
    }
}
