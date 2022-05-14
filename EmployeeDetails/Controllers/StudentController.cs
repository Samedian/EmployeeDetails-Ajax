using EmployeeDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeDetails.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        StudentContext context = new StudentContext();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getStudent(string id)
        {
            List<Students> students = new List<Students>();
            students = context.Students.ToList();
            return Json(students, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult createStudent()
        {
            return View();
        }
        [HttpPost]   
        public ActionResult createStudent(Students std)
        {
            context.Students.Add(std);
            context.SaveChanges();
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }
    }
}