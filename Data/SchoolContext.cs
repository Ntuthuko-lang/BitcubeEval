using Bitcube.Models;
using Microsoft.EntityFrameworkCore;

namespace Bitcube.Data
{
    public class SchoolContext : DbContext  
    {
        public SchoolContext()
        {
             
        }
        public SchoolContext(DbContextOptions<SchoolContext> options): base(options)
        {
        }
        public DbSet <Course> Courses{ get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet <Degree> Degree{ get; set; }
        public DbSet <Lecture> Lectures { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<CourseAsssignment> CourseAsssignments { get; set; }


        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Degree>().ToTable("Degree");
            modelBuilder.Entity<Lecture>().ToTable("Lectures");
            modelBuilder.Entity<OfficeAssignment>().ToTable("OfficeAssignment");
            modelBuilder.Entity<CourseAsssignment>().ToTable("CourseAssignment");


            modelBuilder.Entity<CourseAsssignment>()
                .HasKey(c => new { c.CourseId, c.LectureId });
        }

    }
}
