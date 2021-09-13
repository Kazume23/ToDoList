using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Klasy
{
    public class ToDoTask
    {
        public int Id;
        public bool CzyZrobione;
        public string Tytul;
        public string Opis;
        public readonly Guid UserId;

        public ToDoTask(int id, bool czyZrobione, string tytul, string opis, Guid userId)
        {
            Id = id;
            CzyZrobione = czyZrobione;
            Tytul = tytul;
            Opis = opis;
            UserId = userId;
        }
    }
}
