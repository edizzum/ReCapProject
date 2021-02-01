using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;

namespace Control
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            int sayac = 1;
            foreach (var xCar in carManager.GetAll())
            {

                System.Console.WriteLine(sayac + ". " + xCar.Brand + " -Günlük Fiyat: " + xCar.DailyPrice);
                sayac++;
            }

        }
    }
}
