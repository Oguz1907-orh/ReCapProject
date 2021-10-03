using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
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
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId = 1, BrandId = 1, ColorId = 1,ModelYear = 2017,DailyPrice = 750,Description = "Ford"},
                new Car {CarId = 2, BrandId = 2, ColorId = 2,ModelYear = 2015,DailyPrice = 450,Description = "Bmw"},
                new Car {CarId = 3, BrandId = 3, ColorId = 3,ModelYear = 2018,DailyPrice = 1500,Description = "Audi"},
                new Car {CarId = 4, BrandId = 4, ColorId = 1,ModelYear = 2017,DailyPrice = 500,Description = "Fiat"},
                new Car {CarId = 5, BrandId = 1, ColorId = 2,ModelYear = 2016,DailyPrice = 250,Description = "Renault"},
                new Car {CarId = 6, BrandId = 5, ColorId = 3,ModelYear = 2019,DailyPrice = 1750,Description = "Seat"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId );
                _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
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

        public List<Car> GetAllByCategory(int categoryId)
        {
           return  _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public List<Car> GetById()
        {
            return _cars;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
