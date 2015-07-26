using System;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using MvcDi.Data;
using MvcDi.Models;
using MvcDi.Repositories;

namespace MvcDi.Controllers
{
    [Route("api/students")]
    public class StudentController
    {
        private IStudentRepository _repository;
        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _repository.Get();
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _repository.Get(id);
        }

        [HttpPost]
        public Student Post([FromBody]Student model)
        {
            _repository.Post(model);
            return model;
        }

        [HttpPut("{id}")]
        public string Put(int id, [FromBody]Student model)
        {
            _repository.Update(model);
            return "Atualizado";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            _repository.Delete(id);
            return "Excluido";
        }
    }

}