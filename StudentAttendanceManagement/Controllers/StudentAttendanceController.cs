using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAttendanceManagement.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetails> Get()
        {
            List<StudentAttendanceDetails> attendanceList = new List<StudentAttendanceDetails>()
            { new StudentAttendanceDetails (){StudentId=101,StudentName="Khalanthar",AttendancePercentage=90.4},
                 new StudentAttendanceDetails (){StudentId=102,StudentName="Gouri",AttendancePercentage=92.4},
            };

            return attendanceList;
        }

        // GET api/<StudentAttendanceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentAttendanceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentAttendanceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentAttendanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
