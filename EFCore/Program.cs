using EFCore.Data;
using EFCore.DbContexts;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext db = new ITIDbContext();

            List<Student> students = new List<Student>
                    {
                        new Student { FName = "Ahmed", LName = "Ali", Address = "Cairo", Age = 20 , Dept_Id = 1},
                        new Student { FName = "Mohamed", LName = "Ali", Address = "Giza", Age = 21 ,Dept_Id = 2 },
                        new Student { FName = "Ali", LName = "Mohamed", Address = "Alex", Age = 22 , Dept_Id =1 }
                    };

            db.Students.AddRange(students);
            db.SaveChanges();

            List<Department> departments = new List<Department>()
                {
                    new Department(){Name = "IT" , HiringDate = new DateTime(2024,6,20)} ,
                    new Department(){Name = "Developmenet" , HiringDate = new DateTime(2024,12,20)},
                };
            db.Departments.AddRange(departments);
            db.SaveChanges();


            List<Instructor> instructors = new List<Instructor>()
                {
                    new Instructor(){Name = "Ahmed", HourRate = 40, Bouns = 55, Adress = "Cairo", Salary = 20000 , Dept_ID = 1},
                    new Instructor(){Name = "Mohamed", HourRate = 50, Bouns = 60, Adress = "Giza", Salary = 25000 , Dept_ID = 2},
                    new Instructor(){Name = "Ali", HourRate = 60, Bouns = 70, Adress = "Alex", Salary = 30000 , Dept_ID = 1}
                };
            db.Instructors.AddRange(instructors);
            db.SaveChanges();

            //bool Flag = ITIDbContextSeeding.DataSeeding(db);
            //Console.WriteLine(Flag);


            var student01 = db.Students.FirstOrDefault(s => s.Id == 25);
            if (student01 != null)
                Console.WriteLine( $"{student01.FName } , {student01.Dept_Id}" );
               
            var Department01 = db.Departments.FirstOrDefault(d => d.ID == 1);
            if (Department01 != null)
            {
                Department01.Ins_ID = 1;
                db.SaveChanges();
            }


            var Department02 = db.Departments.Include(d => d.Instructors)
                                             .Where(d => d.ID == 1)
                                             .Select(d => new
                                             {
                                               DepartmentName = d.Name,
                                               Instructor = d.Instructors.Select(i => i.Name).FirstOrDefault()
                                             })
                                             .FirstOrDefault();
        }
    }
}
