using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_nr3.DAL;
using Task_nr3.Models;

namespace Task_nr3.Controllers
{
    [ApiController]
    [Route("api/students")]
   
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        //2. Passing the data by QueryString = limited, friendly urls
        //   data within query string is encoded
        [HttpGet]
        public IActionResult GetStudents(string orderBy) //action method
        {
            return Ok(_dbService.GetStudents());
        }

        //1. How to pass data using URL segment?
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id) //action method
        {
            if (id == 1)
            {
                return Ok("Jan");
            }
            else if (id == 2)
            {
                return Ok("Katarzyna");
            }

            return NotFound("Student not found");
        }

        //3. Passing the data using Body (usually POST)

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            //save into db

            return Ok(student);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(Student student)
        {


            return Ok("Updated complete");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(Student student)
        {


            return Ok("Delete complete");
        }

    }
}