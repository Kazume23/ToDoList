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
using ToDo.Kontrolki;

namespace ToDo
{
    public partial class MainForm : Form
    {
        public UserManager UserManager;

        public MainForm()
        {
            InitializeComponent();
            PokazLoginControl();

            UserManager = new UserManager();
        }

        public void PokazLoginControl()
        {
            Controls.Clear();
            Controls.Add(new LoginControl(this));


        }
       
        public void PokazRegisterControl()
        {
            Controls.Clear();
            Controls.Add(new RegisterControl(this));


        }
        public void PokazTaskControl(User user)
        {
            Controls.Clear();
            Controls.Add(new TasksControl(this, user));


        }
    }
}
