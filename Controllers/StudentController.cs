using nyikoStudyGroup.Models;
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

        //List<Models.StudentModel> Students = new List<Models.StudentModel>();

        //public ActionResult ListStudents()
        //{
        //    List<Models.StudentModel> students = new List<Models.StudentModel>();

        //    students.Add(new Models.StudentModel { _studentNumber = "u24722490", _name = "Nyiko", _surname = "Mbhalati", _emailAddress = "u24722490@tuks.co.za", myLink = "~/HTML/HtmlPageNyiko.html", Id = 1});
        //    students.Add(new Models.StudentModel { _studentNumber = "u24641342", _name = "Michael", _surname = "Neto", _emailAddress = "u24641342@tuks.co.za", myLink = "~/HTML/HtmlPageMichael.html", Id = 2 });
        //    students.Add(new Models.StudentModel { _studentNumber = "u24704785", _name = "Busisiwe", _surname = "Paul", _emailAddress = "u24704785@tuks.co.za", myLink = "~/HTML/HtmlPageBusi.html", Id = 3 });
        //    students.Add(new Models.StudentModel { _studentNumber = "u24687945", _name = "Naledi", _surname = "Nkwana", _emailAddress = "u24687945@tuks.co.za", myLink = "~/HTML/HtmlPageNaledi.html", Id = 4 });
        //    students.Add(new Models.StudentModel { _studentNumber = "u22675524", _name = "Thato", _surname = "Modise", _emailAddress = "u22675524@tuks.co.za", myLink = "~/HTML/HtmlPageThato.html", Id = 5 });

        //    return View(students);
        //}

        public List<Models.StudentModel> students
        {
            get
            {
                if (Session["Students"] == null)
                {
                    Session["Students"] = new List<Models.StudentModel>
                    {
                       new Models.StudentModel { _studentNumber = "u24722490", _name = "Nyiko", _surname = "Mbhalati", _emailAddress = "u24722490@tuks.co.za", myLink = "~/HTML/HtmlPageNyiko.html", Id = 1},
                       new Models.StudentModel { _studentNumber = "u24641342", _name = "Michael", _surname = "Neto", _emailAddress = "u24641342@tuks.co.za", myLink = "~/HTML/HtmlPageMichael.html", Id = 2 },
                       new Models.StudentModel { _studentNumber = "u24704785", _name = "Busisiwe", _surname = "Paul", _emailAddress = "u24704785@tuks.co.za", myLink = "~/HTML/HtmlPageBusi.html", Id = 3 },
                       new Models.StudentModel { _studentNumber = "u24687945", _name = "Naledi", _surname = "Nkwana", _emailAddress = "u24687945@tuks.co.za", myLink = "~/HTML/HtmlPageNaledi.html", Id = 4 },
                       new Models.StudentModel { _studentNumber = "u22675524", _name = "Thato", _surname = "Modise", _emailAddress = "u22675524@tuks.co.za", myLink = "~/HTML/HtmlPageThato.html", Id = 5 },
                    };
                }
                return Session["Students"] as List<Models.StudentModel>;
            }
            set
            {
                Session["Students"] = value;
            }
        }

        public ActionResult ListStudents()
        {
            return View(students);
        }

        public ActionResult Delete(int? i)
        {
            var st = students.Find(c => c.Id == i);
            students.Remove(st);
            return View("ListStudents", students);
        }
    }
}