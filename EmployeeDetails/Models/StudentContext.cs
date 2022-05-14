using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDetails.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext()
        {

        }

        public StudentContext(DbContextOptions<StudentContext> options) :base(options)
        {

        }
        public DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =.;Initial Catalog =ajax;Integrated Security=true");
            }

        }

    }

}