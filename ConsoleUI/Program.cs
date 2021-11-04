using Businesss.Concrete;
using Data.Concrete.EntityFramwrok;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            ColorManager colorManager = new ColorManager(new EFColorDal());
            BrandManager brandManager = new BrandManager(new EFBrandDal());

            Console.WriteLine(carManager.GetAll().message);

            
        }


    }
}
