using App.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Contract
{
    public interface IStudentService
    {
        List<StudentModel> GetStudents();
    }
}
