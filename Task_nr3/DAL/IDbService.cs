using System.Collections.Generic;
using Task_nr3.Models;

namespace Task_nr3.DAL
{
    interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
