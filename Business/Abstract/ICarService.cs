using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetByCarId(int carId);
        List<Car> GetAll();
        List<Car> GetByDailyPrice(decimal min, decimal max);
    }
}
