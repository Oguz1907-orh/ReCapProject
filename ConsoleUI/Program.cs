using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            Console.WriteLine("KIRALIK ARAC LİSTESİ VE TANIMLARI....!");
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.ColorName + "Günlük Fiyatı" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message) ;
            }
        }
       
    }
}
