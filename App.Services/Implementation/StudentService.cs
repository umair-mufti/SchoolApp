using App.Domain.Model;
using App.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Implementation
{
    public class StudentService : IStudentService
    {
        public StudentService() { }

        public List<StudentModel> GetStudents()
        {
            List<StudentModel> students = new List<StudentModel>
            {
                new StudentModel { FirstName = "Umair", LastName = "Mufti" },
                new StudentModel { FirstName = "Sikander", LastName = "Ahmed" }
            };

            return students;
        }
    }
}
