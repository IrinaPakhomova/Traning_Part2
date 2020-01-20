using System;
using System.Collections.Generic;
using System.Text;
using Company.Shop.Workers;
using Company.Shop.ValidationData;
using Company.ValidationData;

namespace Company.Shop
{
    public class Business
    {

        private List<Worker> workers;
        public Business()
        { Console.WriteLine("Бизнес создан");
            workers = new List<Worker>();
        }

        public void start()
        {

            Console.WriteLine("Добавим сотрудникa (Y/N):");

            Worker worker = null;
            string firstName;
            string lastName;
            string position;
            string salary;
            string isAdd;
            do
            {
                isAdd = Console.ReadLine();
                if (isAdd == "Y")
                {
                    Console.Write("Введите фамилию:");
                    firstName = Console.ReadLine();
                    Console.Write("Введите имя:");
                    lastName = Console.ReadLine();
                    Console.Write("Введите позицию:");
                    position = Console.ReadLine();
                    Console.Write("Введите зарплату:");
                    salary = Console.ReadLine();
                    Console.WriteLine(salary);
                    if (Validator.isCorrectStringData(firstName,2) && Validator.isCorrectStringData(lastName, 2)
                       && Validator.isCorrectStringData(position,5) &&  Validator.isCorrectDecimalData(salary, 200))
                      {
                        Console.WriteLine("Сотрудник добавлен.");
                          worker = new Worker(firstName, lastName, position, Decimal.Parse(salary));
                          this.AddWorker(worker);
                      }
                      else
                      {
                          Console.WriteLine("Сотрудник не добавлен. Данные не корректные");
                      }
                    Console.WriteLine("Добавим сотрудникa (Y/N):");
                }
               
            }
            while (isAdd != "N");

       //    
        }

        public void AddWorker(Worker worker)
        {
            if (worker != null)
            {
                workers.Add(worker);
            }  
        }
        public List<Worker> GetListOfWorkers()
        {
            return workers;
        }
        public int NumberOfWorkers()
        {
            if (workers == null)
            {
                return 0;
            }
            else
            {
                return workers.Count;
            }
        }
    }
}
