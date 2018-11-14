using App.Domain.Model;
using App.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        public StudentModel GetStudents()
        {
            StudentModel model = new StudentModel();

            model.FirstName = "Umair";

            return model;
        }
    }
}
