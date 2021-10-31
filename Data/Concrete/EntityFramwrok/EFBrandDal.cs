using Data.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data.Concrete.EntityFramwrok
{
    public class EFBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (CarProjectContexxt context = new CarProjectContexxt())
            {
                var addedBrand = context.Entry(entity);
                addedBrand.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (CarProjectContexxt context = new CarProjectContexxt())
            {
                var deletedBrand = context.Entry(entity);
                deletedBrand.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (CarProjectContexxt context = new CarProjectContexxt())
            {
                return filter == null ? context.Set<Brand>().ToList() :
                    context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (CarProjectContexxt context = new CarProjectContexxt())
            {
                var updatedBrand = context.Entry(entity);
                updatedBrand.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
