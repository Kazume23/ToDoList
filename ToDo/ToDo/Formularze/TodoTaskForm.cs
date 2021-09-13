using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ToDo.Klasy;

namespace ToDo.Formularze
{
    public partial class TodoTaskForm : Form
    {
        public bool CzyZapisano;

        private ToDoTask _task;

        public TodoTaskForm(ToDoTask zadanie)
        {
            InitializeComponent();
            _task = zadanie;
            txtNazwaTaska.Text = zadanie.Tytul;
            txtOpisTaska.Text = zadanie.Opis;
            cbCzyZakonczone.Checked = zadanie.CzyZrobione;
            lblNumerTaska.Text = zadanie.Id.ToString();
            CzyZapisano = false;
        }

        

        private void btnZapiszTask_Click(object sender, EventArgs e)
        {
            _task.CzyZrobione = cbCzyZakonczone.Checked;
            _task.Tytul = txtNazwaTaska.Text;
            _task.Opis = txtOpisTaska.Text;
            CzyZapisano = true;
            Close();
        }
    }
}
