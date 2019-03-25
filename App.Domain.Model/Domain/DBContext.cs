namespace SchoolApp.Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<tbl_Class> Class { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Parent> Parent { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentMarks> StudentMarks { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<TimeTable> TimeTable { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .HasMany(e => e.Teachers)
                //.WithMany(e => e.Classes)
                .Map(m => m.ToTable("TeacherClass"));

            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpCode)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Office)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Class>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<Exam>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<Parent>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<StudentMarks>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<Subject>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<TimeTable>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();
        }

        
    }
}
