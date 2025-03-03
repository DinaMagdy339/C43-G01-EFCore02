using EFCore.DbContexts;
using EFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EFCore.Data
{
    internal class ITIDbContextSeeding
    {
        public static bool DataSeeding(ITIDbContext dbContext)
        {
            try
            {
                if (!dbContext.Departments.Any())
                {
                    var DepartmentsData = File.ReadAllText("Data\\departments.json");
                    var Departments = JsonSerializer.Deserialize<List<Department>>(DepartmentsData);

                    if (Departments?.Count > 0)
                    {
                        foreach (var item in Departments)
                        {
                            dbContext.Departments.Add(item); 
                        }
                        dbContext.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
