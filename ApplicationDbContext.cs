using Microsoft.EntityFrameworkCore;
using StudentMarks.Models;

namespace StudentMarks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentMarks.Models.StudentModel> StudentMarks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public async Task SaveStudentData(StudentModel student)
        {
            await Database.ExecuteSqlRawAsync("CALL usp_SaveStudentData(@p0, @p1, @p2, @p3, @p4, @p5, @p6)",
                student.name, student.maths, student.physics,student.chemistry, student.hindi, student.english, student.id);
        }

        public async Task GetStudentData(StudentModel student)
        {
            await Database.ExecuteSqlRawAsync("CALL usp_SaveStudentData(@p0, @p1, @p2, @p3, @p4, @p5, @p6)",
                student.name, student.maths, student.physics, student.chemistry, student.hindi, student.english, student.id);
        }
    }
}
