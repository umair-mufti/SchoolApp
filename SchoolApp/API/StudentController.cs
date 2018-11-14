using App.Services.Contract;
using App.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolApp.API
{
    [Authorize]
    [RoutePrefix("api/Student")]
    public class StudentController : ApiController
    {

        public IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        
        [HttpGet]
        public IHttpActionResult Get()
        {
            var Students = _studentService.GetStudents();
            return Ok(Students);
        }

    }
}
