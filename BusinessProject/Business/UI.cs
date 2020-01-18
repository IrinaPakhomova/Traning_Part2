//using TestProject.UserDataValidation;
using Business.Users.DataAccessLayer;

namespace Business
{
    class UI
    {
        private readonly IUserData users;

        public UI()
        {
            users = new UserData();
        }
    }
}
