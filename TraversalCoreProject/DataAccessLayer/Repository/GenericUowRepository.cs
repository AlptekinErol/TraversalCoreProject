﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericUowRepository<T> : IGenericUowDal<T> where T : class
    {
        private readonly Context _context;

        public GenericUowRepository(Context context)
        {
            _context = context;
        }

        public void Create(T entity) //inserting op.
        {
            _context.Add(entity);
        }

        public T GetAccById(int id)
        {
           return _context.Set<T>().Find(id);
        }

        public void MultiUpdate(List<T> t)
        {
           _context.UpdateRange(t);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
