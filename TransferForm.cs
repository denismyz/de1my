using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Lab_2
{
    public partial class TransferForm : MaterialForm
    {
        private string currentCardNumber;
        public TransferForm(string cardNumber)
        {
            InitializeComponent();
            currentCardNumber = cardNumber;
        }


        private void btnTransfer_Click(object sender, EventArgs e)
        {
            /*string targetCard = txtTargetCard.Text.Trim();
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Write correct sum!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(targetCard))
            {
                MessageBox.Show("Write corect card!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines("clients.txt");
            int senderIndex = Array.FindIndex(lines, line => line.StartsWith(currentCardNumber + ","));
            int receiverIndex = Array.FindIndex(lines, line => line.StartsWith(targetCard + ","));

            if (senderIndex == -1)
            {
                MessageBox.Show("Error! Your card isn found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (receiverIndex == -1)
            {
                MessageBox.Show("Error! Card which get money isn`t found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] senderData = lines[senderIndex].Split(',');
            string[] receiverData = lines[receiverIndex].Split(',');

            decimal senderBalance = decimal.Parse(senderData[2]);
            decimal receiverBalance = decimal.Parse(receiverData[2]);

            if (senderBalance < amount)
            {
                MessageBox.Show("No enought money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            senderBalance -= amount;
            receiverBalance += amount;

            senderData[2] = senderBalance.ToString();
            receiverData[2] = receiverBalance.ToString();

            lines[senderIndex] = string.Join(",", senderData);
            lines[receiverIndex] = string.Join(",", receiverData);

            File.WriteAllLines("clients.txt", lines);

            MessageBox.Show("Transfer is seccussful!", "Seccusseful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();*/

        
            try
            {
                string targetCard = txtTargetCard.Text.Trim();
                if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Write the correct amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(targetCard))
                {
                    MessageBox.Show("Write the correct target card!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!File.Exists("clients.txt"))
                {
                    MessageBox.Show("Clients file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines("clients.txt");

                if (lines.Length == 0)
                {
                    MessageBox.Show("Clients file is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int senderIndex = -1;
                int receiverIndex = -1;

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');

                    if (parts.Length < 4) continue; 

                    string name = parts[0];
                    string cardNumber = parts[1];

                    if (cardNumber == currentCardNumber) senderIndex = i;
                    if (cardNumber == targetCard) receiverIndex = i;
                }

                if (senderIndex == -1)
                {
                    MessageBox.Show("Error! Your card isn't found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (receiverIndex == -1)
                {
                    MessageBox.Show("Error! The recipient's card isn't found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] senderData = lines[senderIndex].Split(',');
                string[] receiverData = lines[receiverIndex].Split(',');

                decimal senderBalance = decimal.Parse(senderData[2], System.Globalization.CultureInfo.InvariantCulture);
                decimal receiverBalance = decimal.Parse(receiverData[2], System.Globalization.CultureInfo.InvariantCulture);

                bool senderBlocked = senderData[3].Trim().ToLower() == "blocked";
                bool receiverBlocked = receiverData[3].Trim().ToLower() == "blocked";

                if (senderBlocked)
                {
                    MessageBox.Show("Your card is blocked! Transfers are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (receiverBlocked)
                {
                    MessageBox.Show("The recipient's card is blocked! Transfers are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (senderBalance < amount)
                {
                    MessageBox.Show("Not enough money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                senderBalance -= amount;
                receiverBalance += amount;

                senderData[2] = senderBalance.ToString(System.Globalization.CultureInfo.InvariantCulture);
                receiverData[2] = receiverBalance.ToString(System.Globalization.CultureInfo.InvariantCulture);

                lines[senderIndex] = string.Join(",", senderData);
                lines[receiverIndex] = string.Join(",", receiverData);

                File.WriteAllLines("clients.txt", lines);

                MessageBox.Show("Transfer is successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtTargetCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
