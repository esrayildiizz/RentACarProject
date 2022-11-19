using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=500,Description="Temiz kullanılması önemli", ModelYear=2016},
                new Car{CarId=2,BrandId=2,ColorId=2,DailyPrice=800,Description="Temiz kullanılması önemli", ModelYear=2022},
                new Car{CarId=3,BrandId=3,ColorId=1,DailyPrice=300,Description="Temiz kullanılması önemli", ModelYear=2012}
            };
        }



        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            //Gönderdiğim araba id'sine eşit olan listedeki arabayı bul demek.
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            //Gönderdiğim araba ıd göre güncelleme işlemi yapmak için gerekli kodlar.
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
