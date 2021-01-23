using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitCube.Section3.Data
{
    /// <summary>
    /// Dummy Data Access Layer Class
    /// </summary>
    public class SampleDataService
    {
        private static List<Student> students = new List<Student>();
        private static List<Degree> degrees;
        private static List<Course> courses;
        private static Lecturer lecturer;

        public SampleDataService()
        {
            LoadData();
        }

        private void LoadData()
        {
            InitDegreesData();
            InitStudentsData();
            InitCourses();
        }

        private void InitStudentsData()
        {
            students = new List<Student>();

            students.Add(new Student()
            {
                Id = 1,
                ForeNames = "John",
                Surname = "Smith",
                EmailAddress = "smith@abc.com",
                DateOfBirth = new DateTime(1990, 06, 08),
                EnrolledDegree = degrees[1]
            });

            students.Add(new Student()
            {
                Id = 2,
                ForeNames = "Snethemba Maxwell",
                Surname = "Vitsha",
                EmailAddress = "vitsha@gmail.com",
                DateOfBirth = new DateTime(1998, 03, 27),
            });

            students.Add(new Student()
            {
                Id = 3,
                ForeNames = "Lerato Goodness",
                Surname = "Mkhwanazi",
                EmailAddress = "lola@abc.com",
                DateOfBirth = new DateTime(2001, 06, 08)
            });
        }

        private void InitDegreesData()
        {
            degrees =  new List<Degree>();
            lecturer = new Lecturer()
            {
                Id = 2,
                ForeNames = "Thabelo Nelson",
                Surname = "Mohamie",
                DateOfBirth = new DateTime(1999, 02, 03),
                EmailAddress = "thabelo.590.nt@gmail.com",
                LecturingDegrees = degrees
            };

            
            degrees.Add(new Degree() { Id = 0, Name = "Bsc IT", Duration = 3, Lecturer = lecturer });
            degrees.Add(new Degree() { Id = 1, Name = "Diploma in Project Management", Duration = 3, Lecturer = lecturer });
            degrees.Add(new Degree() { Id = 2, Name = "Bsc Mathematics", Duration = 4, Lecturer = lecturer });
            degrees.Add(new Degree() { Id = 3, Name = "Advanced Diploma in Information Systems", Duration = 4, Lecturer = lecturer });

            
        }

        private void InitCourses()
        {
            courses = new List<Course>();
            courses.Add(new Course() { Name = "Technical Programming", Duration = 2, LinkedDegree = degrees[0] });
            courses.Add(new Course() { Name = "Software development", Duration = 2, LinkedDegree = degrees[0] });
            courses.Add(new Course() { Name = "Project Management", Duration = 1, LinkedDegree = degrees[1] });
            courses.Add(new Course() { Name = "Computer Science", Duration = 4, LinkedDegree = degrees[0] });
            courses.Add(new Course() { Name = "Deep Learning 101", Duration = 4, LinkedDegree = degrees[3] });
            courses.Add(new Course() { Name = "Actuarial Science", Duration = 4, LinkedDegree = degrees[2] });
        }

        public static List<Student> GetAllStudents()
        {
            return students;
        }

        public static void AddStudent(Student newStudent)
        {
            students.Add(newStudent);
        }

        public static Student GetStudentById(int studentId)
        {
            return students.Where(s => s.Id == studentId).FirstOrDefault();
        }

        public static Student EnrollStudent(int studentId, Degree degree)
        {
            Student updateStudent = null;

            foreach (var student in students.Where(s => s.Id == studentId))
            {
                student.EnrolledDegree = degree;
                updateStudent = student;
            }

            return updateStudent;
        }


        public static List<Degree> GetAllDegrees()
        {
            return degrees;
        }

        public static void RemoveDegreeFromStudent(int studentId)
        {

            foreach(var student in students.Where(s => s.Id == studentId))
            {
                student.EnrolledDegree = null;
            }
        }
        
        public static List<Course> GetAllCourses()
        {
            return courses;
        }

        



    }
}
