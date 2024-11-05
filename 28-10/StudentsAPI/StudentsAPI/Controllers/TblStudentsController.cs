using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentsAPI.Models;

namespace StudentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblStudentsController : ControllerBase
    {
        private readonly StudentContext _context;

        public TblStudentsController(StudentContext context)
        {
            _context = context;
        }

        // GET: api/TblStudents
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<TblStudent>>> GetTblStudents()
        //{
        //    return await _context.TblStudents.ToListAsync();
        //}

        // GET: api/TblStudents/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<TblStudent>> GetTblStudent(int id)
        //{
        //    var tblStudent = await _context.TblStudents.FindAsync(id);

        //    if (tblStudent == null)
        //    {
        //        return NotFound();
        //    }

        //    return tblStudent;
        //}

        // PUT: api/TblStudents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTblStudent(int id, TblStudent tblStudent)
        //{
        //    if (id != tblStudent.StudentId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(tblStudent).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TblStudentExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/TblStudents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<TblStudent>> PostTblStudent(TblStudent tblStudent)
        //{
        //    _context.TblStudents.Add(tblStudent);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTblStudent", new { id = tblStudent.StudentId }, tblStudent);
        //}

        // DELETE: api/TblStudents/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTblStudent(int id)
        //{
        //    var tblStudent = await _context.TblStudents.FindAsync(id);
        //    if (tblStudent == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.TblStudents.Remove(tblStudent);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool TblStudentExists(int id)
        //{
        //    return _context.TblStudents.Any(e => e.StudentId == id);
        //}

        [HttpGet]
        public  ActionResult Get()
        {
            return Ok( _context.TblStudents.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var std = await _context.TblStudents.FindAsync(id);
            if (std == null)
            {
                return NotFound();
            }
            return Ok(std);
        }
        [HttpPost]
        public async Task<IActionResult> PostStudents(TblStudent student)
        {
            var temp = await _context.TblStudents.AddAsync(student);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, TblStudent student)
        {
            if (id != student.StudentId)
            {
                return BadRequest();
            }
            var stu = await _context.TblStudents.FindAsync(id);

            if (stu == null)
            {
                return NotFound();
            }

            stu.StudentName = student.StudentName;
            stu.StudentGrade = student.StudentGrade;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.TblStudents.Any(s => s.StudentId == id)) { return BadRequest(); }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (int id)
        {
            var emp = await _context.TblStudents.FindAsync(id);
            if(emp == null)
            {
                return NotFound();
            }
            _context.TblStudents.Remove(emp);
            await _context.SaveChangesAsync();
            return NoContent();
        } 
    }
}
