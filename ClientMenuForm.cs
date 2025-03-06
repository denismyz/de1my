using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Lab_2
{
    public partial class ClientMenuForm : MaterialForm
    {
        public ClientMenuForm()
        {
            InitializeComponent();
        }

        private void btnExistingCard_Click_1(object sender, EventArgs e)
        {
            ClientLoginForm loginForm = new ClientLoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnRegisterCard_Click_1(object sender, EventArgs e)
        {
            RegisterCardForm registerForm = new RegisterCardForm();
            registerForm.ShowDialog();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}