using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            //foreach (var car in carManager.GetAll())
            {
                //Console.WriteLine(car.Description);
            }
        }
    }
}
