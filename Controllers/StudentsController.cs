using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcStudent.Data;
using MvcStudent.Models;

namespace MvcStudent.Controllers
{
    public class StudentsController : Controller
    {
        private readonly MvcStudentContext _context;

        public StudentsController(MvcStudentContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index(string studentClassroom, string searchString, string studentRenewal, string studentTeacher)
        {
            IQueryable<string> classroomQuery = from m in _context.Student
                                                orderby m.ClassroomId
                                                select m.ClassroomId;

            var students = from m in _context.Student
                           select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                students = students.Where(x => x.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(studentRenewal))
            {
                students = students.Where(x => x.Renewal.Contains(studentRenewal));
            }

            if (!string.IsNullOrEmpty(studentTeacher))
            {
                students = students.Where(x => x.DadName.Contains(studentTeacher));
            }

            if (!string.IsNullOrEmpty(studentClassroom))
            {
                students = students.Where(x => x.ClassroomId.Contains(studentClassroom));
            }        

            var studentClassroomVM = new StudentClassroomViewModel
            {
                Classrooms = new SelectList(await classroomQuery.Distinct().ToListAsync()),
                Students = await students.ToListAsync()
            };

         

            return View(studentClassroomVM);
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassroomId,Name,Age,DadName,MomName,Address,Phone,Vaccine1,Vaccine2,Vaccine3,Vaccine4,Vaccine5,Vaccine6,Vaccine7,Renewal,Classroom")] Student student)
        {
            //var students = from m in _context.Student
            //               select m;

            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);

            //var studentVM = new StudentViewModel
            //{
            //    Students = await students.ToListAsync()
            //};

            //return View(studentVM);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClassroomId,Name,Age,DadName,MomName,Address,Phone,Vaccine1,Vaccine2,Vaccine3,Vaccine4,Vaccine5,Vaccine6,Vaccine7,Renewal,Classroom")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
