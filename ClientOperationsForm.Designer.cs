namespace Lab_2
{
    partial class ClientOperationsForm
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
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnBlockCard = new System.Windows.Forms.Button();
            this.btnDeleteCard = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(20, 95);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(370, 23);
            this.btnCheckBalance.TabIndex = 0;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click_1);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(20, 146);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(370, 23);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Transfer Money";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnBlockCard
            // 
            this.btnBlockCard.Location = new System.Drawing.Point(20, 195);
            this.btnBlockCard.Name = "btnBlockCard";
            this.btnBlockCard.Size = new System.Drawing.Size(370, 23);
            this.btnBlockCard.TabIndex = 0;
            this.btnBlockCard.Text = "Block Card";
            this.btnBlockCard.UseVisualStyleBackColor = true;
            this.btnBlockCard.Click += new System.EventHandler(this.btnBlockCard_Click);
            // 
            // btnDeleteCard
            // 
            this.btnDeleteCard.Location = new System.Drawing.Point(20, 241);
            this.btnDeleteCard.Name = "btnDeleteCard";
            this.btnDeleteCard.Size = new System.Drawing.Size(370, 23);
            this.btnDeleteCard.TabIndex = 0;
            this.btnDeleteCard.Text = "Delete Card";
            this.btnDeleteCard.UseVisualStyleBackColor = true;
            this.btnDeleteCard.Click += new System.EventHandler(this.btnDeleteCard_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(20, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(190, 67);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button5_Click);
            // 
            // ClientOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteCard);
            this.Controls.Add(this.btnBlockCard);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnCheckBalance);
            this.Name = "ClientOperationsForm";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnBlockCard;
        private System.Windows.Forms.Button btnDeleteCard;
        private System.Windows.Forms.Button btnBack;
    }
}