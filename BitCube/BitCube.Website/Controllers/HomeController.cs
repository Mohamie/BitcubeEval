using BitCube.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitCube.Website.Controllers
{
    public class HomeController : Controller
    {
        private Lecturer lecture;
        private List<Student> students;
        private List<Degree> degrees;
        private List<Course> courses;

        public ActionResult Index()
        {
            //ViewBags for Table data
            LoadData();
            ViewBag.Students = students;
            ViewBag.Degrees = degrees;
            ViewBag.Lecture = lecture;

            //Select List for dropdown on 'Add Student' modal 
            SelectList selectList = new SelectList(degrees, "Id", "Name");
            ViewBag.DegreeSelect = selectList;

            return View();
        }

        //An Action menthod to filter courses according to a degree clicked
        [HttpGet]
        public ActionResult GetCoursesByDegreeId(int degreeId)
        {
            LoadData();
            return PartialView("_DegreeDetails", courses.Where(c => c.LinkedDegree.Id == degreeId).ToList());
        }

        //Hard Coded Data
        public void LoadData()
        {
            degrees = new List<Degree>();
            students = new List<Student>();
            courses = new List<Course>();

            lecture = new Lecturer()
            {
                ForeNames = "Thabelo Nelson",
                Surname = "Mohamie",
                DateOfBirth = new DateTime(1999, 02, 03),
                EmailAddress = "thabelo.590.nt@gmail.com",
                LecturingDegrees = degrees
            };

            degrees.Add(new Degree() { Id = 1, Name = "Bsc IT", Duration = 3, Lecturer = lecture });
            degrees.Add(new Degree() { Id = 2, Name = "Diploma in Project Management", Duration = 3, Lecturer = lecture });
            degrees.Add(new Degree() { Id = 3, Name = "Bsc Mathematics", Duration = 4, Lecturer = lecture });
            degrees.Add(new Degree() { Id = 5, Name = "Advanced Diploma in Information Systems", Duration = 4, Lecturer = lecture });

            courses.Add(new Course() { Name = "Technical Programming", Duration = 2, LinkedDegree = degrees[0] });
            courses.Add(new Course() { Name = "Software development", Duration = 2, LinkedDegree = degrees[0] });
            courses.Add(new Course() { Name = "Project Management", Duration = 1, LinkedDegree = degrees[1] });
            courses.Add(new Course() { Name = "Computer Science", Duration = 4, LinkedDegree = degrees[0] });
            courses.Add(new Course() { Name = "Deep Learning 101", Duration = 4, LinkedDegree = degrees[3] });
            courses.Add(new Course() { Name = "Actuarial Science", Duration = 4, LinkedDegree = degrees[2] });


            students.Add(new Student()
            {
                ForeNames = "Lerato Pretty",
                Surname = "Mohapi",
                EmailAddress = "mohapi@abc.com",
                DateOfBirth = new DateTime(2001, 06, 08),
                EnrolledDegree = degrees[0]
            });
            
            students.Add(new Student()
            {
                ForeNames = "Snethemba Maxwell",
                Surname = "Vitsha",
                EmailAddress = "vitsha@abc.com",
                DateOfBirth = new DateTime(1998, 03, 27),
                EnrolledDegree = degrees[3]
            });
            
            students.Add(new Student()
            {
                ForeNames = "Lerato Goodness",
                Surname = "Mkhwanazi",
                EmailAddress = "lola@abc.com",
                DateOfBirth = new DateTime(2001, 06, 08),
                EnrolledDegree = degrees[2]
            });
            
            students.Add(new Student()
            {
                ForeNames = "Mohau",
                Surname = "Modise",
                EmailAddress = "proficient@abc.com",
                DateOfBirth = new DateTime(1999, 12, 26),
                EnrolledDegree = degrees[3]
            });


        }

    }
}