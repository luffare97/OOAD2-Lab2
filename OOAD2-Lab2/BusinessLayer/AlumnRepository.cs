using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BusinessEntites;

namespace BusinessLayer
{
    public class AlumnRepository : GenericRepository<Alumn>, IAlumnRepository
    {
        public AlumnRepository(DbContext context) : base(context)
        {
        }

        public Alumn GetAlumn(int AnvändarId)
        {
            // en början
            return AnvändarId;


        }



    }
}
