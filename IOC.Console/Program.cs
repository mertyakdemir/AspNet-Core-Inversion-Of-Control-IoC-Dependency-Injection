using System;

namespace IOC.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLayer businessLayer = new BusinessLayer(new DAL());
            //BusinessLayer businessLayer = new BusinessLayer(new OracleDAL());

            businessLayer.GetProducts().ForEach(x =>
            {
                System.Console.WriteLine($"{x.Id}) {x.Name} - {x.Price}");
            });

            System.Console.ReadLine();
        }
    }
}
