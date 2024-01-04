using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Assignment
{
    internal class Program
    {
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
        }

        public class StudentDbContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
        }

        static void Main(string[] args)
        {
            using (var ctx = new StudentDbContext())
            {
                Console.Write("Enter student name:");
                var studentName = Console.ReadLine();
                var student = new Student()
                {
                    StudentId = 1,
                    StudentName = studentName
                };
                ctx.Students.Add(student);
                ctx.SaveChanges();

                // Fetching
                var query = from s in ctx.Students
                            select s;
                Console.WriteLine("All student names in the Students table are:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }
            }
        }
    }
}
