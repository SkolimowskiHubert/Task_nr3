using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_nr3.Models;

namespace Task_nr3.DAL
{
    interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
