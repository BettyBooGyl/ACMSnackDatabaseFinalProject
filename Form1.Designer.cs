﻿namespace ACMSnackDatabase
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
            this.listItemBox = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.purchase = new System.Windows.Forms.Button();
            this.addFunds = new System.Windows.Forms.Button();
            this.addFundsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ModifyInventory = new System.Windows.Forms.Button();
            this.ModifyDesc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InventoryInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DescriptionInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.listBoxOutOfStock = new System.Windows.Forms.ListBox();
            this.listAvailableButton = new System.Windows.Forms.Button();
            this.itemNameBox = new System.Windows.Forms.TextBox();
            this.itemCostBox = new System.Windows.Forms.TextBox();
            this.itemDescBox = new System.Windows.Forms.TextBox();
            this.Inventory = new System.Windows.Forms.Label();
            this.itemInvBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.snackIDBox = new System.Windows.Forms.TextBox();
            this.allergenBox = new System.Windows.Forms.TextBox();
            this.drinkIDBox = new System.Windows.Forms.TextBox();
            this.caffineBox = new System.Windows.Forms.TextBox();
            this.addSnack = new System.Windows.Forms.Button();
            this.addDrink = new System.Windows.Forms.Button();
            this.removeIDBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.viewTransactionsButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.deleteUserLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.userDeleteTextBox = new System.Windows.Forms.TextBox();
            this.ModifyNameLabel = new System.Windows.Forms.Label();
            this.ModifyInventoryLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.LabelNameMod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutOfStockButton
            // 
            this.OutOfStockButton.Location = new System.Drawing.Point(87, 285);
            this.OutOfStockButton.Name = "OutOfStockButton";
            this.OutOfStockButton.Size = new System.Drawing.Size(151, 30);
            this.OutOfStockButton.TabIndex = 0;
            this.OutOfStockButton.Text = "Check Out of stock items";
            this.OutOfStockButton.UseVisualStyleBackColor = true;
            this.OutOfStockButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nicnameTextBox
            // 
            this.nicnameTextBox.Location = new System.Drawing.Point(1174, 82);
            this.nicnameTextBox.Name = "nicnameTextBox";
            this.nicnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nicnameTextBox.TabIndex = 4;
            // 
            // debitBox1
            // 
            this.debitBox1.Location = new System.Drawing.Point(1289, 82);
            this.debitBox1.Name = "debitBox1";
            this.debitBox1.Size = new System.Drawing.Size(100, 20);
            this.debitBox1.TabIndex = 5;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(1194, 59);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(63, 15);
            this.nicknameLabel.TabIndex = 6;
            this.nicknameLabel.Text = "Nickname";
            // 
            // debitLabel
            // 
            this.debitLabel.AutoSize = true;
            this.debitLabel.Location = new System.Drawing.Point(1309, 59);
            this.debitLabel.Name = "debitLabel";
            this.debitLabel.Size = new System.Drawing.Size(36, 15);
            this.debitLabel.TabIndex = 7;
            this.debitLabel.Text = "Debit";
            // 
            // newUserLabel
            // 
            this.newUserLabel.AutoSize = true;
            this.newUserLabel.Location = new System.Drawing.Point(1237, 31);
            this.newUserLabel.Name = "newUserLabel";
            this.newUserLabel.Size = new System.Drawing.Size(91, 15);
            this.newUserLabel.TabIndex = 8;
            this.newUserLabel.Text = "Add a new user";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1240, 119);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // NukeAll
            // 
            this.NukeAll.Location = new System.Drawing.Point(814, 448);
            this.NukeAll.Margin = new System.Windows.Forms.Padding(1);
            this.NukeAll.Name = "NukeAll";
            this.NukeAll.Size = new System.Drawing.Size(114, 24);
            this.NukeAll.TabIndex = 11;
            this.NukeAll.Text = "Delete all Records";
            this.NukeAll.UseVisualStyleBackColor = true;
            this.NukeAll.Click += new System.EventHandler(this.NukeAll_Click);
            // 
            // listItemBox
            // 
            this.listItemBox.FormattingEnabled = true;
            this.listItemBox.Location = new System.Drawing.Point(84, 31);
            this.listItemBox.Margin = new System.Windows.Forms.Padding(1);
            this.listItemBox.Name = "listItemBox";
            this.listItemBox.Size = new System.Drawing.Size(609, 212);
            this.listItemBox.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(1116, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add an Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(1117, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Location = new System.Drawing.Point(1196, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(1276, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Location = new System.Drawing.Point(1123, 436);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Item ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Location = new System.Drawing.Point(1198, 436);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Allergen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Location = new System.Drawing.Point(1125, 502);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Add Item to Drink Table";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Location = new System.Drawing.Point(1079, 525);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "ItemID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.CausesValidation = false;
            this.label10.Location = new System.Drawing.Point(1160, 522);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "Has Caffine? (t/f)";
            // 
            // ModifyInventory
            // 
            this.ModifyInventory.Location = new System.Drawing.Point(258, 628);
            this.ModifyInventory.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyInventory.Name = "ModifyInventory";
            this.ModifyInventory.Size = new System.Drawing.Size(106, 37);
            this.ModifyInventory.TabIndex = 47;
            this.ModifyInventory.Text = "Modify Inventory";
            this.ModifyInventory.UseVisualStyleBackColor = true;
            this.ModifyInventory.Click += new System.EventHandler(this.ModifyInventory_Click);
            // 
            // ModifyDesc
            // 
            this.ModifyDesc.Location = new System.Drawing.Point(414, 628);
            this.ModifyDesc.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyDesc.Name = "ModifyDesc";
            this.ModifyDesc.Size = new System.Drawing.Size(124, 37);
            this.ModifyDesc.TabIndex = 48;
            this.ModifyDesc.Text = "Modify Description";
            this.ModifyDesc.UseVisualStyleBackColor = true;
            this.ModifyDesc.Click += new System.EventHandler(this.ModifyDesc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 628);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 49;
            this.button1.Text = "Modify Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(87, 596);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(76, 20);
            this.NameTextBox.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1118, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Add Item to Snack Table";
            // 
            // InventoryInput
            // 
            this.InventoryInput.Location = new System.Drawing.Point(275, 596);
            this.InventoryInput.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryInput.Name = "InventoryInput";
            this.InventoryInput.Size = new System.Drawing.Size(76, 20);
            this.InventoryInput.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1117, 309);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "Remove an Item";
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(416, 596);
            this.DescriptionInput.Margin = new System.Windows.Forms.Padding(2);
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(122, 20);
            this.DescriptionInput.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1123, 330);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 42;
            this.label12.Text = "Item ID";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(578, 596);
            this.NameInput.Margin = new System.Windows.Forms.Padding(2);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(76, 20);
            this.NameInput.TabIndex = 57;
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
            // listAvailableButton
            // 
            this.listAvailableButton.Location = new System.Drawing.Point(87, 250);
            this.listAvailableButton.Margin = new System.Windows.Forms.Padding(2);
            this.listAvailableButton.Name = "listAvailableButton";
            this.listAvailableButton.Size = new System.Drawing.Size(148, 30);
            this.listAvailableButton.TabIndex = 18;
            this.listAvailableButton.Text = "List Available Items";
            this.listAvailableButton.UseVisualStyleBackColor = true;
            this.listAvailableButton.Click += new System.EventHandler(this.listAvailableButton_Click);
            // 
            // itemNameBox
            // 
            this.itemNameBox.Location = new System.Drawing.Point(1119, 256);
            this.itemNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(76, 20);
            this.itemNameBox.TabIndex = 23;
            // 
            // itemCostBox
            // 
            this.itemCostBox.Location = new System.Drawing.Point(1198, 256);
            this.itemCostBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemCostBox.Name = "itemCostBox";
            this.itemCostBox.Size = new System.Drawing.Size(76, 20);
            this.itemCostBox.TabIndex = 24;
            // 
            // itemDescBox
            // 
            this.itemDescBox.Location = new System.Drawing.Point(1278, 256);
            this.itemDescBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemDescBox.Name = "itemDescBox";
            this.itemDescBox.Size = new System.Drawing.Size(76, 20);
            this.itemDescBox.TabIndex = 25;
            // 
            // Inventory
            // 
            this.Inventory.AutoSize = true;
            this.Inventory.Location = new System.Drawing.Point(1355, 239);
            this.Inventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(55, 15);
            this.Inventory.TabIndex = 26;
            this.Inventory.Text = "Inventory";
            // 
            // itemInvBox
            // 
            this.itemInvBox.Location = new System.Drawing.Point(1358, 256);
            this.itemInvBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemInvBox.Name = "itemInvBox";
            this.itemInvBox.Size = new System.Drawing.Size(76, 20);
            this.itemInvBox.TabIndex = 27;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(1125, 279);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(56, 19);
            this.addItemButton.TabIndex = 28;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // snackIDBox
            // 
            this.snackIDBox.Location = new System.Drawing.Point(1118, 452);
            this.snackIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.snackIDBox.Name = "snackIDBox";
            this.snackIDBox.Size = new System.Drawing.Size(76, 20);
            this.snackIDBox.TabIndex = 32;
            // 
            // allergenBox
            // 
            this.allergenBox.Location = new System.Drawing.Point(1198, 452);
            this.allergenBox.Margin = new System.Windows.Forms.Padding(2);
            this.allergenBox.Name = "allergenBox";
            this.allergenBox.Size = new System.Drawing.Size(76, 20);
            this.allergenBox.TabIndex = 33;
            // 
            // drinkIDBox
            // 
            this.drinkIDBox.Location = new System.Drawing.Point(1082, 540);
            this.drinkIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.drinkIDBox.Name = "drinkIDBox";
            this.drinkIDBox.Size = new System.Drawing.Size(76, 20);
            this.drinkIDBox.TabIndex = 37;
            // 
            // caffineBox
            // 
            this.caffineBox.Location = new System.Drawing.Point(1162, 539);
            this.caffineBox.Margin = new System.Windows.Forms.Padding(2);
            this.caffineBox.Name = "caffineBox";
            this.caffineBox.Size = new System.Drawing.Size(76, 20);
            this.caffineBox.TabIndex = 38;
            // 
            // addSnack
            // 
            this.addSnack.Location = new System.Drawing.Point(1301, 452);
            this.addSnack.Margin = new System.Windows.Forms.Padding(2);
            this.addSnack.Name = "addSnack";
            this.addSnack.Size = new System.Drawing.Size(61, 37);
            this.addSnack.TabIndex = 39;
            this.addSnack.Text = "Add";
            this.addSnack.UseVisualStyleBackColor = true;
            this.addSnack.Click += new System.EventHandler(this.addSnack_Click);
            // 
            // addDrink
            // 
            this.addDrink.Location = new System.Drawing.Point(1349, 525);
            this.addDrink.Margin = new System.Windows.Forms.Padding(2);
            this.addDrink.Name = "addDrink";
            this.addDrink.Size = new System.Drawing.Size(61, 39);
            this.addDrink.TabIndex = 40;
            this.addDrink.Text = "Add";
            this.addDrink.UseVisualStyleBackColor = true;
            this.addDrink.Click += new System.EventHandler(this.addDrink_Click);
            // 
            // removeIDBox
            // 
            this.removeIDBox.Location = new System.Drawing.Point(1120, 346);
            this.removeIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.removeIDBox.Name = "removeIDBox";
            this.removeIDBox.Size = new System.Drawing.Size(76, 20);
            this.removeIDBox.TabIndex = 43;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(1208, 345);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(66, 21);
            this.removeButton.TabIndex = 44;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // viewTransactionsButton
            // 
            this.viewTransactionsButton.Location = new System.Drawing.Point(559, 269);
            this.viewTransactionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewTransactionsButton.Name = "viewTransactionsButton";
            this.viewTransactionsButton.Size = new System.Drawing.Size(134, 29);
            this.viewTransactionsButton.TabIndex = 45;
            this.viewTransactionsButton.Text = "View Transactions";
            this.viewTransactionsButton.UseVisualStyleBackColor = true;
            this.viewTransactionsButton.Click += new System.EventHandler(this.viewTransactionsButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(984, 119);
            this.deleteUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(70, 75);
            this.deleteUserButton.TabIndex = 61;
            this.deleteUserButton.Text = "Delete selected user";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // deleteUserLabel
            // 
            this.deleteUserLabel.AutoSize = true;
            this.deleteUserLabel.Location = new System.Drawing.Point(1014, 31);
            this.deleteUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deleteUserLabel.Name = "deleteUserLabel";
            this.deleteUserLabel.Size = new System.Drawing.Size(82, 15);
            this.deleteUserLabel.TabIndex = 62;
            this.deleteUserLabel.Text = "Delete a User";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(981, 59);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(188, 15);
            this.idLabel.TabIndex = 63;
            this.idLabel.Text = "Type ID of user you wish to delete";
            // 
            // userDeleteTextBox
            // 
            this.userDeleteTextBox.Location = new System.Drawing.Point(984, 82);
            this.userDeleteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userDeleteTextBox.Name = "userDeleteTextBox";
            this.userDeleteTextBox.Size = new System.Drawing.Size(76, 20);
            this.userDeleteTextBox.TabIndex = 64;
            // 
            // ModifyNameLabel
            // 
            this.ModifyNameLabel.AutoSize = true;
            this.ModifyNameLabel.Location = new System.Drawing.Point(84, 567);
            this.ModifyNameLabel.Name = "ModifyNameLabel";
            this.ModifyNameLabel.Size = new System.Drawing.Size(137, 15);
            this.ModifyNameLabel.TabIndex = 65;
            this.ModifyNameLabel.Text = "Name of Item To Modify";
            // 
            // ModifyInventoryLabel
            // 
            this.ModifyInventoryLabel.AutoSize = true;
            this.ModifyInventoryLabel.Location = new System.Drawing.Point(267, 572);
            this.ModifyInventoryLabel.Name = "ModifyInventoryLabel";
            this.ModifyInventoryLabel.Size = new System.Drawing.Size(92, 15);
            this.ModifyInventoryLabel.TabIndex = 66;
            this.ModifyInventoryLabel.Text = "Inventory to Add";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(428, 572);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(97, 15);
            this.DescriptionLabel.TabIndex = 67;
            this.DescriptionLabel.Text = "New Description";
            // 
            // LabelNameMod
            // 
            this.LabelNameMod.AutoSize = true;
            this.LabelNameMod.Location = new System.Drawing.Point(585, 572);
            this.LabelNameMod.Name = "LabelNameMod";
            this.LabelNameMod.Size = new System.Drawing.Size(69, 15);
            this.LabelNameMod.TabIndex = 68;
            this.LabelNameMod.Text = "New Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 1055);
            this.Controls.Add(this.LabelNameMod);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ModifyInventoryLabel);
            this.Controls.Add(this.ModifyNameLabel);
            this.Controls.Add(this.viewTransactionsButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.removeIDBox);
            this.Controls.Add(this.addDrink);
            this.Controls.Add(this.addSnack);
            this.Controls.Add(this.caffineBox);
            this.Controls.Add(this.drinkIDBox);
            this.Controls.Add(this.allergenBox);
            this.Controls.Add(this.snackIDBox);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemInvBox);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.itemDescBox);
            this.Controls.Add(this.itemCostBox);
            this.Controls.Add(this.itemNameBox);
            this.Controls.Add(this.userDeleteTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.deleteUserLabel);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DescriptionInput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.InventoryInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ModifyDesc);
            this.Controls.Add(this.ModifyInventory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAvailableButton);
            this.Controls.Add(this.listBoxOutOfStock);
            this.Controls.Add(this.addFundsTextBox);
            this.Controls.Add(this.addFunds);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listItemBox);
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
        private System.Windows.Forms.ListBox listItemBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button purchase;
        private System.Windows.Forms.Button addFunds;
        private System.Windows.Forms.TextBox addFundsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ModifyInventory;
        private System.Windows.Forms.Button ModifyDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InventoryInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DescriptionInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.ListBox listBoxOutOfStock;
        private System.Windows.Forms.Button listAvailableButton;
        
        private System.Windows.Forms.TextBox itemNameBox;
        private System.Windows.Forms.TextBox itemCostBox;
        private System.Windows.Forms.TextBox itemDescBox;
        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.TextBox itemInvBox;
        private System.Windows.Forms.Button addItemButton;
       
        private System.Windows.Forms.TextBox snackIDBox;
        private System.Windows.Forms.TextBox allergenBox;
       
        private System.Windows.Forms.TextBox drinkIDBox;
        private System.Windows.Forms.TextBox caffineBox;
        private System.Windows.Forms.Button addSnack;
        private System.Windows.Forms.Button addDrink;
        
        private System.Windows.Forms.TextBox removeIDBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button viewTransactionsButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Label deleteUserLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox userDeleteTextBox;
        private System.Windows.Forms.Label ModifyNameLabel;
        private System.Windows.Forms.Label ModifyInventoryLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label LabelNameMod;
    }
}

