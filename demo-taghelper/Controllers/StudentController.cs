using Microsoft.AspNet.Mvc;
using MvcDi.Models;
using MvcDi.Repositories;

namespace MvcDi.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository _repository;
        
        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.Get());
        }
        
        public IActionResult Create()
        {
            return View();
        }
    }

}