using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using DataLayer;

namespace BusinessLayer
{
    public class ProgramRepository : GenericRepository<Program>
    {
        public ProgramRepository(Databas context) : base(context)
        {
            Context = context;
        }

        private Databas Context { get; }

        public IEnumerable<Program> GetPrograms()
        {
            return Context.Programs.Where(x => x.ID>0);

        }
            
    }
}
