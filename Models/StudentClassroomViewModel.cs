using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStudent.Models
{
    public class StudentClassroomViewModel
    {
        public List<Student> Students { get; set; }
        public SelectList Classrooms { get; set; }
        public string StudentClassroom { get; set; }
        public string SearchString { get; set; }
    }
}
