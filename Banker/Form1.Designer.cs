
namespace Banker
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.newAccount = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.tctextbox = new System.Windows.Forms.TextBox();
            this.TcNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNoText = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genderText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.customerText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountNumberText = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.balanceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Deposit = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.withdrawText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.loanButton = new System.Windows.Forms.Button();
            this.currencyButton = new System.Windows.Forms.Button();
            this.goldButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newAccount
            // 
            this.newAccount.Location = new System.Drawing.Point(16, 260);
            this.newAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newAccount.Name = "newAccount";
            this.newAccount.Size = new System.Drawing.Size(380, 26);
            this.newAccount.TabIndex = 0;
            this.newAccount.Text = "New User";
            this.newAccount.UseVisualStyleBackColor = true;
            this.newAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(608, 80);
            this.AccountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(400, 28);
            this.AccountButton.TabIndex = 1;
            this.AccountButton.Text = "hesap";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tctextbox
            // 
            this.tctextbox.Location = new System.Drawing.Point(16, 36);
            this.tctextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tctextbox.Name = "tctextbox";
            this.tctextbox.Size = new System.Drawing.Size(132, 22);
            this.tctextbox.TabIndex = 2;
            // 
            // TcNo
            // 
            this.TcNo.AutoSize = true;
            this.TcNo.Location = new System.Drawing.Point(17, 12);
            this.TcNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TcNo.Name = "TcNo";
            this.TcNo.Size = new System.Drawing.Size(30, 17);
            this.TcNo.TabIndex = 3;
            this.TcNo.Text = "TC ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Accound Number";
            // 
            // accountNoText
            // 
            this.accountNoText.Location = new System.Drawing.Point(16, 84);
            this.accountNoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountNoText.Name = "accountNoText";
            this.accountNoText.Size = new System.Drawing.Size(132, 22);
            this.accountNoText.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(17, 112);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 17);
            this.Name.TabIndex = 7;
            this.Name.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(16, 132);
            this.nameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(132, 22);
            this.nameText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Surname";
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(16, 180);
            this.surnameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(132, 22);
            this.surnameText.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Age";
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(16, 228);
            this.ageText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(132, 22);
            this.ageText.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phone Number";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(263, 180);
            this.phoneText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(132, 22);
            this.phoneText.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gender";
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(263, 132);
            this.genderText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(132, 22);
            this.genderText.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "customerId";
            // 
            // customerText
            // 
            this.customerText.Location = new System.Drawing.Point(263, 84);
            this.customerText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerText.Name = "customerText";
            this.customerText.Size = new System.Drawing.Size(132, 22);
            this.customerText.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Address";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(263, 36);
            this.addressText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(132, 22);
            this.addressText.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Account Number";
            // 
            // accountNumberText
            // 
            this.accountNumberText.Location = new System.Drawing.Point(608, 36);
            this.accountNumberText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountNumberText.Name = "accountNumberText";
            this.accountNumberText.Size = new System.Drawing.Size(132, 22);
            this.accountNumberText.TabIndex = 22;
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(847, 11);
            this.Balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(59, 17);
            this.Balance.TabIndex = 21;
            this.Balance.Text = "Balance";
            // 
            // balanceText
            // 
            this.balanceText.Location = new System.Drawing.Point(851, 36);
            this.balanceText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.balanceText.Name = "balanceText";
            this.balanceText.Size = new System.Drawing.Size(132, 22);
            this.balanceText.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Money";
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(613, 156);
            this.Deposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(132, 22);
            this.Deposit.TabIndex = 24;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(784, 132);
            this.depositButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(224, 49);
            this.depositButton.TabIndex = 26;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(784, 228);
            this.drawButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(224, 49);
            this.drawButton.TabIndex = 29;
            this.drawButton.Text = "WithDraw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(609, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Money";
            // 
            // withdrawText
            // 
            this.withdrawText.Location = new System.Drawing.Point(613, 252);
            this.withdrawText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.withdrawText.Name = "withdrawText";
            this.withdrawText.Size = new System.Drawing.Size(132, 22);
            this.withdrawText.TabIndex = 27;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(16, 336);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(380, 26);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "Search Customer";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(16, 388);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(380, 26);
            this.updateButton.TabIndex = 31;
            this.updateButton.Text = "Update Customer";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // loanButton
            // 
            this.loanButton.Location = new System.Drawing.Point(628, 336);
            this.loanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loanButton.Name = "loanButton";
            this.loanButton.Size = new System.Drawing.Size(380, 26);
            this.loanButton.TabIndex = 32;
            this.loanButton.Text = "Loan";
            this.loanButton.UseVisualStyleBackColor = true;
            this.loanButton.Click += new System.EventHandler(this.loanButton_Click);
            // 
            // currencyButton
            // 
            this.currencyButton.Location = new System.Drawing.Point(628, 369);
            this.currencyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currencyButton.Name = "currencyButton";
            this.currencyButton.Size = new System.Drawing.Size(380, 26);
            this.currencyButton.TabIndex = 33;
            this.currencyButton.Text = "Foreign Currency";
            this.currencyButton.UseVisualStyleBackColor = true;
            this.currencyButton.Click += new System.EventHandler(this.currencyButton_Click);
            // 
            // goldButton
            // 
            this.goldButton.Location = new System.Drawing.Point(628, 402);
            this.goldButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goldButton.Name = "goldButton";
            this.goldButton.Size = new System.Drawing.Size(380, 26);
            this.goldButton.TabIndex = 34;
            this.goldButton.Text = "Gold Account";
            this.goldButton.UseVisualStyleBackColor = true;
            this.goldButton.Click += new System.EventHandler(this.goldButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.goldButton);
            this.Controls.Add(this.currencyButton);
            this.Controls.Add(this.loanButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.withdrawText);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountNumberText);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.balanceText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountNoText);
            this.Controls.Add(this.TcNo);
            this.Controls.Add(this.tctextbox);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.newAccount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newAccount;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.TextBox tctextbox;
        private System.Windows.Forms.Label TcNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountNoText;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox genderText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountNumberText;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.TextBox balanceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Deposit;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox withdrawText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button loanButton;
        private System.Windows.Forms.Button currencyButton;
        private System.Windows.Forms.Button goldButton;
    }
}

