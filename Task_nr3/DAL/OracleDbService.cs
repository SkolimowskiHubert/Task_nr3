using Task_nr3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_nr3.DAL
{
    public class OracleDbService : IDbService
    {
        public IEnumerable<Student> GetStudents()
        {
            //implement real communication with db
            return null;
        }
    }
}