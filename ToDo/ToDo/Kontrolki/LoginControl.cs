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

namespace ToDo.Kontrolki
{
    public partial class LoginControl : UserControl
    {
        private MainForm _mainForm;
        public LoginControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = TbLogin.Text;
            string haslo = TbHaslo.Text;

            if(string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(haslo))
            {
                lblWalidacjaLogowania.Text = "Login i hasło są wymagane";
                lblWalidacjaLogowania.Visible = true;
                return;

            }

            User znalezionyUser = _mainForm.UserManager.WyszukajUsera(login, haslo);

            if(znalezionyUser == null)
            {
                lblWalidacjaLogowania.Text = "Nieprawidłowe login lub hasło";
                lblWalidacjaLogowania.Visible = true;
            }
            else
            {
                _mainForm.PokazTaskControl(znalezionyUser);
            }

            
        }

        private void TbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }

        private void BtnZalozKonto_Click(object sender, EventArgs e)
        {
            _mainForm.PokazRegisterControl();
        }
    }
}
