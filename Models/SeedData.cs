using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcStudent.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStudent.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcStudentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcStudentContext>>()))
            {
                // Look for any students
                if (context.Student.Any())
                {
                    return;     // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        ClassroomId = "1",
                        Name = "Joy",
                        Age = "3",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-6-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "Yes",
                        Classroom = "Class A",
                    },

                    new Student
                    {
                        ClassroomId = "1",
                        Name = "Liam",
                        Age = "3",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-6-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "Yes",
                        Classroom = "Class A",
                    },

                    new Student
                    {
                        ClassroomId = "1",
                        Name = "Noah",
                        Age = "3",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-6-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "No",
                        Classroom = "Class A",
                    },

                    new Student
                    {
                        ClassroomId = "2",
                        Name = "Logan",
                        Age = "6",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-7-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "Yes",
                        Classroom = "Class A",
                    },

                    new Student
                    {
                        ClassroomId = "2",
                        Name = "Emma",
                        Age = "6",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-7-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "Yes",
                        Classroom = "Class A",
                    },

                    new Student
                    {
                        ClassroomId = "2",
                        Name = "Olivia",
                        Age = "6",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-7-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "Yes",
                        Classroom = "Class A",
                    },

                    new Student
                    {
                        ClassroomId = "3",
                        Name = "Ava",
                        Age = "8",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-6-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "Yes",
                        Classroom = "Class B",
                    },

                    new Student
                    {
                        ClassroomId = "3",
                        Name = "Mia",
                        Age = "8",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-6-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "Yes",
                        Classroom = "Class B",
                    },

                    new Student
                    {
                        ClassroomId = "3",
                        Name = "Isabella",
                        Age = "8",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-6-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "No",
                        Classroom = "Class B",
                    },

                    new Student
                    {
                        ClassroomId = "4",
                        Name = "Sophia",
                        Age = "10",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-7-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "Yes",
                        Classroom = "Class B",
                    },

                    new Student
                    {
                        ClassroomId = "4",
                        Name = "Charlotte",
                        Age = "10",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-7-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "Yes",
                        Classroom = "Class B",
                    },

                    new Student
                    {
                        ClassroomId = "4",
                        Name = "Mia",
                        Age = "10",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-7-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "No",
                        Classroom = "Class B",
                    },

                    new Student
                    {
                        ClassroomId = "4",
                        Name = "Harper",
                        Age = "10",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-6-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "Yes",
                        Classroom = "Class B",
                    },

                    new Student
                    {
                        ClassroomId = "5",
                        Name = "Evelyn",
                        Age = "12",
                        DadName = "xxxx",
                        MomName = "yyyy",
                        Address = "Boston",
                        Phone = "xxx-xxx-xxxx",
                        Vaccine1 = DateTime.Parse("2020-7-30"),
                        Vaccine2 = DateTime.Parse("2020-7-30"),
                        Vaccine3 = DateTime.Parse("2020-7-30"),
                        Vaccine4 = DateTime.Parse("2020-7-30"),
                        Vaccine5 = DateTime.Parse("2020-7-30"),
                        Vaccine6 = DateTime.Parse("2020-7-30"),
                        Vaccine7 = DateTime.Parse("2020-7-30"),
                        Renewal = "Yes",
                        Classroom = "Class C",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
