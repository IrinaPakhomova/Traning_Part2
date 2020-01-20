using System;
using System.IO;

namespace Answer_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            const string pathFileUsers = @"user.txt";
            const string pathFileUsersTemp = @"usertemp.txt";
            if (!File.Exists(pathFileUsers))
            {
                File.Create(pathFileUsers);
            }
            File.Move(pathFileUsers, pathFileUsersTemp);

        }
    }
}
