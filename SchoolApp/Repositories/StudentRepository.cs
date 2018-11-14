using SchoolApp.Domain;
using SchoolApp.Repositories.Contract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SchoolApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public DBContext DbContext { get; set; }

        public void CreateStudent(tbl_Student st)
        {
            DbContext.Student.Add(st);
            DbContext.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            tbl_Student st = DbContext.Student.Find(id);
            DbContext.Entry(st).State = System.Data.Entity.EntityState.Deleted;
            DbContext.SaveChanges();
        }
        public tbl_Student GetStudent(int id)
        {
            return DbContext.Student.Where(s => s.StudentId == id).FirstOrDefault();
        }
        public IEnumerable<tbl_Student> GetStudents()
        {
            return DbContext.Student.ToList();
        }
        public void UpdateStudent(tbl_Student st)
        {
            DbContext.Entry(st).State = System.Data.Entity.EntityState.Modified;
            DbContext.SaveChanges();
        }

        public void UpdateStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}