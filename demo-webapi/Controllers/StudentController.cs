using System;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using Abt.Data;
using Abt.Models;

namespace Abt.Controllers
{
    [Route("api/students")]
    public class StudentController
    {
        private readonly AbtDataContext _db = new AbtDataContext();

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _db.Students;
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _db.Students.Where(x=> x.Id == id).FirstOrDefault();
        }

        [HttpPost]
        public Student Post([FromBody]Student model)
        {
			_db.Students.Add(model);
            _db.SaveChanges();

            return model;
        }

        [HttpPut("{id}")]
        public Student Put(int id, [FromBody]Student model)
        {
            var student = _db.Students.Where(x => x.Id == id).FirstOrDefault();
            _db.Entry<Student>(student).State = EntityState.Modified;
            _db.SaveChanges();

            return student;
        }

        [HttpDelete("{id}")]
        public Student Delete(int id)
        {
			var student = _db.Students.Where(x => x.Id == id).FirstOrDefault();
            _db.Remove(student);
            _db.SaveChanges();

            return student;
        }
    }

}