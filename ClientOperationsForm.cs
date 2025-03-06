using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Lab_2
{
    public partial class ClientOperationsForm : MaterialForm
    {
        private string name;
        private string cardNumber;
        private string currentCardNumber;

        public ClientOperationsForm(string name, string cardNumber)
        {
            InitializeComponent();
            currentCardNumber = cardNumber;
            this.name = name;
            this.cardNumber = cardNumber;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm(currentCardNumber);
            transferForm.ShowDialog();
        }

        private void btnCheckBalance_Click_1(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("clients.txt");
            string account = lines.FirstOrDefault(line => line.StartsWith(name + "," + cardNumber));

            if (account != null)
            {
                string[] data = account.Split(',');
                MessageBox.Show($"Your balance: {data[2]} grn.");
            }
            else
            {
                MessageBox.Show("Account not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBlockCard_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("clients.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                if (data.Length < 4) continue;

                if (data[1].Trim() == currentCardNumber)
                {
                    
                    data[3] = (data[3].Trim().ToLower() == "blocked") ? "Active" : "Blocked";
                    lines[i] = string.Join(",", data);
                    break;
                }
            }

            File.WriteAllLines("clients.txt", lines);
            MessageBox.Show("Card status updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteCard_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("clients.txt");
            List<string> updatedLines = lines.Where(line => !line.StartsWith(name + "," + currentCardNumber)).ToList();

            if (updatedLines.Count < lines.Length)
            {
                File.WriteAllLines("clients.txt", updatedLines);
                MessageBox.Show("Card successfully deleted.");
            }
            else
            {
                MessageBox.Show("Card not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClientMenuForm menuForm = new ClientMenuForm();
            menuForm.Show();
            this.Close();
        }
    }
}
