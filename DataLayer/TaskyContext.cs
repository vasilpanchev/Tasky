using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Models.DataLayer
{
    internal class TaskyContext : DbContext
    {
        public TaskyContext() : base("TaskyDBConnectionString") { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserTask> Tasks { get; set; }

        public override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Username);
        }
    }
}
