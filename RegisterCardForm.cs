using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace Lab_2

{
    public partial class RegisterCardForm : MaterialForm
    {
        public RegisterCardForm()
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInitialBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string cardNumber = txtCardNumber.Text;
            decimal initialBalance;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(cardNumber) ||
                !decimal.TryParse(txtInitialBalance.Text, out initialBalance))
            {
                MessageBox.Show("Please fill in all fields correctly");
                return;
            }

            using (StreamWriter sw = new StreamWriter("clients.txt", true))
            {
                sw.WriteLine($"{name},{cardNumber},{initialBalance},false"); // false card isn`t blocked
            }

            MessageBox.Show("Card successfully created!");
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClientMenuForm cmForm = new ClientMenuForm();
            cmForm.Show();
            this.Close();
        }
    }
}