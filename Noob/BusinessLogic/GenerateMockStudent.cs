using Noob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Noob.BusinessLogic
{
    public class GenerateMockStudent
    {
        public static List<Student> GenerateList() {
            List<Student> studentList = new List<Student>() { new Student(1, "Paing", "NOOb", "2/09/1889") };
            Student obj = new Student(3, "Paing ", "Su", "09/09/1558");
            studentList.Add(obj);
            return studentList;
        }
    }
}