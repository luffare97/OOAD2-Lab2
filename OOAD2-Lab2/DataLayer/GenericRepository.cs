﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        public GenericRepository(AppDbContext context)
        {
            Context = context;
        }

        private AppDbContext Context { get; }

        //public AddToRepo()
        //{

        //}
        /*
        public TEntity Get()
        {
           return Context.Set<TEntity>().Get();
        }
        */

        //public GetAll()
        //{

        //}


    }
}
