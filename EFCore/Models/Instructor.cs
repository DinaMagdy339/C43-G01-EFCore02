using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Adress { get; set; }
        public double HourRate { get; set; }
        public double Bouns { get; set; }
        public int Dept_ID { get; set; }
        public Department Department { get; set; }
        public ICollection<Course_Inst> Course_Insts { get; set; } = new HashSet<Course_Inst>();

    }
}
