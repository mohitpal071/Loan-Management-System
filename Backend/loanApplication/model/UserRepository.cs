using System.Xml.Linq;

namespace loanApplication.model
{
    public interface IUserRepository
    {
        void AddUser(User u);
        User GetUser(string username);
        List<User> GetUser();
        void DeleteUser(string username);
    }
    public class UserRepository : IUserRepository
    {
        private readonly List<User> users = new List<User>()
        {
            new User(){username="abc_1",password="4334dfsdf"},
            new User(){username="a",password="4"},

            new User(){username="xyz",password="23sdg4dfsdf"},

        };
        public void AddUser(User user)
        {
            try
            {
                users.Add(user);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteUser(string username)
        {
            try
            {
                User user= GetUser(username);
                users.Remove(user); //remove user
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User GetUser(string username)
        {
            try
            {
                return users.Single(User=> User.username == username); //retrun Userwith specific model
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<User> GetUser()
        {
            throw new NotImplementedException();
        }
        public bool ValidateUser(User user)
        {
            

            try
            {
                foreach (var u in users)
                {
                    if (u.username == user.username && u.password == user.password)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<User> GetUsers()
        {
            try
            {
                return users;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
