using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>()
        //    {
        //        new Car()
        //        {
        //            Id = 1, BrandId = "Mercedes", ColorId = "Black", DailyPrice = 750, ModelYear = 2016
        //        },
        //        new Car()
        //        {
        //            Id = 2, BrandId = "BMW", ColorId = "Blue", DailyPrice = 650, ModelYear = 2015
        //        },
        //        new Car()
        //        {
        //            Id = 3, BrandId = "Opel", ColorId = "Red", DailyPrice = 400, ModelYear = 2016
        //        },
        //        new Car()
        //        {
        //            Id = 4, BrandId = "Fiat", ColorId = "Blue", DailyPrice = 300, ModelYear = 2017
        //        },
        //        new Car()
        //        {
        //            Id = 5, BrandId = "Peugeot", ColorId = "Red", DailyPrice = 350, ModelYear = 2014
        //        },
        //        new Car()
        //        {
        //            Id = 6, BrandId = "Doblo", ColorId = "White", DailyPrice = 200, ModelYear = 2000
        //        }
        //    };
        //}

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Func<Car, bool> filter = null)
        {
            return _cars;
        }

        public Car Get(Func<Car, bool> filter)
        {
            return _cars.SingleOrDefault(c => c.BrandId == c.BrandId && c.ColorId == c.ColorId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.BrandId == c.BrandId);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
