using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Klasy
{
    public class User
    {
        public readonly Guid Id;
        public string Login;
        public string Haslo;
        private string _imie;

        public User(Guid id, string login, string haslo, string imie)
        {
            Id = id;
            Login = login;
            Haslo = haslo;
            _imie = imie;
        }
    }
}
