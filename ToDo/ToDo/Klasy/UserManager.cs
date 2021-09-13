using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Klasy
{
    public class UserManager
    {
        public List<User> Users = new List<User>();

        public UserManager()
        {
            Users.Add(new User(Guid.NewGuid(), "test", "test", "test" ));
        }

        public User WyszukajUsera(string login, string haslo)
        {
            foreach (User user in Users)
            {
                if (user.Login == login && user.Haslo == haslo)
                {
                    return user;
                }

            }

            return null;
        }

        public bool CzyLoginWolny(string login)
        {
            foreach (User user in Users)
            {
                if (user.Login == login)
                {
                    return false;
                }

            }

            return true;

        }
    }
}
