using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;

namespace Control
{
    class Program
    {

        static void Main(string[] args)
        {
            TestCarGetAll();
            //AddCar();
            //UpdateCar();
            //AddCustomer();
            //AddUser();
            //RentCar();
        }

        private static void RentCar()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var rentingCar1 = rentalManager.Add(new Rental
            {
                CarId = 4,
                CustomerId = 2,
                RentDate = DateTime.Now
            });
            var rentingCar2 = rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 2,
                RentDate = DateTime.Now
            });
            Console.WriteLine($"Araba 1 kiralama durumu: {rentingCar1.Message}\nAraba 2 kiralama durumu: {rentingCar2.Message}");
        }

        private static void AddUser()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Atacan",
                LastName = "Turan",
                UserId = 1,
                EMail = "edizzum@hotmail.com",
                Password = "123456"
            });
        }

        private static void CustomerAdded()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                CompanyName = "Fiction"
            });
        }

        private static void UpdateCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                CarId = 2003,
                BrandId = 1004,
                ColorId = 2,
                DailyPrice = 200,
                ModelYear = 2013
            };
            var result = carManager.Update(car);
            Console.WriteLine(result.Message);
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                CarId = 7,
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 500,
                ModelYear = 2013
            });
            Console.WriteLine("Car Added");
        }

        private static void TestCarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var xCar in carManager.GetCarDetail().Data)
            {
                Console.WriteLine(xCar.BrandName);
            }
        }
    }
}
