using App.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolApp.API
{
    [RoutePrefix("api/Test")]
    public class TestController : ApiController
    {
        private readonly IStudentService _studentService;

        public TestController(IStudentService s)
        {
            this._studentService = s;
        }

        public TestController()
        {
            
        }


        [HttpGet]
        [Route("all")]
        public IHttpActionResult All()
        {
            var allStudents = _studentService.GetStudents();
            return Ok(allStudents);
        }
    }
}
