using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Klasy
{
    public class ToDoTaskManager
    {
        //todo
        private List<ToDoTask> _wszystkieZadania = new List<ToDoTask>();

        public void UsunZadanie(int taskId)
        {
            var taskDoUsuniecia = ZnajdzZadanie(taskId);
            
            
            if (taskDoUsuniecia != null)
            {
                _wszystkieZadania.Remove(taskDoUsuniecia);
            }

            

        }

        public void DodajZadanie(ToDoTask nowyTask)
        {
            _wszystkieZadania.Add(nowyTask);

        }

        public List<ToDoTask> PobierzZadania(User zalogowany)
        {
            List<ToDoTask> zadaniaZalogowanego = new List<ToDoTask>();

            foreach (ToDoTask task in _wszystkieZadania)
            {
               if(task.UserId == zalogowany.Id)
                {
                    zadaniaZalogowanego.Add(task);

                }

            }

            return zadaniaZalogowanego;
        }

        public int ObliczNastepneId()
        {
            int max = 0;

            foreach (var task in _wszystkieZadania)
            {

                if(task.Id > max)
                {
                    max = task.Id;

                }
            }
            return max + 1;
        }

        public ToDoTask ZnajdzZadanie(int id)
        {
            foreach(var task in _wszystkieZadania)
            {
                if (task.Id == id)
                {
                    return task;
                }


            }
            return null;
        }

    }
}
