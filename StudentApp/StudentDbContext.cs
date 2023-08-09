using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace StudentApp
{
    class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
