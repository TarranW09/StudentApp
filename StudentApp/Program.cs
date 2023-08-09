using System;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDbContext())
            {
                var newStudent = new Student { FirstName = "Tarran", LastName = "Wylie" };
                context.Students.Add(newStudent);
                context.SaveChanges();
                Console.WriteLine("Student added to the database.");
            }
        }
    }
}

