using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if ((car.Description).Length < 2)
            {
                Console.Write("Araç adı en az 2 karakter olmalı");
                if (car.DailyPrice <= 0)
                {
                    Console.WriteLine(",");
                    Console.WriteLine("Aracın günlük fiyatı 0'dan büyük olmalı.");
                }
                else
                {
                    Console.WriteLine(".");
                }
            }

            else if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Aracın günlük fiyatı 0'dan büyük olmalı.");
            }

            else if ((car.Description).Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car Get(int id)
        {
            return _carDal.Get(c=>c.Id==id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c=>c.BrandId==brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            if ((car.Description).Length < 2)
            {
                Console.Write("Araç adı en az 2 karakter olmalı");
                if (car.DailyPrice <= 0)
                {
                    Console.WriteLine(",");
                    Console.WriteLine("Aracın günlük fiyatı 0'dan büyük olmalı.");
                }
                else
                {
                    Console.WriteLine(".");
                }
            }

            else if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Aracın günlük fiyatı 0'dan büyük olmalı.");
            }

            else if ((car.Description).Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Update(car);
            }
        }
    }
}
