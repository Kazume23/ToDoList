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
    public partial class RegisterControl : UserControl
    {
        private MainForm _mainForm;
        public RegisterControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            Dock = DockStyle.Fill;
        }

        private void btnZarejestruj_Click(object sender, EventArgs e)
        {
            //1 
            if (WalidujForm())
            {
                //2
                User nowyUser = new User(Guid.NewGuid(), tbLogin.Text, tbHaslo.Text, tbImie.Text);
                //3
                _mainForm.UserManager.Users.Add(nowyUser);
                //4
                _mainForm.PokazTaskControl(nowyUser);
            }
          
        }

        private bool WalidujForm()
        {
            lblImieWalidacja.Visible = false;
            lblLoginWalidacja.Visible = false;
            lblHasloWalidacja.Visible = false;
            lblPowtorzHasloWalidacja.Visible = false;

            bool CzyWszystkoOk = true;

            if (string.IsNullOrWhiteSpace(tbImie.Text) || tbImie.Text.Contains("!") || tbImie.Text.Contains("  "))
            {
                CzyWszystkoOk = false;
                lblImieWalidacja.Visible = true;
                lblImieWalidacja.Text = "Twoje imię jest nieprawidłowe";

            }

            if (string.IsNullOrWhiteSpace(tbLogin.Text) || tbLogin.Text.Contains("!") || tbLogin.Text.Contains("  "))
            {
                CzyWszystkoOk = false;
                lblLoginWalidacja.Visible = true;
                lblLoginWalidacja.Text = "Twój login jest nieprawidłowy";

            }
            if (_mainForm.UserManager.CzyLoginWolny(tbLogin.Text) == false)
            {
                CzyWszystkoOk = false;
                lblLoginWalidacja.Visible = true;
                lblLoginWalidacja.Text = "Ten login jest już zajęty";
            }
            if (string.IsNullOrWhiteSpace(tbHaslo.Text) || tbHaslo.Text.Contains("!") || tbHaslo.Text.Contains("  ") ||
                tbHaslo.Text.Length < 8 || tbHaslo.Text.Length > 32)
            {
                CzyWszystkoOk = false;
                lblHasloWalidacja.Visible = true;
                lblHasloWalidacja.Text = "Twoje hasło jest nieprawidłowe. Musi mieć od 8 do 32 znaków";

            }
            if (tbHaslo.Text != tbPowtorzHaslo.Text)
            {
                CzyWszystkoOk = false;
                lblPowtorzHasloWalidacja.Visible = true;
                lblPowtorzHasloWalidacja.Text = "Hasła nie są identyczne";
            }
            return CzyWszystkoOk;
        }

        private void btnCofnij_Click(object sender, EventArgs e)
        {
            _mainForm.PokazLoginControl();
        }
    }
}
