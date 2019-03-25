using App.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Contract
{
    public interface IStudentRepository
    {
        List<StudentModel> GetStudents();
    }
}
