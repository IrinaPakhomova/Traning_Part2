using Business.UserDataValidation;
using Business.Users.DataAccessLayer;
using System;
using Business.Users;

namespace Business
{
    class UI
    {
        private readonly IUserData users;
        
        public UI()
        {
            users = new UserData();
        }

        public User processStart()
        {
            const string info = "Программа калькулятор:"
                              + "\nВыберите нужный пункт меню:\n 1.Регистрация нового пользователя"
                              + " \n 2. Войти в систему под пользователем"
                              + " \n 3. Удалить аккаунт \n4. Изменить пароль пользователя";
                              //\n 3. Исправить данные пользователя \n 4. Удалить пользователя \n 5.Выход из программы";

            User user = null;
            bool userFlag = false;
            int operation;
            Console.WriteLine(info);
            Console.Write("Введите номер операции:");
            do
            {
                if (int.TryParse(Console.ReadLine(), out operation))
                {
                    if (operation >= 1 && operation <= 4)
                    {
                        break;
                    }
                    Console.WriteLine("Не корректные данные");
                }
            } while (true);

            switch (operation)
            {
                case 1:
                    {
                        user = InputeDataUser();
                        if (!users.AddUser(user))
                        {
                            user = null;
                        }
                        break;
                    }
                case 2:
                    {
                       user = InputeDataUser();
                       if (!user.Equals(users.GetUser(user.Name)))
                       {
                            Console.WriteLine("Неверное имя пользователя или пароль!");
                            user = null;
                       }
                       break;
                    }
                case 3:
                    {
                        user = InputeDataUser();
                        if (user.Equals(users.GetUser(user.Name)))
                        {
                            users.DeleteUser(user);
                        }
                        else
                        {
                             Console.WriteLine("Такого юзера нет!");
                        }
                        user = null;
                        break;
                        
                    }
                case 4:
                    {
                        user = InputeDataUser();
                        if (user.Equals(users.GetUser(user.Name)))
                        {
                            bool validation_flag = false;
                            string password;
                            do
                            {
                                Console.WriteLine("Введите новый пароль:");
                                password = Console.ReadLine();
                                if (!ValidationData.isCorrectStringData(password, 3))
                                {
                                    Console.WriteLine("Пароль должен быть не менее 3 символов");
                                }
                                else
                                {
                                    validation_flag = true;
                                }
                            } while (!validation_flag);
                            users.EditUSer(user, password);
                        }
                        else
                        {
                            user = null;
                            Console.WriteLine("Такого юзера нет!");
                        }
                        break;
                    }
            }
            return user;
        }

        public void Calculation()
        {

        }

        public User InputeDataUser()
        {
            string name;
            string password;
            bool validation_flag = false;
            do
            {
                Console.WriteLine("Введите имя пользоварителя:");
                name = Console.ReadLine();
                if (!ValidationData.isCorrectStringData(name, 5))
                {
                    Console.WriteLine("Имя пользователя должно быть не менее 5 символов!");
                }
                else
                {
                    validation_flag = true;
                }
            } while (!validation_flag);
            validation_flag = false;
            do
            {
                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();
                if (!ValidationData.isCorrectStringData(password, 3))
                {
                    Console.WriteLine("Пароль должен быть не менее 3 символов!");
                }
                else
                {
                    validation_flag = true;
                }
            } while (!validation_flag);

            User user = new User(name, password);
           return user;
        }

    }
}
