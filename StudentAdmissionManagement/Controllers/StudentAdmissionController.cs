using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAdmissionManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailModel> Get()
        {

            StudentAdmissionDetailModel admission1 = new StudentAdmissionDetailModel()
            { StudentId = 101, Name = "Khalanthar", Class = "CSE", DateOfJoining = DateTime.Now };
            

            StudentAdmissionDetailModel admission2 = new StudentAdmissionDetailModel() 
            { StudentId = 102, Name = "Gouri", Class = "EEE", DateOfJoining = DateTime.Now };
            admission1.StudentId = 101;

            List<StudentAdmissionDetailModel> AdmissionList = new List<StudentAdmissionDetailModel>();
            AdmissionList.Add(admission1);
            AdmissionList.Add(admission2);
            return AdmissionList;
        }

        // GET api/<StudentAdmissionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAdmissionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAdmissionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAdmissionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
