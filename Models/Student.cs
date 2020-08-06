using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStudent.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Group")]
        public string ClassroomId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        [Display(Name = "Teacher")]
        public string DadName { get; set; }
        [Display(Name = "Mom")]
        public string MomName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        [Display(Name = "HepB")]
        [DataType(DataType.Date)]
        public DateTime Vaccine1 { get; set; }
        [Display(Name = "RV")]
        [DataType(DataType.Date)]
        public DateTime Vaccine2 { get; set; }
        [Display(Name = "DTaP")]
        [DataType(DataType.Date)]
        public DateTime Vaccine3 { get; set; }
        [Display(Name = "Hib")]
        [DataType(DataType.Date)]
        public DateTime Vaccine4 { get; set; }
        [Display(Name = "PCV13")]
        [DataType(DataType.Date)]
        public DateTime Vaccine5 { get; set; }
        [Display(Name = "IPV")]
        [DataType(DataType.Date)]
        public DateTime Vaccine6 { get; set; }
        [Display(Name = "IIV")]
        [DataType(DataType.Date)]
        public DateTime Vaccine7 { get; set; }

        public string Renewal { get; set; }
        [Display(Name = "Classroom")]
        public string Classroom { get; set; }
    }
}
