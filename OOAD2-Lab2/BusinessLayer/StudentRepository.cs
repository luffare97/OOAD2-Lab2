using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;

namespace BusinessLayer
{
    class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(DbContext context) : base(context)
        {
        }
        public Student GetStudent (int AnvändarId)
        {
            // en början??
            return AnvändarId;


        }
    }
}
