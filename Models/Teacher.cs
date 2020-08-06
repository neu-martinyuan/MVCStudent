using System;
using System.ComponentModel.DataAnnotations;

namespace MvcStudent.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        public string Group { get; set; }
        public string Classroom { get; set; }
        public decimal Ratings { get; set; }
    }
}