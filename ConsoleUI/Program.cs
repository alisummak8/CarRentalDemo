using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            ////Add
            //carManager.Add(new Car {Id=,BrandId=,ColorId=,Description="",DailyPrice=,ModelYear=});

            ////Update
            //carManager.Update(new Car {Id=,ColorId=,BrandId=,Description="",DailyPrice=,ModelYear=});

            ////Delete
            //carManager.Delete(new Car {Id=});

            ////Get
            //var receivedCar = carManager.Get(/*Id=*/);
            //Console.WriteLine(receivedCar.Description);

            ////GetAll
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            ////GetByColorId
            //foreach (var car in carManager.GetCarsByColorId(2))
            //{
            //    Console.WriteLine(car.BrandId + car.Description);
            //}

            ////GetByBrandId
            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.Description);
            //}
        }
    }
}
