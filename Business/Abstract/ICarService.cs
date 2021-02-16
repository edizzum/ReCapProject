using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetByCarId(int carId);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailsDto>> GetCarDetail();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
