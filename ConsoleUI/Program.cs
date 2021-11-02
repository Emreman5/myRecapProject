using Businesss.Concrete;
using Data.Concrete.EntityFramwrok;
using Entities.Concrete;
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



            foreach (var item in carManager.GetCarDetail())
            {
                Console.WriteLine("{0}-----{1}-----{2}-----{3}-----{4}",item.CarId,item.CarName,item.ColorName,item.BrandName,item.DailyPrice);
            }


            




        }
       
        
    }
}
