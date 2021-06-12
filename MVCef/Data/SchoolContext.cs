namespace MVCef.Data
{
    using Microsoft.EntityFrameworkCore;
    using MVCef.Models;

    /// <summary>
    /// Defines the <see cref="SchoolContext" />.
    /// </summary>
    public class SchoolContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions{SchoolContext}"/>.</param>
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Students.
        /// </summary>
        public DbSet<Student> Students { get; set; }

        /// <summary>
        /// Gets or sets the Courses.
        /// </summary>
        public DbSet<Course> Courses { get; set; }

        /// <summary>
        /// Gets or sets the Enrollments.
        /// </summary>
        public DbSet<Enrollment> Enrollments { get; set; }

        /// <summary>
        /// Gets or sets the Departments.
        /// </summary>
        public DbSet<Department> Departments { get; set; }

        /// <summary>
        /// Gets or sets the Instructors.
        /// </summary>
        public DbSet<Instructor> Instructors { get; set; }

        /// <summary>
        /// Gets or sets the OfficeAssignments.
        /// </summary>
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

        /// <summary>
        /// Gets or sets the CourseAssignments.
        /// </summary>
        public DbSet<CourseAssignment> CourseAssignments { get; set; }

        /// <summary>
        /// /// </summary>


        /// <summary>
        /// The OnModelCreating.
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder<see cref="ModelBuilder"/>.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<OfficeAssignment>().ToTable("OfficeAssignment");
            modelBuilder.Entity<CourseAssignment>().ToTable("CourseAssignment");

            modelBuilder.Entity<CourseAssignment>().HasKey(c => new { c.CourseID, c.InstructorID });

           
        }
    }
}
