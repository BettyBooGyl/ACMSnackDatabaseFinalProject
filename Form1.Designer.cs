namespace ACMSnackDatabase
{
    partial class Form1
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
            this.OutOfStockButton = new System.Windows.Forms.Button();
            this.nicnameTextBox = new System.Windows.Forms.TextBox();
            this.debitBox1 = new System.Windows.Forms.TextBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.debitLabel = new System.Windows.Forms.Label();
            this.newUserLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.NukeAll = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.purchase = new System.Windows.Forms.Button();
            this.addFunds = new System.Windows.Forms.Button();
            this.addFundsTextBox = new System.Windows.Forms.TextBox();
            this.listBoxOutOfStock = new System.Windows.Forms.ListBox();
            this.viewSnackButton = new System.Windows.Forms.Button();
            this.viewDrinkButton = new System.Windows.Forms.Button();
            this.viewItemButton = new System.Windows.Forms.Button();
            this.viewTransactions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.snackName = new System.Windows.Forms.TextBox();
            this.snackCost = new System.Windows.Forms.TextBox();
            this.snackDescription = new System.Windows.Forms.TextBox();
            this.drinkDescription = new System.Windows.Forms.TextBox();
            this.drinkCost = new System.Windows.Forms.TextBox();
            this.drinkName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.snackAdd = new System.Windows.Forms.Button();
            this.DrinkAdd = new System.Windows.Forms.Button();
            this.isCaffinated = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutOfStockGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OutOfStockButton
            // 
            this.OutOfStockButton.Location = new System.Drawing.Point(84, 560);
            this.OutOfStockButton.Location = new System.Drawing.Point(112, 315);
            this.OutOfStockButton.Margin = new System.Windows.Forms.Padding(4);
            this.OutOfStockButton.Name = "OutOfStockButton";
            this.OutOfStockButton.Size = new System.Drawing.Size(201, 37);
            this.OutOfStockButton.TabIndex = 0;
            this.OutOfStockButton.Text = "Check Out of stock items";
            this.OutOfStockButton.UseVisualStyleBackColor = true;
            this.OutOfStockButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutOfStockGridView
            // 
            this.OutOfStockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutOfStockGridView.Location = new System.Drawing.Point(112, 374);
            this.OutOfStockGridView.Margin = new System.Windows.Forms.Padding(4);
            this.OutOfStockGridView.Name = "OutOfStockGridView";
            this.OutOfStockGridView.RowHeadersWidth = 123;
            this.OutOfStockGridView.Size = new System.Drawing.Size(808, 321);
            this.OutOfStockGridView.TabIndex = 1;
            this.OutOfStockGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DisplayUserButton
            // 
            this.DisplayUserButton.Location = new System.Drawing.Point(969, 374);
            this.DisplayUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayUserButton.Name = "DisplayUserButton";
            this.DisplayUserButton.Size = new System.Drawing.Size(201, 37);
            this.DisplayUserButton.TabIndex = 3;
            this.DisplayUserButton.Text = "Display Users";
            this.DisplayUserButton.UseVisualStyleBackColor = true;
            this.DisplayUserButton.Click += new System.EventHandler(this.DisplayUserButton_Click);
            // 
            // nicnameTextBox
            // 
            this.nicnameTextBox.Location = new System.Drawing.Point(1484, 272);
            this.nicnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nicnameTextBox.Name = "nicnameTextBox";
            this.nicnameTextBox.Size = new System.Drawing.Size(132, 22);
            this.nicnameTextBox.TabIndex = 4;
            // 
            // debitBox1
            // 
            this.debitBox1.Location = new System.Drawing.Point(1675, 272);
            this.debitBox1.Margin = new System.Windows.Forms.Padding(4);
            this.debitBox1.Name = "debitBox1";
            this.debitBox1.Size = new System.Drawing.Size(132, 22);
            this.debitBox1.TabIndex = 5;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(1480, 230);
            this.nicknameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(68, 16);
            this.nicknameLabel.TabIndex = 6;
            this.nicknameLabel.Text = "Nickname";
            // 
            // debitLabel
            // 
            this.debitLabel.AutoSize = true;
            this.debitLabel.Location = new System.Drawing.Point(1671, 230);
            this.debitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.debitLabel.Name = "debitLabel";
            this.debitLabel.Size = new System.Drawing.Size(39, 16);
            this.debitLabel.TabIndex = 7;
            this.debitLabel.Text = "Debit";
            // 
            // newUserLabel
            // 
            this.newUserLabel.AutoSize = true;
            this.newUserLabel.Location = new System.Drawing.Point(1480, 174);
            this.newUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newUserLabel.Name = "newUserLabel";
            this.newUserLabel.Size = new System.Drawing.Size(99, 16);
            this.newUserLabel.TabIndex = 8;
            this.newUserLabel.Text = "Add a new user";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1492, 331);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // NukeAll
            // 
            this.NukeAll.Location = new System.Drawing.Point(1125, 491);
            this.NukeAll.Location = new System.Drawing.Point(1484, 742);
            this.NukeAll.Margin = new System.Windows.Forms.Padding(1);
            this.NukeAll.Name = "NukeAll";
            this.NukeAll.Size = new System.Drawing.Size(152, 30);
            this.NukeAll.TabIndex = 11;
            this.NukeAll.Text = "Delete all Records";
            this.NukeAll.UseVisualStyleBackColor = true;
            this.NukeAll.Click += new System.EventHandler(this.NukeAll_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(84, 31);
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(112, 38);
            this.listBox1.Margin = new System.Windows.Forms.Padding(1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(811, 260);
            this.listBox1.TabIndex = 12;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(727, 31);
            // UsersGridView
            // 
            this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView.Location = new System.Drawing.Point(969, 432);
            this.UsersGridView.Margin = new System.Windows.Forms.Padding(4);
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.RowHeadersWidth = 123;
            this.UsersGridView.Size = new System.Drawing.Size(388, 321);
            this.UsersGridView.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(969, 38);
            this.listBox2.Margin = new System.Windows.Forms.Padding(1);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(327, 260);
            this.listBox2.TabIndex = 13;
            // 
            // purchase
            // 
            this.purchase.Location = new System.Drawing.Point(969, 315);
            this.purchase.Margin = new System.Windows.Forms.Padding(4);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(108, 37);
            this.purchase.TabIndex = 14;
            this.purchase.Text = "Purchase";
            this.purchase.UseVisualStyleBackColor = true;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // addFunds
            // 
            this.addFunds.Location = new System.Drawing.Point(1085, 315);
            this.addFunds.Margin = new System.Windows.Forms.Padding(4);
            this.addFunds.Name = "addFunds";
            this.addFunds.Size = new System.Drawing.Size(107, 37);
            this.addFunds.TabIndex = 15;
            this.addFunds.Text = "Add Funds";
            this.addFunds.UseVisualStyleBackColor = true;
            this.addFunds.Click += new System.EventHandler(this.addFunds_Click);
            // 
            // addFundsTextBox
            // 
            this.addFundsTextBox.Location = new System.Drawing.Point(1200, 322);
            this.addFundsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addFundsTextBox.Name = "addFundsTextBox";
            this.addFundsTextBox.Size = new System.Drawing.Size(96, 22);
            this.addFundsTextBox.TabIndex = 16;
            // 
            // listBoxOutOfStock
            // 
            this.listBoxOutOfStock.FormattingEnabled = true;
            this.listBoxOutOfStock.Location = new System.Drawing.Point(84, 330);
            this.listBoxOutOfStock.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxOutOfStock.Name = "listBoxOutOfStock";
            this.listBoxOutOfStock.Size = new System.Drawing.Size(609, 212);
            this.listBoxOutOfStock.TabIndex = 17;
            // viewSnackButton
            // 
            this.viewSnackButton.Location = new System.Drawing.Point(344, 315);
            this.viewSnackButton.Name = "viewSnackButton";
            this.viewSnackButton.Size = new System.Drawing.Size(107, 37);
            this.viewSnackButton.TabIndex = 17;
            this.viewSnackButton.Text = "View Snacks";
            this.viewSnackButton.UseVisualStyleBackColor = true;
            this.viewSnackButton.Click += new System.EventHandler(this.viewSnackButton_Click);
            // 
            // viewDrinkButton
            // 
            this.viewDrinkButton.Location = new System.Drawing.Point(457, 315);
            this.viewDrinkButton.Name = "viewDrinkButton";
            this.viewDrinkButton.Size = new System.Drawing.Size(99, 37);
            this.viewDrinkButton.TabIndex = 18;
            this.viewDrinkButton.Text = "View Drinks";
            this.viewDrinkButton.UseVisualStyleBackColor = true;
            // 
            // viewItemButton
            // 
            this.viewItemButton.Location = new System.Drawing.Point(562, 315);
            this.viewItemButton.Name = "viewItemButton";
            this.viewItemButton.Size = new System.Drawing.Size(106, 37);
            this.viewItemButton.TabIndex = 19;
            this.viewItemButton.Text = "View Items";
            this.viewItemButton.UseVisualStyleBackColor = true;
            // 
            // viewTransactions
            // 
            this.viewTransactions.Location = new System.Drawing.Point(719, 315);
            this.viewTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.viewTransactions.Name = "viewTransactions";
            this.viewTransactions.Size = new System.Drawing.Size(201, 37);
            this.viewTransactions.TabIndex = 20;
            this.viewTransactions.Text = "View Transactions";
            this.viewTransactions.UseVisualStyleBackColor = true;
            this.viewTransactions.Click += new System.EventHandler(this.viewTransactions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(1480, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Add a Snack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(1480, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Location = new System.Drawing.Point(1604, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(1686, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Description";
            // 
            // snackName
            // 
            this.snackName.CausesValidation = false;
            this.snackName.Location = new System.Drawing.Point(1483, 451);
            this.snackName.Name = "snackName";
            this.snackName.Size = new System.Drawing.Size(100, 22);
            this.snackName.TabIndex = 27;
            // 
            // snackCost
            // 
            this.snackCost.CausesValidation = false;
            this.snackCost.Location = new System.Drawing.Point(1589, 451);
            this.snackCost.Name = "snackCost";
            this.snackCost.Size = new System.Drawing.Size(67, 22);
            this.snackCost.TabIndex = 28;
            // 
            // snackDescription
            // 
            this.snackDescription.CausesValidation = false;
            this.snackDescription.Location = new System.Drawing.Point(1662, 451);
            this.snackDescription.Name = "snackDescription";
            this.snackDescription.Size = new System.Drawing.Size(131, 22);
            this.snackDescription.TabIndex = 29;
            // 
            // drinkDescription
            // 
            this.drinkDescription.Location = new System.Drawing.Point(1662, 574);
            this.drinkDescription.Name = "drinkDescription";
            this.drinkDescription.Size = new System.Drawing.Size(131, 22);
            this.drinkDescription.TabIndex = 38;
            this.drinkDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // drinkCost
            // 
            this.drinkCost.CausesValidation = false;
            this.drinkCost.Location = new System.Drawing.Point(1589, 574);
            this.drinkCost.Name = "drinkCost";
            this.drinkCost.Size = new System.Drawing.Size(67, 22);
            this.drinkCost.TabIndex = 37;
            this.drinkCost.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // drinkName
            // 
            this.drinkName.CausesValidation = false;
            this.drinkName.Location = new System.Drawing.Point(1483, 574);
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(100, 22);
            this.drinkName.TabIndex = 36;
            this.drinkName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Location = new System.Drawing.Point(1796, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Caffinated? (T/F)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Location = new System.Drawing.Point(1686, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Description";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Location = new System.Drawing.Point(1604, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Price";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Location = new System.Drawing.Point(1480, 555);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Name";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.CausesValidation = false;
            this.label10.Location = new System.Drawing.Point(1480, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Add a Drink";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // snackAdd
            // 
            this.snackAdd.Location = new System.Drawing.Point(1483, 480);
            this.snackAdd.Margin = new System.Windows.Forms.Padding(4);
            this.snackAdd.Name = "snackAdd";
            this.snackAdd.Size = new System.Drawing.Size(100, 28);
            this.snackAdd.TabIndex = 40;
            this.snackAdd.Text = "Add";
            this.snackAdd.UseVisualStyleBackColor = true;
            this.snackAdd.Click += new System.EventHandler(this.snackAdd_Click);
            // 
            // DrinkAdd
            // 
            this.DrinkAdd.Location = new System.Drawing.Point(1484, 603);
            this.DrinkAdd.Margin = new System.Windows.Forms.Padding(4);
            this.DrinkAdd.Name = "DrinkAdd";
            this.DrinkAdd.Size = new System.Drawing.Size(100, 28);
            this.DrinkAdd.TabIndex = 41;
            this.DrinkAdd.Text = "Add";
            this.DrinkAdd.UseVisualStyleBackColor = true;
            this.DrinkAdd.Click += new System.EventHandler(this.DrinkAdd_Click);
            // 
            // isCaffinated
            // 
            this.isCaffinated.CausesValidation = false;
            this.isCaffinated.Location = new System.Drawing.Point(1799, 574);
            this.isCaffinated.Name = "isCaffinated";
            this.isCaffinated.Size = new System.Drawing.Size(100, 22);
            this.isCaffinated.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 750);
            this.Controls.Add(this.listBoxOutOfStock);
            this.ClientSize = new System.Drawing.Size(1924, 923);
            this.Controls.Add(this.isCaffinated);
            this.Controls.Add(this.DrinkAdd);
            this.Controls.Add(this.snackAdd);
            this.Controls.Add(this.drinkDescription);
            this.Controls.Add(this.drinkCost);
            this.Controls.Add(this.drinkName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.snackDescription);
            this.Controls.Add(this.snackCost);
            this.Controls.Add(this.snackName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewTransactions);
            this.Controls.Add(this.viewItemButton);
            this.Controls.Add(this.viewDrinkButton);
            this.Controls.Add(this.viewSnackButton);
            this.Controls.Add(this.addFundsTextBox);
            this.Controls.Add(this.addFunds);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.NukeAll);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newUserLabel);
            this.Controls.Add(this.debitLabel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.debitBox1);
            this.Controls.Add(this.nicnameTextBox);
            this.Controls.Add(this.OutOfStockButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OutOfStockButton;
        private System.Windows.Forms.TextBox nicnameTextBox;
        private System.Windows.Forms.TextBox debitBox1;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label debitLabel;
        private System.Windows.Forms.Label newUserLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button NukeAll;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button purchase;
        private System.Windows.Forms.Button addFunds;
        private System.Windows.Forms.TextBox addFundsTextBox;
        private System.Windows.Forms.ListBox listBoxOutOfStock;
        private System.Windows.Forms.Button viewSnackButton;
        private System.Windows.Forms.Button viewDrinkButton;
        private System.Windows.Forms.Button viewItemButton;
        private System.Windows.Forms.Button viewTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox snackName;
        private System.Windows.Forms.TextBox snackCost;
        private System.Windows.Forms.TextBox snackDescription;
        private System.Windows.Forms.TextBox drinkDescription;
        private System.Windows.Forms.TextBox drinkCost;
        private System.Windows.Forms.TextBox drinkName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button snackAdd;
        private System.Windows.Forms.Button DrinkAdd;
        private System.Windows.Forms.TextBox isCaffinated;
    }
}

