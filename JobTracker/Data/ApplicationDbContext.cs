using JobTracker.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JobTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<JobApplication> JobApplications { get; set; }
    }
}