using System.Collections.Generic;
using MvcDi.Models;
using MvcDi.Data;
using System.Linq;

namespace MvcDi.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MvcDiDataContext _db = new MvcDiDataContext();
        public IEnumerable<Student> Get()
        {
            return _db.Students.AsEnumerable();
        }

        public Student Get(int id)
        {
            return _db.Students.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Post(Student entity)
        {
            _db.Students.Add(entity);
            _db.SaveChanges();
        }

        public void Update(Student entity)
        {
            _db.Entry<Student>(entity).State = Microsoft.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var student = _db.Students.Where(x => x.Id == id).FirstOrDefault();
            _db.Students.Remove(student);
            _db.SaveChanges();
        }
	}
}