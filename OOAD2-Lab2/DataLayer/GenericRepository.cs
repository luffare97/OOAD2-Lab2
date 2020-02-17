using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        public GenericRepository(Databas context)
        {
            Context = context;
        }

        private Databas Context { get; }

        //public AddToRepo()
        //{

        //}

        public TEntity Get()
        {
            return Context.Set<TEntity>.Get();
        }


        //public GetAll()
        //{

        //}


    }
}
