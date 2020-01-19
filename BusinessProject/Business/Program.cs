using System;
using Business.UserDataValidation;
using Business.Users;
using Business.Users.DataAccessLayer;

namespace Business
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            User user = ui.processStart();

            
            if (user != null)
            {
                Console.WriteLine("Теперь посчитаем)");
            }
            else { Console.WriteLine("нет Калькулятора!"); }
        

            Console.ReadKey();
           

        }
    }
}
