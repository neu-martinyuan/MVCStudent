using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcStudent.Models;


namespace MvcStudent.Data
{
    public class MvcTeacherContext : DbContext
    {
        public MvcTeacherContext(DbContextOptions<MvcTeacherContext> options)
            : base(options)
        {
        }

        public DbSet<Teacher>  Teacher { get; set; }
    }


}
