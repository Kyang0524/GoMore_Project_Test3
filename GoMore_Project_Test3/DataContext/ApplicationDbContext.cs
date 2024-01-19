using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GoMore_Project_Test3.Models;

namespace GoMore_Project_Test3.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(nameOrConnectionString : "MyConnection")
        {
        }
        public virtual DbSet<EmpClass> Empobj { get; set; }
    }
}