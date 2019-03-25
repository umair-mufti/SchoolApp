using App.Domain.Model;
using App.Domain.Model.Contract;
using App.Repository.Contract;
using App.Services.Contract;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IRepository _repository;
        private readonly IReadOnlyRepository _readOnlyRepository;

        public StudentService(IStudentRepository studentRepository, IRepository repository, IReadOnlyRepository readOnlyRepository)
        {
            this._studentRepository = studentRepository;
            this._repository = repository;
            this._readOnlyRepository = readOnlyRepository;
        }

        public List<StudentModel> GetStudents()
        {
            var students = this._readOnlyRepository.GetAll<Student>().FirstOrDefault();



            //var students = this._studentRepository.GetStudents();
            List<StudentModel> result = new List<StudentModel>
            {
                new StudentModel { FirstName = students.FirstName , LastName = students.LastName }
            };

            return result;
        }
    }
}
