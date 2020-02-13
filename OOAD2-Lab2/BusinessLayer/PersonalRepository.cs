using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BusinessEntites;

namespace BusinessLayer
{
    public class PersonalRepository : GenericRepository<Personal>, IPersonalRepository
    {
        public PersonalRepository(DbContext context) : base(context)
        {
        }

        public Personal GetPersonal(int PersonalID)
        {
            // en början??
            return PersonalID;


        }

    }
}
