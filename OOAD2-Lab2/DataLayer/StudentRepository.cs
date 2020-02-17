using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using DataLayer;

namespace BusinessLayer
{
    public class StudentRepository : GenericRepository<Student>
    {
        public StudentRepository(Databas context) : base(context)
        {
            Context = context;
        }

        private Databas Context { get; }
    }
}
