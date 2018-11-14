using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Repositories.Contract
{
    public interface IStudentRepository
    {
        IEnumerable<tbl_Student> GetStudents();
        tbl_Student GetStudent(int id);
        void CreateStudent(tbl_Student st);
        void UpdateStudent(tbl_Student st);
        void DeleteStudent(int id);
    }
}
