using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>
            {  
                new Student
                {
                    StudentId = 1,
                    Name = "Tom",
                    TotalMarks = 800
                },
            new Student
            {
                StudentId = 2,
                Name = "Mary",
                TotalMarks = 900
            },
            new Student
            {
                StudentId = 3,
                Name = "Pam",
                TotalMarks = 800
            },
            new Student
            {
                StudentId = 4,
                Name = "Tom",
                TotalMarks = 800
            },
            new Student
            {
                StudentId = 5,
                Name = "John",
                TotalMarks = 500
            },
            };
                return listStudents;
            
        }
    }
}
