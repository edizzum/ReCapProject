using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {



        //public void Add(Car entity)
        //{
        //    using (ReCapProjectContext context = new ReCapProjectContext())
        //    {
        //        var addedEntity = context.Entry(entity);
        //        addedEntity.State = EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete(Car entity)
        //{
        //    using (ReCapProjectContext context = new ReCapProjectContext())
        //    {
        //        var deletedEntity = context.Entry(entity);
        //        deletedEntity.State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}

        //public List<Car> GetAll(Func<Car, bool> filter)
        //{
        //    using (ReCapProjectContext context = new ReCapProjectContext())
        //    {
        //        return filter == null 
        //            ? context.Set<Car>().ToList() 
        //            : context.Set<Car>().Where(filter).ToList();
        //    }
        //}

        //public Car Get(Func<Car, bool> filter)
        //{
        //    using (ReCapProjectContext reCapProjectContext = new ReCapProjectContext())
        //    {
        //        return reCapProjectContext.Set<Car>().SingleOrDefault(filter); 
        //    }
        //}

        //public void Update(Car entity)
        //{
        //    using (ReCapProjectContext context = new ReCapProjectContext())
        //    {
        //        var updatedEntity = context.Entry(entity);
        //        updatedEntity.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        public List<CarDetailDto> GetCarDetail()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors
                             on p.ColorId equals c.ColorId
                             join b in context.Brands
                             on p.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = p.Id,
                                 BrandName = p.BrandId,
                                 ModelYear = p.ModelYear,
                                 ColorName = p.ColorId,
                                 DailyPrice = p.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
