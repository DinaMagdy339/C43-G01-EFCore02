﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Ins_ID { get; set; }
        public DateTime? HiringDate { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public ICollection<Instructor> Instructors { get; set;} = new HashSet<Instructor>();

    }
}
