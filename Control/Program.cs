using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace Control
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var xCars in carManager.GetAll())
            {
                Console.WriteLine(xCars.BrandId);
            }


            //int sayac = 1;
            //foreach (var xCar in carManager.GetAll())
            //{

            //    System.Console.WriteLine(sayac + ". " + xCar.Brand + " -Günlük Fiyat: " + xCar.DailyPrice);
            //    sayac++;
            //}
        }
    }
}
