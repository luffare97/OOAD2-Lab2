using BusinessEntites;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLayer
{
    public class AktivitetRepository : GenericRepository<Aktivitet>, IAktivitetRepository
    {
        public AktivitetRepository(Databas context) : base(context)
        {
            Context = context;
        }

        private Databas Context { get; }

        public IEnumerable<Aktivitet> GetAllAktiviteter()
        {
            return Context.Aktiviteter.Where(x => x.AktivitetId == 1);
        }
    }
}
