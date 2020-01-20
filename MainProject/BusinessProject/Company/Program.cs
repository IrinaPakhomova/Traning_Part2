using System;
using Company.Shop;
using Company.Shop.Workers;
using Company.Shop.ValidationData;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Business business = new Business();
            business.start();
            Console.WriteLine(business.NumberOfWorkers());
            Console.ReadKey();
        }
    }
}
