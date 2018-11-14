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
        public virtual DbSet<tbl_Class> tbl_Class { get; set; }
        public virtual DbSet<Exam> tbl_Exam { get; set; }
        public virtual DbSet<Parent> tbl_Parent { get; set; }
        public virtual DbSet<tbl_Role> tbl_Role { get; set; }
        public virtual DbSet<tbl_Student> Student { get; set; }
        public virtual DbSet<tbl_StudentMarks> tbl_StudentMarks { get; set; }
        public virtual DbSet<tbl_Subject> tbl_Subject { get; set; }
        public virtual DbSet<tbl_Teacher> tbl_Teacher { get; set; }
        public virtual DbSet<tbl_TimeTable> tbl_TimeTable { get; set; }
        public virtual DbSet<tbl_User> tbl_User { get; set; }
        public virtual DbSet<tbl_UserRole> tbl_UserRole { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .HasMany(e => e.Teachers)
                .WithMany(e => e.Classes)
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

            modelBuilder.Entity<tbl_Student>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<tbl_StudentMarks>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<tbl_Subject>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<tbl_Teacher>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<tbl_TimeTable>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<tbl_User>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();
        }

        
    }
}
