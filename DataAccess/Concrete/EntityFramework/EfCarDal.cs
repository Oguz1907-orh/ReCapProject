using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.IO;

namespace DataAccess.Concrete.EntityFramework
{
    //Nuget aşağıdaki kod ile bütün veritabanı operasyonlarını yazmaya hazır hale getirmiş olduk.
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             select new CarDetailDto { CarName = b.BrandName, CarId = c.CarId, ColorName =co.ColorName};
                            return result.ToList(); 

            }
             
        }
    }
}
