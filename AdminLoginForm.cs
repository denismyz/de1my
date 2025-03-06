using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.Text == "1234")
            {
                AdminPanelForm panelForm = new AdminPanelForm();
                panelForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password!");
            }
        }
    }
}
