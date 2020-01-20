using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IProfession pr = new Positions();
            pr.ShowProfetions();
            pr.AddNewProfession("Дворник");
            pr.ShowProfetions();
            pr.AddNewProfession("Дворник");
            pr.ShowProfetions();
            Console.WriteLine("Выбирите номер профессии");
            int i = int.Parse(Console.ReadLine());
            string profession = pr.GetProfession(i);
            Console.WriteLine(profession);


            Console.ReadKey();
        }
    }
    public interface IProfession
    {
        string[] AddNewProfession(string newProfession);
        void ShowProfetions();
        string GetProfession(int id);
    }
    public class Positions: IProfession
    {
        private string[] professions = new string[] { "manager", "accounter", "loader", "seller", "purchaser" };
        
        public string[] AddNewProfession(string newProfession)
        {
            bool isNewProfession = true;
            for (int i = 0; i < professions.Length; i++)
            {
                if (professions[i].CompareTo(newProfession.Trim()) == 0)
                {
                    isNewProfession = false;
                    break;
                }
            }
            if (isNewProfession)
            {
                string[] newProfessions = new string[professions.Length + 1];
                for (int i = 0; i < professions.Length; i++)
                {
                    newProfessions[i] = professions[i];
                }
                newProfessions[newProfessions.Length - 1] = newProfession;
                professions = newProfessions;
            }
            return professions;
        }

        public void ShowProfetions()
        {
            Console.WriteLine("Список профессий:");
            for (int i = 0; i < professions.Length; i++)
            {
                Console.WriteLine($"{i+1} - {professions[i]}");
            }
        }

        public string GetProfession(int id)
        {
            if (id > professions.Length)
            {
                return null;
            }
            return professions[id-1];
        }

    }
}
