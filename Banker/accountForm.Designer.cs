
namespace Banker
{
    partial class accountForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.mountlyText = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.amountText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.purposeText = new System.Windows.Forms.TextBox();
            this.loanText = new System.Windows.Forms.TextBox();
            this.loanButton = new System.Windows.Forms.Button();
            this.TcNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ForeignnNumberText = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.foreingBalanceText = new System.Windows.Forms.TextBox();
            this.ForeignButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.goldNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.goldBalance = new System.Windows.Forms.TextBox();
            this.GoldButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TypeText = new System.Windows.Forms.TextBox();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.foreDepositButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DepositforeText = new System.Windows.Forms.TextBox();
            this.foreDrawButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.foreWithdrawText = new System.Windows.Forms.TextBox();
            this.goldDrawButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.goldDrawText = new System.Windows.Forms.TextBox();
            this.goldDepositButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.goldDepositText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Montly Payment";
            // 
            // mountlyText
            // 
            this.mountlyText.Location = new System.Drawing.Point(179, 73);
            this.mountlyText.Name = "mountlyText";
            this.mountlyText.Size = new System.Drawing.Size(100, 20);
            this.mountlyText.TabIndex = 17;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 135);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(46, 13);
            this.Name.TabIndex = 16;
            this.Name.Text = "Amount ";
            // 
            // amountText
            // 
            this.amountText.Location = new System.Drawing.Point(11, 151);
            this.amountText.Name = "amountText";
            this.amountText.Size = new System.Drawing.Size(100, 20);
            this.amountText.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Purpose";
            // 
            // purposeText
            // 
            this.purposeText.Location = new System.Drawing.Point(11, 112);
            this.purposeText.Name = "purposeText";
            this.purposeText.Size = new System.Drawing.Size(100, 20);
            this.purposeText.TabIndex = 13;
            // 
            // loanText
            // 
            this.loanText.Location = new System.Drawing.Point(11, 73);
            this.loanText.Name = "loanText";
            this.loanText.Size = new System.Drawing.Size(100, 20);
            this.loanText.TabIndex = 12;
            // 
            // loanButton
            // 
            this.loanButton.Location = new System.Drawing.Point(11, 217);
            this.loanButton.Name = "loanButton";
            this.loanButton.Size = new System.Drawing.Size(268, 21);
            this.loanButton.TabIndex = 11;
            this.loanButton.Text = "Loan";
            this.loanButton.UseVisualStyleBackColor = true;
            this.loanButton.Click += new System.EventHandler(this.loanButton_Click);
            // 
            // TcNo
            // 
            this.TcNo.AutoSize = true;
            this.TcNo.Location = new System.Drawing.Point(12, 57);
            this.TcNo.Name = "TcNo";
            this.TcNo.Size = new System.Drawing.Size(71, 13);
            this.TcNo.TabIndex = 20;
            this.TcNo.Text = "Loan Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Total Payment";
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(179, 112);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(100, 20);
            this.totalText.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Account Number";
            // 
            // ForeignnNumberText
            // 
            this.ForeignnNumberText.Location = new System.Drawing.Point(407, 73);
            this.ForeignnNumberText.Name = "ForeignnNumberText";
            this.ForeignnNumberText.Size = new System.Drawing.Size(100, 20);
            this.ForeignnNumberText.TabIndex = 27;
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(624, 45);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(46, 13);
            this.Balance.TabIndex = 26;
            this.Balance.Text = "Balance";
            // 
            // foreingBalanceText
            // 
            this.foreingBalanceText.Location = new System.Drawing.Point(627, 73);
            this.foreingBalanceText.Name = "foreingBalanceText";
            this.foreingBalanceText.Size = new System.Drawing.Size(100, 20);
            this.foreingBalanceText.TabIndex = 25;
            // 
            // ForeignButton
            // 
            this.ForeignButton.Location = new System.Drawing.Point(407, 100);
            this.ForeignButton.Name = "ForeignButton";
            this.ForeignButton.Size = new System.Drawing.Size(320, 23);
            this.ForeignButton.TabIndex = 24;
            this.ForeignButton.Text = "Foreign Curreny";
            this.ForeignButton.UseVisualStyleBackColor = true;
            this.ForeignButton.Click += new System.EventHandler(this.ForeignButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Account Number";
            // 
            // goldNumber
            // 
            this.goldNumber.Location = new System.Drawing.Point(407, 265);
            this.goldNumber.Name = "goldNumber";
            this.goldNumber.Size = new System.Drawing.Size(156, 20);
            this.goldNumber.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Balance";
            // 
            // goldBalance
            // 
            this.goldBalance.Location = new System.Drawing.Point(569, 265);
            this.goldBalance.Name = "goldBalance";
            this.goldBalance.Size = new System.Drawing.Size(158, 20);
            this.goldBalance.TabIndex = 30;
            // 
            // GoldButton
            // 
            this.GoldButton.Location = new System.Drawing.Point(407, 301);
            this.GoldButton.Name = "GoldButton";
            this.GoldButton.Size = new System.Drawing.Size(320, 23);
            this.GoldButton.TabIndex = 29;
            this.GoldButton.Text = "Gold Account";
            this.GoldButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Type";
            // 
            // TypeText
            // 
            this.TypeText.Location = new System.Drawing.Point(513, 73);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(108, 20);
            this.TypeText.TabIndex = 39;
            // 
            // PaymentButton
            // 
            this.PaymentButton.Location = new System.Drawing.Point(11, 179);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(268, 23);
            this.PaymentButton.TabIndex = 41;
            this.PaymentButton.Text = "Payment";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // foreDepositButton
            // 
            this.foreDepositButton.Location = new System.Drawing.Point(407, 179);
            this.foreDepositButton.Name = "foreDepositButton";
            this.foreDepositButton.Size = new System.Drawing.Size(142, 23);
            this.foreDepositButton.TabIndex = 44;
            this.foreDepositButton.Text = "Payment";
            this.foreDepositButton.UseVisualStyleBackColor = true;
            this.foreDepositButton.Click += new System.EventHandler(this.foreDepositButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Deposit Money";
            // 
            // DepositforeText
            // 
            this.DepositforeText.Location = new System.Drawing.Point(407, 151);
            this.DepositforeText.Name = "DepositforeText";
            this.DepositforeText.Size = new System.Drawing.Size(142, 20);
            this.DepositforeText.TabIndex = 42;
            // 
            // foreDrawButton
            // 
            this.foreDrawButton.Location = new System.Drawing.Point(585, 179);
            this.foreDrawButton.Name = "foreDrawButton";
            this.foreDrawButton.Size = new System.Drawing.Size(142, 23);
            this.foreDrawButton.TabIndex = 47;
            this.foreDrawButton.Text = "Payment";
            this.foreDrawButton.UseVisualStyleBackColor = true;
            this.foreDrawButton.Click += new System.EventHandler(this.foreDrawButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Withdraw Money";
            // 
            // foreWithdrawText
            // 
            this.foreWithdrawText.Location = new System.Drawing.Point(585, 151);
            this.foreWithdrawText.Name = "foreWithdrawText";
            this.foreWithdrawText.Size = new System.Drawing.Size(142, 20);
            this.foreWithdrawText.TabIndex = 45;
            // 
            // goldDrawButton
            // 
            this.goldDrawButton.Location = new System.Drawing.Point(585, 384);
            this.goldDrawButton.Name = "goldDrawButton";
            this.goldDrawButton.Size = new System.Drawing.Size(142, 23);
            this.goldDrawButton.TabIndex = 53;
            this.goldDrawButton.Text = "Payment";
            this.goldDrawButton.UseVisualStyleBackColor = true;
            this.goldDrawButton.Click += new System.EventHandler(this.goldDrawButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(586, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Withdraw Money";
            // 
            // goldDrawText
            // 
            this.goldDrawText.Location = new System.Drawing.Point(585, 356);
            this.goldDrawText.Name = "goldDrawText";
            this.goldDrawText.Size = new System.Drawing.Size(142, 20);
            this.goldDrawText.TabIndex = 51;
            // 
            // goldDepositButton
            // 
            this.goldDepositButton.Location = new System.Drawing.Point(407, 384);
            this.goldDepositButton.Name = "goldDepositButton";
            this.goldDepositButton.Size = new System.Drawing.Size(142, 23);
            this.goldDepositButton.TabIndex = 50;
            this.goldDepositButton.Text = "Payment";
            this.goldDepositButton.UseVisualStyleBackColor = true;
            this.goldDepositButton.Click += new System.EventHandler(this.goldDepositButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Deposit Money";
            // 
            // goldDepositText
            // 
            this.goldDepositText.Location = new System.Drawing.Point(407, 356);
            this.goldDepositText.Name = "goldDepositText";
            this.goldDepositText.Size = new System.Drawing.Size(142, 20);
            this.goldDepositText.TabIndex = 48;
            // 
            // accountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goldDrawButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.goldDrawText);
            this.Controls.Add(this.goldDepositButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.goldDepositText);
            this.Controls.Add(this.foreDrawButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.foreWithdrawText);
            this.Controls.Add(this.foreDepositButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DepositforeText);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.goldNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.goldBalance);
            this.Controls.Add(this.GoldButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ForeignnNumberText);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.foreingBalanceText);
            this.Controls.Add(this.ForeignButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.TcNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mountlyText);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purposeText);
            this.Controls.Add(this.loanText);
            this.Controls.Add(this.loanButton);
            this.Text = "accountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mountlyText;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox amountText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox purposeText;
        private System.Windows.Forms.TextBox loanText;
        private System.Windows.Forms.Button loanButton;
        private System.Windows.Forms.Label TcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ForeignnNumberText;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.TextBox foreingBalanceText;
        private System.Windows.Forms.Button ForeignButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox goldNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox goldBalance;
        private System.Windows.Forms.Button GoldButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TypeText;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button foreDepositButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DepositforeText;
        private System.Windows.Forms.Button foreDrawButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox foreWithdrawText;
        private System.Windows.Forms.Button goldDrawButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox goldDrawText;
        private System.Windows.Forms.Button goldDepositButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox goldDepositText;
    }
}