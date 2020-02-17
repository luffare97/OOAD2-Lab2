using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessEntites;
using DataLayer;

namespace BusinessLayer
{
    public class PersonalRepository : GenericRepository<Personal>
    {
        public PersonalRepository(Databas context) : base(context)
        {
            Context = context;
        }

        private Databas Context { get; }


    }
}
