using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    internal class Stud_Course
    {
        [Key, Column(Order = 0)]
        public int Stud_ID { get; set; }
        [Key, Column(Order = 1)]
        public int Course_ID { get; set; }
        public double Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
