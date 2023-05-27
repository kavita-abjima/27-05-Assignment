using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentApi.Model;

namespace StudentApi.Data
{
    public class StudentApiContext : DbContext
    {
        public StudentApiContext (DbContextOptions<StudentApiContext> options)
            : base(options)
        {
        }

        public DbSet<StudentApi.Model.Student> Student { get; set; } = default!;
    }
}
