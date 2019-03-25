using App.Domain.Model;
using App.Repository.Implementation;
using SchoolApp.Domain;
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
