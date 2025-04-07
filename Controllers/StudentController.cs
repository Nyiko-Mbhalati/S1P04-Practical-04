using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nyikoStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ListStudents()
        {
            List<Models.StudentModel> students = new List<Models.StudentModel>();

            students.Add(new Models.StudentModel { _studentNumber = "u24722490", _name = "Nyiko", _surname = "Mbhalati", _emailAddress = "u24722490@tuks.co.za", myLink = "~/HTML/HtmlPageNyiko.html"});
            students.Add(new Models.StudentModel { _studentNumber = "u24641342", _name = "Michael", _surname = "Neto", _emailAddress = "u24641342@tuks.co.za", myLink = "~/HTML/HtmlPageMichael.html" });
            students.Add(new Models.StudentModel { _studentNumber = "u24704785", _name = "Busisiwe", _surname = "Paul", _emailAddress = "u24704785@tuks.co.za", myLink = "~/HTML/HtmlPageBusi.html" });
            students.Add(new Models.StudentModel { _studentNumber = "u24687945", _name = "Naledi", _surname = "Nkwana", _emailAddress = "u24687945@tuks.co.za", myLink = "~/HTML/HtmlPageNaledi.html" });
            students.Add(new Models.StudentModel { _studentNumber = "u22675524", _name = "Thato", _surname = "Modise", _emailAddress = "u22675524@tuks.co.za", myLink = "~/HTML/HtmlPageThato.html" });

            return View(students);
        }
    }
}