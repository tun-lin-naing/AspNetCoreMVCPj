﻿
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMVCPj.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

       public DbSet<Employee> Employees { get; set; }
    }
}
