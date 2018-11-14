﻿using App.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolApp.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        private readonly IStudentService _studentservice;

        public ValuesController(IStudentService studentservice)
        {
            this._studentservice = studentservice;
        }

        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    var Students = _studentservice.GetStudents();
        //    return new string[] { "value1", "value2" };
        //}



        //GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
