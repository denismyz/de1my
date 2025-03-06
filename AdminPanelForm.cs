using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab_2
{

    public partial class AdminPanelForm : Form
    {
        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public AdminPanelForm()
        {
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients()
        {
            dataGridViewClients.Rows.Clear();
            if (!File.Exists("clients.txt")) return;

            string[] lines = File.ReadAllLines("clients.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 4)
                {
                    string name = parts[0].Trim();
                    string cardNumber = parts[1].Trim();
                    string balance = parts[2].Trim();
                    string status = parts[3].Trim();

                    // Виправляємо відображення статусу
                    if (status.ToLower() == "blocked") status = "Blocked";
                    else status = "Active";

                    dataGridViewClients.Rows.Add(name, cardNumber, balance, status);
                }
            }
        }

        private void btnBlockCard_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                string selectedCardNumber = dataGridViewClients.SelectedRows[0].Cells["ColumnCardNumber"].Value.ToString();
                string[] lines = File.ReadAllLines("clients.txt");

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length < 4) continue;

                    if (parts[1].Trim() == selectedCardNumber)
                    {
                        // Перемикаємо статус Blocked/Active
                        parts[3] = (parts[3].Trim().ToLower() == "blocked") ? "Active" : "Blocked";
                        lines[i] = string.Join(",", parts);
                        break;
                    }
                }

                File.WriteAllLines("clients.txt", lines);
                LoadClients();
            }
            else
            {
                MessageBox.Show("Select a card to block!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            AdminLoginForm loginForm = new AdminLoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
