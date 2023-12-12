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
            this.AvailableSnacks = new System.Windows.Forms.Button();
            this.AvailableDrinks = new System.Windows.Forms.Button();
            this.AvailableItems = new System.Windows.Forms.Button();
            this.ModifyInventory = new System.Windows.Forms.Button();
            this.ModifyDesc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TableDropDown = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InventoryInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DescriptionInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listBoxOutOfStock = new System.Windows.Forms.ListBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.deleteUserLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.userDeleteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OutOfStockButton
            // 
            this.OutOfStockButton.Location = new System.Drawing.Point(84, 560);
            this.OutOfStockButton.Name = "OutOfStockButton";
            this.OutOfStockButton.Size = new System.Drawing.Size(151, 30);
            this.OutOfStockButton.TabIndex = 0;
            this.OutOfStockButton.Text = "Check Out of stock items";
            this.OutOfStockButton.UseVisualStyleBackColor = true;
            this.OutOfStockButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nicnameTextBox
            // 
            this.nicnameTextBox.Location = new System.Drawing.Point(995, 134);
            this.nicnameTextBox.Name = "nicnameTextBox";
            this.nicnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nicnameTextBox.TabIndex = 4;
            // 
            // debitBox1
            // 
            this.debitBox1.Location = new System.Drawing.Point(1138, 134);
            this.debitBox1.Name = "debitBox1";
            this.debitBox1.Size = new System.Drawing.Size(100, 20);
            this.debitBox1.TabIndex = 5;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(992, 100);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(55, 13);
            this.nicknameLabel.TabIndex = 6;
            this.nicknameLabel.Text = "Nickname";
            // 
            // debitLabel
            // 
            this.debitLabel.AutoSize = true;
            this.debitLabel.Location = new System.Drawing.Point(1135, 100);
            this.debitLabel.Name = "debitLabel";
            this.debitLabel.Size = new System.Drawing.Size(32, 13);
            this.debitLabel.TabIndex = 7;
            this.debitLabel.Text = "Debit";
            // 
            // newUserLabel
            // 
            this.newUserLabel.AutoSize = true;
            this.newUserLabel.Location = new System.Drawing.Point(992, 54);
            this.newUserLabel.Name = "newUserLabel";
            this.newUserLabel.Size = new System.Drawing.Size(81, 13);
            this.newUserLabel.TabIndex = 8;
            this.newUserLabel.Text = "Add a new user";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1079, 164);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // NukeAll
            // 
            this.NukeAll.Location = new System.Drawing.Point(770, 763);
            this.NukeAll.Margin = new System.Windows.Forms.Padding(1);
            this.NukeAll.Name = "NukeAll";
            this.NukeAll.Size = new System.Drawing.Size(114, 24);
            this.NukeAll.TabIndex = 11;
            this.NukeAll.Text = "Delete all Records";
            this.NukeAll.UseVisualStyleBackColor = true;
            this.NukeAll.Click += new System.EventHandler(this.NukeAll_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(84, 31);
            this.listBox1.Margin = new System.Windows.Forms.Padding(1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(609, 212);
            this.listBox1.TabIndex = 12;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(727, 31);
            this.listBox2.Margin = new System.Windows.Forms.Padding(1);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(246, 212);
            this.listBox2.TabIndex = 13;
            // 
            // purchase
            // 
            this.purchase.Location = new System.Drawing.Point(727, 256);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(81, 30);
            this.purchase.TabIndex = 14;
            this.purchase.Text = "Purchase";
            this.purchase.UseVisualStyleBackColor = true;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // addFunds
            // 
            this.addFunds.Location = new System.Drawing.Point(814, 256);
            this.addFunds.Name = "addFunds";
            this.addFunds.Size = new System.Drawing.Size(80, 30);
            this.addFunds.TabIndex = 15;
            this.addFunds.Text = "Add Funds";
            this.addFunds.UseVisualStyleBackColor = true;
            this.addFunds.Click += new System.EventHandler(this.addFunds_Click);
            // 
            // addFundsTextBox
            // 
            this.addFundsTextBox.Location = new System.Drawing.Point(900, 262);
            this.addFundsTextBox.Name = "addFundsTextBox";
            this.addFundsTextBox.Size = new System.Drawing.Size(73, 20);
            this.addFundsTextBox.TabIndex = 16;
            // 
            // viewSnackButton
            // 
            this.viewSnackButton.Location = new System.Drawing.Point(338, 374);
            this.viewSnackButton.Name = "viewSnackButton";
            this.viewSnackButton.Size = new System.Drawing.Size(107, 37);
            this.viewSnackButton.TabIndex = 17;
            this.viewSnackButton.Text = "View Snacks";
            this.viewSnackButton.UseVisualStyleBackColor = true;
            this.viewSnackButton.Click += new System.EventHandler(this.viewSnackButton_Click);
            // 
            // viewDrinkButton
            // 
            this.viewDrinkButton.Location = new System.Drawing.Point(457, 374);
            this.viewDrinkButton.Name = "viewDrinkButton";
            this.viewDrinkButton.Size = new System.Drawing.Size(99, 37);
            this.viewDrinkButton.TabIndex = 18;
            this.viewDrinkButton.Text = "View Drinks";
            this.viewDrinkButton.UseVisualStyleBackColor = true;
            // 
            // viewItemButton
            // 
            this.viewItemButton.Location = new System.Drawing.Point(576, 374);
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
            this.label1.Location = new System.Drawing.Point(718, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Add a Snack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(718, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Location = new System.Drawing.Point(842, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(924, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Description";
            // 
            // snackName
            // 
            this.snackName.CausesValidation = false;
            this.snackName.Location = new System.Drawing.Point(721, 422);
            this.snackName.Name = "snackName";
            this.snackName.Size = new System.Drawing.Size(100, 20);
            this.snackName.TabIndex = 27;
            // 
            // snackCost
            // 
            this.snackCost.CausesValidation = false;
            this.snackCost.Location = new System.Drawing.Point(827, 422);
            this.snackCost.Name = "snackCost";
            this.snackCost.Size = new System.Drawing.Size(67, 20);
            this.snackCost.TabIndex = 28;
            // 
            // snackDescription
            // 
            this.snackDescription.CausesValidation = false;
            this.snackDescription.Location = new System.Drawing.Point(900, 422);
            this.snackDescription.Name = "snackDescription";
            this.snackDescription.Size = new System.Drawing.Size(131, 20);
            this.snackDescription.TabIndex = 29;
            // 
            // drinkDescription
            // 
            this.drinkDescription.Location = new System.Drawing.Point(900, 545);
            this.drinkDescription.Name = "drinkDescription";
            this.drinkDescription.Size = new System.Drawing.Size(131, 20);
            this.drinkDescription.TabIndex = 38;
            // 
            // drinkCost
            // 
            this.drinkCost.CausesValidation = false;
            this.drinkCost.Location = new System.Drawing.Point(827, 545);
            this.drinkCost.Name = "drinkCost";
            this.drinkCost.Size = new System.Drawing.Size(67, 20);
            this.drinkCost.TabIndex = 37;
            // 
            // drinkName
            // 
            this.drinkName.CausesValidation = false;
            this.drinkName.Location = new System.Drawing.Point(721, 545);
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(100, 20);
            this.drinkName.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Location = new System.Drawing.Point(1034, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Caffinated? (T/F)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Location = new System.Drawing.Point(924, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Location = new System.Drawing.Point(842, 526);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Location = new System.Drawing.Point(718, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.CausesValidation = false;
            this.label10.Location = new System.Drawing.Point(718, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Add a Drink";
            // 
            // snackAdd
            // 
            this.snackAdd.Location = new System.Drawing.Point(721, 451);
            this.snackAdd.Margin = new System.Windows.Forms.Padding(4);
            this.snackAdd.Name = "snackAdd";
            this.snackAdd.Size = new System.Drawing.Size(100, 28);
            this.snackAdd.TabIndex = 40;
            this.snackAdd.Text = "Add";
            this.snackAdd.UseVisualStyleBackColor = true;
            // 
            // DrinkAdd
            // 
            this.DrinkAdd.Location = new System.Drawing.Point(722, 574);
            this.DrinkAdd.Margin = new System.Windows.Forms.Padding(4);
            this.DrinkAdd.Name = "DrinkAdd";
            this.DrinkAdd.Size = new System.Drawing.Size(100, 28);
            this.DrinkAdd.TabIndex = 41;
            this.DrinkAdd.Text = "Add";
            this.DrinkAdd.UseVisualStyleBackColor = true;
            // 
            // isCaffinated
            // 
            this.isCaffinated.Location = new System.Drawing.Point(12, 7);
            this.isCaffinated.Name = "isCaffinated";
            this.isCaffinated.Size = new System.Drawing.Size(100, 20);
            this.isCaffinated.TabIndex = 60;
            // 
            // AvailableSnacks
            // 
            this.AvailableSnacks.Location = new System.Drawing.Point(338, 302);
            this.AvailableSnacks.Name = "AvailableSnacks";
            this.AvailableSnacks.Size = new System.Drawing.Size(107, 66);
            this.AvailableSnacks.TabIndex = 43;
            this.AvailableSnacks.Text = "View Available Snacks";
            this.AvailableSnacks.UseVisualStyleBackColor = true;
            // 
            // AvailableDrinks
            // 
            this.AvailableDrinks.Location = new System.Drawing.Point(457, 302);
            this.AvailableDrinks.Name = "AvailableDrinks";
            this.AvailableDrinks.Size = new System.Drawing.Size(99, 66);
            this.AvailableDrinks.TabIndex = 44;
            this.AvailableDrinks.Text = "View Available Drinks";
            this.AvailableDrinks.UseVisualStyleBackColor = true;
            // 
            // AvailableItems
            // 
            this.AvailableItems.Location = new System.Drawing.Point(576, 302);
            this.AvailableItems.Name = "AvailableItems";
            this.AvailableItems.Size = new System.Drawing.Size(106, 66);
            this.AvailableItems.TabIndex = 45;
            this.AvailableItems.Text = "View Available Items";
            this.AvailableItems.UseVisualStyleBackColor = true;
            // 
            // ModifyInventory
            // 
            this.ModifyInventory.Location = new System.Drawing.Point(321, 674);
            this.ModifyInventory.Name = "ModifyInventory";
            this.ModifyInventory.Size = new System.Drawing.Size(141, 46);
            this.ModifyInventory.TabIndex = 47;
            this.ModifyInventory.Text = "Modify Inventory";
            this.ModifyInventory.UseVisualStyleBackColor = true;
            this.ModifyInventory.Click += new System.EventHandler(this.ModifyInventory_Click);
            // 
            // ModifyDesc
            // 
            this.ModifyDesc.Location = new System.Drawing.Point(545, 674);
            this.ModifyDesc.Name = "ModifyDesc";
            this.ModifyDesc.Size = new System.Drawing.Size(133, 46);
            this.ModifyDesc.TabIndex = 48;
            this.ModifyDesc.Text = "Modify Description";
            this.ModifyDesc.UseVisualStyleBackColor = true;
            this.ModifyDesc.Click += new System.EventHandler(this.ModifyDesc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 674);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 46);
            this.button1.TabIndex = 49;
            this.button1.Text = "Modify Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TableDropDown
            // 
            this.TableDropDown.FormattingEnabled = true;
            this.TableDropDown.Items.AddRange(new object[] {
            "Snack",
            "Drink",
            "Item"});
            this.TableDropDown.Location = new System.Drawing.Point(83, 686);
            this.TableDropDown.Name = "TableDropDown";
            this.TableDropDown.Size = new System.Drawing.Size(178, 21);
            this.TableDropDown.TabIndex = 50;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(112, 646);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 612);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Enter Name of Item";
            // 
            // InventoryInput
            // 
            this.InventoryInput.Location = new System.Drawing.Point(350, 646);
            this.InventoryInput.Name = "InventoryInput";
            this.InventoryInput.Size = new System.Drawing.Size(100, 20);
            this.InventoryInput.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 612);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Number to add to existing Inventory";
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(530, 646);
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(161, 20);
            this.DescriptionInput.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(560, 612);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "New Description";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(790, 646);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 20);
            this.NameInput.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(802, 612);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "New Name";
            // 
            // listBoxOutOfStock
            // 
            this.listBoxOutOfStock.FormattingEnabled = true;
            this.listBoxOutOfStock.Location = new System.Drawing.Point(84, 330);
            this.listBoxOutOfStock.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxOutOfStock.Name = "listBoxOutOfStock";
            this.listBoxOutOfStock.Size = new System.Drawing.Size(609, 212);
            this.listBoxOutOfStock.TabIndex = 17;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(1396, 152);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(88, 46);
            this.deleteUserButton.TabIndex = 61;
            this.deleteUserButton.Text = "Delete selected user";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // deleteUserLabel
            // 
            this.deleteUserLabel.AutoSize = true;
            this.deleteUserLabel.Location = new System.Drawing.Point(1308, 54);
            this.deleteUserLabel.Name = "deleteUserLabel";
            this.deleteUserLabel.Size = new System.Drawing.Size(72, 13);
            this.deleteUserLabel.TabIndex = 62;
            this.deleteUserLabel.Text = "Delete a User";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(1356, 82);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(168, 13);
            this.idLabel.TabIndex = 63;
            this.idLabel.Text = "Type ID of user you wish to delete";
            // 
            // userDeleteTextBox
            // 
            this.userDeleteTextBox.Location = new System.Drawing.Point(1396, 115);
            this.userDeleteTextBox.Name = "userDeleteTextBox";
            this.userDeleteTextBox.Size = new System.Drawing.Size(100, 20);
            this.userDeleteTextBox.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 889);
            this.Controls.Add(this.userDeleteTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.deleteUserLabel);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DescriptionInput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.InventoryInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TableDropDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ModifyDesc);
            this.Controls.Add(this.ModifyInventory);
            this.Controls.Add(this.AvailableItems);
            this.Controls.Add(this.AvailableDrinks);
            this.Controls.Add(this.AvailableSnacks);
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
            this.Controls.Add(this.listBoxOutOfStock);
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
        private System.Windows.Forms.Button AvailableSnacks;
        private System.Windows.Forms.Button AvailableDrinks;
        private System.Windows.Forms.Button AvailableItems;
        private System.Windows.Forms.Button ModifyInventory;
        private System.Windows.Forms.Button ModifyDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TableDropDown;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InventoryInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DescriptionInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBoxOutOfStock;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Label deleteUserLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox userDeleteTextBox;
    }
}

