using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>()
            {
                new Car()
                {
                    Id = 1, Brand = "Mercedes", Color = "Black", DailyPrice = 750, ModelYear = 2016,
                    Description = "Like a brand new."
                },
                new Car()
                {
                    Id = 2, Brand = "BMW", Color = "Blue", DailyPrice = 650, ModelYear = 2015,
                    Description = "Awesome for feeling excited."
                },
                new Car()
                {
                    Id = 3, Brand = "Opel", Color = "Red", DailyPrice = 400, ModelYear = 2016,
                    Description = "Good for family."
                },
                new Car()
                {
                    Id = 4, Brand = "Fiat", Color = "Blue", DailyPrice = 300, ModelYear = 2017,
                    Description = "Good for your budget."
                },
                new Car()
                {
                    Id = 5, Brand = "Peugeot", Color = "Red", DailyPrice = 350, ModelYear = 2014,
                    Description = "For youth."
                },
                new Car()
                {
                    Id = 6, Brand = "Doblo", Color = "White", DailyPrice = 200, ModelYear = 2000,
                    Description = "If you want to barbecue, just pick it."
                }
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Brand == car.Brand);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int brandId, int colorId)
        {
            return _car.Where(c => c.Brand == c.Brand && c.Color == c.Color).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Brand == c.Brand);
            carToUpdate.Id = car.Id;
            carToUpdate.Brand = car.Brand;
            carToUpdate.Color = car.Color;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
