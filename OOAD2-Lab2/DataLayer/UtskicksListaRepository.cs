using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using DataLayer;

namespace DataLayer
{
    public class UtskicksListaRepository : GenericRepository<UtskicksLista>
    {
        public UtskicksListaRepository(AppDbContext context) : base(context)
        {
            Context = context;
        }

        private AppDbContext Context { get; }
    }
}
