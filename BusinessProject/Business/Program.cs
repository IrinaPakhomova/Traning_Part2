using System;
using Business.UserDataValidation;
using Business.Users;
using Business.Calculator;
using System.Text;

namespace Business
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            bool exitflag = false;
            User user = null;
            do
            {
                if (user == null) 
                {
                    user = ui.processStart();
                }
                    
                if (user != null)
                {
                    ui.Calculation();
                    Console.WriteLine("Вы хотите выйти? (Y)");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        exitflag = true;
                    }
                }
                else
                {
                    Console.WriteLine("Вы хотите выйти? (Y)");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        exitflag = true;
                    }
                    else
                    {
                        Console.WriteLine("Попрубуйте еще раз войти!");
                    }
                }
            } while (!exitflag);
            
            
        

            Console.ReadKey();
           

        }
    }
}
