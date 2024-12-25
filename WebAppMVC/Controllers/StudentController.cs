using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            StudentBusinessLayer studentBL = new StudentBusinessLayer();
            Student studentDetail = studentBL.GetById(1);

            return View(studentDetail);
        }
        public IActionResult Details(int id)
        {
            StudentBusinessLayer studentBL = new StudentBusinessLayer();
            Student studentDetail = studentBL.GetById(id);

            return View(studentDetail);
        }
    }
}
