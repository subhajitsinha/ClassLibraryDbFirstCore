using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;

namespace WebAPI
{
    public class MyContext:DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-8MEVUBJ\\SQLEXPRESS;Initial Catalog=VerBose;User Id=sa;Password = magic;Integrated Security = True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
