using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public double Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }
        public ICollection<Course_Inst> Course_Insts { get; set; } = new List<Course_Inst>();
        public ICollection<Stud_Course> Courses { get; set; } = new HashSet<Stud_Course>();

        public Topic Topic { get; set; } = null;
    }
}
