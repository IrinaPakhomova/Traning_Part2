namespace Business.Users.DataAccessLayer
{
    interface IUserData
    {
        User GetUser(string name);

        User AddUser(User user);

        User EditUSer(User user);

        bool DeleteUser(User user);
    }
}
