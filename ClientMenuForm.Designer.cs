namespace Lab_2
{
    partial class ClientMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExistingCard = new System.Windows.Forms.Button();
            this.btnRegisterCard = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExistingCard
            // 
            this.btnExistingCard.Location = new System.Drawing.Point(69, 129);
            this.btnExistingCard.Name = "btnExistingCard";
            this.btnExistingCard.Size = new System.Drawing.Size(239, 145);
            this.btnExistingCard.TabIndex = 0;
            this.btnExistingCard.Text = "I already have a card";
            this.btnExistingCard.UseVisualStyleBackColor = true;
            this.btnExistingCard.Click += new System.EventHandler(this.btnExistingCard_Click_1);
            // 
            // btnRegisterCard
            // 
            this.btnRegisterCard.Location = new System.Drawing.Point(489, 129);
            this.btnRegisterCard.Name = "btnRegisterCard";
            this.btnRegisterCard.Size = new System.Drawing.Size(248, 145);
            this.btnRegisterCard.TabIndex = 0;
            this.btnRegisterCard.Text = "Register a new card";
            this.btnRegisterCard.UseVisualStyleBackColor = true;
            this.btnRegisterCard.Click += new System.EventHandler(this.btnRegisterCard_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 38);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // ClientMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegisterCard);
            this.Controls.Add(this.btnExistingCard);
            this.Name = "ClientMenuForm";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExistingCard;
        private System.Windows.Forms.Button btnRegisterCard;
        private System.Windows.Forms.Button btnBack;
    }
}