using System.Collections.Generic;
using MvcDi.Models;

namespace MvcDi.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> Get();
        Student Get(int id);
        void Post(Student entity);
        void Update(Student entity);
        void Delete(int id);
    }
}