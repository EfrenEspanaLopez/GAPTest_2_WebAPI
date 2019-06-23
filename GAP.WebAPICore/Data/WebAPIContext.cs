using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAP.WebAPICore.Data
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext(DbContextOptions options) : base(options) { }
        public DbSet<Student> Student { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Subject> Subject { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grades>()
                .HasOne<Student>(s => s.Student)
                .WithMany(g => g.Grades)
                .HasForeignKey(s => s.IdStudent);

            modelBuilder.Entity<Grades>()
                .HasOne<Subject>(s => s.Subject)
                .WithMany(g => g.Grades)
                .HasForeignKey(s => s.IdSubject);
        }
    }
}
