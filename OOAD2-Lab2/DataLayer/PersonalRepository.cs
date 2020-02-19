using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessEntites;
using DataLayer;

namespace DataLayer
{
    public class PersonalRepository : GenericRepository<Personal>
    {
        public PersonalRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        private AppDbContext Context { get; }


    }
}
