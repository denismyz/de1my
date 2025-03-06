using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Xml.Linq;

namespace Lab_2
{
    public partial class ClientLoginForm : MaterialForm
    {
        public ClientLoginForm()
        {
            InitializeComponent();
        }
      
        

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ClientMenuForm menuForm = new ClientMenuForm();
            menuForm.Show();
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string cardNumber = txtCardNumber.Text;

            if (File.Exists("clients.txt"))
            {
                string[] lines = File.ReadAllLines("clients.txt");
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    if (data[0] == name && data[1] == cardNumber)
                    {
                        MessageBox.Show("Login successful!");
                        ClientOperationsForm operationsForm = new ClientOperationsForm(name, cardNumber);
                        operationsForm.Show();
                        this.Hide();
                        return;
                    }
                }
            }

            MessageBox.Show("Card not found!");
        }
    }
}
