using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace Business.Users.DataAccessLayer
{
    class StorageUsers
    {
        private const string pathFileUsers = @"user.txt";
        private const string pathFileUsersTemp = @"usertemp.txt";
        private static StorageUsers instance;
        private StorageUsers()
        {
            if (!File.Exists(pathFileUsers))
            {
                File.Create(pathFileUsers);
            }
        }
        public static StorageUsers getInstance()
        {
            if (instance == null)
                instance = new StorageUsers();
            return instance;
        }
        public void AddDataToStorage(User user)
        {
            using (StreamWriter sw = new StreamWriter(pathFileUsers, true, System.Text.Encoding.Default))
            {
                string json = JsonConvert.SerializeObject(user);
                sw.WriteLine(json);
                Console.WriteLine("Юзер добавлен");
            }

        }
        public List<User> ReadUsersFromStorage()
        {
            List<User> list = new List<User>();
            using (StreamReader sr = new StreamReader(pathFileUsers, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(JsonConvert.DeserializeObject<User>(line));
                }
            }
            return list;
        }
        public void ReWriteStorage(List<User> users)
        {
            if (File.Exists(pathFileUsersTemp))
            {
                File.Delete(pathFileUsersTemp);
            }
            File.Move(pathFileUsers, pathFileUsersTemp);
            using (StreamWriter sw = new StreamWriter(pathFileUsers, true, System.Text.Encoding.Default))
            {
                string json;
                foreach (User user in users)
                {
                    json = JsonConvert.SerializeObject(user);
                    sw.WriteLine(json);
                }
            }
        }
       
    }
}
