using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISchool.Framework.Entities
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
    }

    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    }

    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("name=ISchoolDb") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
    [DataObject]
    public class MyBLL
    {
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public List<Student> ListAllStudents()
        {
            using (var context = new SchoolContext())
            {
                return context.Students.ToList();
            }
        }
    } 
}
