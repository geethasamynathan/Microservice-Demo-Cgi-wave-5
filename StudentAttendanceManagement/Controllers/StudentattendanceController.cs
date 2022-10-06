using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentattendanceController : ControllerBase
    {
        // GET: api/<StudentattendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailModel> Get()
        {
            StudentAttendanceDetailModel student1 = new StudentAttendanceDetailModel()
            {
                StudentId = 101,
                StudentName = "Vishnu",
                AttendancePercentage = 78.89
            };
            StudentAttendanceDetailModel student2 = new StudentAttendanceDetailModel()
            {
                StudentId = 102,
                StudentName = "Samir",
                AttendancePercentage = 88.89
            };
            List<StudentAttendanceDetailModel> studentattendanceList = new List<StudentAttendanceDetailModel>()
            {
                student1,
                student2
            };
            return studentattendanceList;
        }

        // GET api/<StudentattendanceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentattendanceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentattendanceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentattendanceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
