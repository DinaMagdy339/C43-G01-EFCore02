using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Models;

namespace EFCore
{
    internal class Course_InstConfigurations : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.ToTable("Course_InstsTable");

            builder.HasKey(K => new { K.Course_ID, K.inst_ID });
            builder.Property(E => E.Evaluate);  

        }
    }
}