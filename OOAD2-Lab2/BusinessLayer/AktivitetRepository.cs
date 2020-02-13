using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BusinessEntites;

namespace BusinessLayer
{
    public class AktivitetRepository : GenericRepository<Aktivitet>, IAktivitetRepository
    {
        public AktivitetRepository(DbContext context) : base(context)
        {
            //Vettefan va detta är? kanske behövs?
        }

        public Aktivitet GetAktivitet(int AktivitetId)
        {
            // en början
            return AktivitetId;
            
        
        }

    }
}
