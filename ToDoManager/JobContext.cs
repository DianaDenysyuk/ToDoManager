using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoManager.Models;

namespace ToDoManager
{
    public class JobContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<JobTag> JobTags { get; set; }
        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {
        }
        public JobContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<JobTag>()
                .HasKey(t => new { t.JobId, t.TagId });

            builder.Entity<JobTag>()
                .HasOne(sc => sc.Job)
                .WithMany(s => s.JobTags)
                .HasForeignKey(sc => sc.JobId);

            builder.Entity<JobTag>()
                .HasOne(sc => sc.Tag)
                .WithMany(c => c.JobTags)
                .HasForeignKey(sc => sc.TagId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=relationsdb;Trusted_Connection=True;");
        }
    }
}
