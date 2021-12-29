using Noob.BusinessLogic;
using Noob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Noob.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("Student/GetStudentList")]
        public IHttpActionResult GetStudentList()
        {
            try
            {
                List<Student> StudentList = GenerateMockStudent.GenerateList();
                return Ok(StudentList);
            }
            catch (Exception)
            {
                return BadRequest();

            }

        }
        [HttpGet]
        [Route("Student/GetStudent/{id}")]
        public IHttpActionResult GetStudent(int id)
        {
            try
            {
                if (id != 0)
                {
                    List<Student> StudentList = GenerateMockStudent.GenerateList();
                    Student studentobj = StudentList.Where(x => x.studentId == id).FirstOrDefault();
                    if (studentobj == null) {
                        throw new Exception("Student ID isn't in the System");
                    }
                    return Ok(studentobj);
                }
                else
                {
                    throw new Exception("Student ID shouldn't b 0");
                }
            }
            catch (Exception ex) {
                return Content(HttpStatusCode.NotFound, ex.Message);

            }
         
        }

        [HttpPost]
        [Route("Student/AddNewStudent/")]
        public IHttpActionResult AddNewStudent([FromBody] Student Studentobj)
        {
            try
            {

                List<Student> StudentList = GenerateMockStudent.GenerateList();
                StudentList.Add(Studentobj);
                return Ok(StudentList);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.NotFound, ex.Message);

            }

        }

        [HttpPatch]
        [Route("Student/UpdateStudent/{id}")]
        public IHttpActionResult UpdateStudent(int id, [FromBody] Student Studentobj)
        {
            try
            {
                List<Student> StudentList = GenerateMockStudent.GenerateList();
                Student studentobj = StudentList.Where(x => x.studentId == id).FirstOrDefault();
                studentobj.firstName = Studentobj.firstName;
                studentobj.lastName = Studentobj.lastName;
                return Ok(studentobj);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.NotFound, ex);
            }
        }


        [HttpDelete]
        [Route("Student/DeleteStudent/{id}")]
        public IHttpActionResult DeleteStudent(int id)
        {
            try
            {
                if (id != 0)
                {
                    List<Student> StudentList = GenerateMockStudent.GenerateList();
                    Student studentobj = StudentList.Where(x => x.studentId == id).FirstOrDefault();
                    if (studentobj == null)
                    {
                        throw new Exception("Student ID isn't in the System");
                    }
                    StudentList.Remove(studentobj);
                    return Ok(StudentList);
                }
                else
                {
                    throw new Exception("Student ID shouldn't b 0");
                }
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.NotFound, ex.Message);

            }
        }
    }
}
