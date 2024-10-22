using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>()
        {
            new Employee { id = 1, name = "Rithin", age = 45, salary = 40000 },
            new Employee { id = 2, name = "Jithu", age = 55, salary = 30000 },
            new Employee { id = 3, name = "Ruben", age = 45, salary = 56000 },
            new Employee { id = 4, name = "Nithin", age = 40, salary = 40000 },
        };

        [HttpGet]

        public ActionResult<IEnumerable<Employee>> Get()
        {
            return _employees;
        }

        [HttpPost]
        public ActionResult<IEnumerable<Employee>> Post(Employee employee)
        {
            _employees.Add(employee);
            return CreatedAtAction(nameof(Get), new { id = employee.id }, employee);
            //return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Employee employee) {
            if (id != employee.id)
            {
                return BadRequest();
            }
            var temp = _employees.FirstOrDefault(x=> x.id == id);
            if (temp == null)
            {
                return NotFound();
            }
            temp.id = employee.id;
            temp.name = employee.name;
            temp.age = employee.age;
            temp.salary = employee.salary;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var temp = _employees.FirstOrDefault(x=>x.id == id);
            if(temp == null)
            {
                return NotFound();
            }
            _employees.Remove(temp);

            return NoContent();
        }


    }
}
