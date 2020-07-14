using System;
using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions options): base(options)
        {
        }
        public DbSet<User> users{ get; set; }
    }
}
