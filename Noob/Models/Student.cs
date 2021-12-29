using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Noob.Models
{
    public class Student
    {
        public Student(int studentId, string firstName, string lastName, string dOB)
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
            DOB = dOB;
        }

        public int studentId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string DOB { get; set; }
    }
}