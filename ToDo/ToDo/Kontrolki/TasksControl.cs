using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Klasy;
using ToDo.Formularze;

namespace ToDo.Kontrolki
{
    public partial class TasksControl : UserControl
    {
        private MainForm _mainForm;
        private User _zalogowany;
        private ToDoTaskManager _taskManager;

        public TasksControl(MainForm mainForm, User user)
        {
            InitializeComponent();
            _taskManager = new ToDoTaskManager();
            _mainForm = mainForm;
            Dock = DockStyle.Fill;


            _zalogowany = user;
            lblZalogowanyWartosc.Text = _zalogowany.Login;

            
            foreach (ToDoTask zadanie in _taskManager.PobierzZadania(_zalogowany))
            {
                DodajZadanieDoListy(zadanie);

            }

        }

        private void DodajZadanieDoListy(ToDoTask zadanieDoDodania)
        {
            ListViewItem nowyItem = new ListViewItem(zadanieDoDodania.Id.ToString());
            nowyItem.SubItems.Add(zadanieDoDodania.Tytul);

            string czyZrobione = zadanieDoDodania.CzyZrobione ? "Tak" : "Nie";
            nowyItem.SubItems.Add(czyZrobione);

            lvZadania.Items.Add(nowyItem);

        }

        private void lblZalogowanyWartosc_Click(object sender, EventArgs e)
        {

        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            _mainForm.PokazLoginControl();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (lvZadania.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano elementu do skasowania", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListViewItem itemDoUsuniecia = lvZadania.SelectedItems[0];
                int idTaskaDoUsuniecia = int.Parse(lvZadania.SelectedItems[0].SubItems[0].Text);
                _taskManager.UsunZadanie(idTaskaDoUsuniecia);
                lvZadania.Items.Remove(itemDoUsuniecia);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int id = _taskManager.ObliczNastepneId();
            ToDoTask newTask = new ToDoTask(id, false, "", "", _zalogowany.Id);
            TodoTaskForm taskForm = new TodoTaskForm(newTask);
            taskForm.ShowDialog();

            if (taskForm.CzyZapisano)
            {
                _taskManager.DodajZadanie(newTask);
                DodajZadanieDoListy(newTask);

            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (lvZadania.SelectedItems.Count == 0)
            {
                MessageBox.Show("Przed edycją zaznacz zadanie");

            }
            else
            {
                string taskId = lvZadania.SelectedItems[0].SubItems[0].Text;

                ToDoTask task = _taskManager.ZnajdzZadanie(int.Parse(taskId));

                TodoTaskForm form = new TodoTaskForm(task);
                form.ShowDialog();

                if (form.CzyZapisano)
                {
                    lvZadania.SelectedItems[0].SubItems[1].Text = task.Tytul;
                    lvZadania.SelectedItems[0].SubItems[2].Text = task.CzyZrobione ? "tak" : "nie";

                }

            }
        }
    }
}
