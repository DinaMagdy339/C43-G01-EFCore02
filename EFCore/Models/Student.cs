using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Dept_Id { get; set; }
       public Department Department { get; set; }
       public ICollection<Stud_Course>? Courses { get; set; } = new HashSet<Stud_Course>();
    }
}
