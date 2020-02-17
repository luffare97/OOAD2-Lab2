using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class UnitOfWork
    {
        public UnitOfWork(Databas databas)
        {
            Databas = databas;


            AlumnRepository = new AlumnRepository(Databas);
        }

        public AlumnRepository AlumnRepository { get; set; }

        public Databas Databas { get; }
    }
}
