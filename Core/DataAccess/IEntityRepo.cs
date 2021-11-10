﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
   public interface IEntityRepo<T> where T:class,IEntity,new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T GetById(Expression<Func<T, bool>> filter);
        
    }
}
