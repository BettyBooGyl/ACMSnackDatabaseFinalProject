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
            this.OutOfStockGridView = new System.Windows.Forms.DataGridView();
            this.DisplayUserButton = new System.Windows.Forms.Button();
            this.nicnameTextBox = new System.Windows.Forms.TextBox();
            this.debitBox1 = new System.Windows.Forms.TextBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.debitLabel = new System.Windows.Forms.Label();
            this.newUserLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.NukeAll = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.UsersGridView = new System.Windows.Forms.DataGridView();
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
            this.InventoryReport = new System.Windows.Forms.Button();
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
            this.InventoryTableChoice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutOfStockGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OutOfStockButton
            // 
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
            this.OutOfStockGridView.Location = new System.Drawing.Point(112, 465);
            this.OutOfStockGridView.Margin = new System.Windows.Forms.Padding(4);
            this.OutOfStockGridView.Name = "OutOfStockGridView";
            this.OutOfStockGridView.RowHeadersWidth = 123;
            this.OutOfStockGridView.Size = new System.Drawing.Size(808, 288);
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
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(112, 38);
            this.listBox1.Margin = new System.Windows.Forms.Padding(1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(811, 260);
            this.listBox1.TabIndex = 12;
            // 
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
            this.label6.Size = new System.Drawing.Size(106, 16);
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
            // AvailableSnacks
            // 
            this.AvailableSnacks.Location = new System.Drawing.Point(338, 302);
            this.AvailableSnacks.Name = "AvailableSnacks";
            this.AvailableSnacks.Size = new System.Drawing.Size(107, 66);
            this.AvailableSnacks.TabIndex = 43;
            this.AvailableSnacks.Text = "View Available Snacks";
            this.AvailableSnacks.UseVisualStyleBackColor = true;
            this.AvailableSnacks.Click += new System.EventHandler(this.AvailableSnacks_Click);
            // 
            // AvailableDrinks
            // 
            this.AvailableDrinks.Location = new System.Drawing.Point(457, 302);
            this.AvailableDrinks.Name = "AvailableDrinks";
            this.AvailableDrinks.Size = new System.Drawing.Size(99, 66);
            this.AvailableDrinks.TabIndex = 44;
            this.AvailableDrinks.Text = "View Available Drinks";
            this.AvailableDrinks.UseVisualStyleBackColor = true;
            this.AvailableDrinks.Click += new System.EventHandler(this.AvailableDrinks_Click);
            // 
            // AvailableItems
            // 
            this.AvailableItems.Location = new System.Drawing.Point(576, 302);
            this.AvailableItems.Name = "AvailableItems";
            this.AvailableItems.Size = new System.Drawing.Size(106, 66);
            this.AvailableItems.TabIndex = 45;
            this.AvailableItems.Text = "View Available Items";
            this.AvailableItems.UseVisualStyleBackColor = true;
            this.AvailableItems.Click += new System.EventHandler(this.AvailableItems_Click);
            // 
            // InventoryReport
            // 
            this.InventoryReport.Location = new System.Drawing.Point(112, 411);
            this.InventoryReport.Margin = new System.Windows.Forms.Padding(4);
            this.InventoryReport.Name = "InventoryReport";
            this.InventoryReport.Size = new System.Drawing.Size(201, 37);
            this.InventoryReport.TabIndex = 46;
            this.InventoryReport.Text = "Inventory Report";
            this.InventoryReport.UseVisualStyleBackColor = true;
            this.InventoryReport.Click += new System.EventHandler(this.InventoryReport_Click);
            // 
            // ModifyInventory
            // 
            this.ModifyInventory.Location = new System.Drawing.Point(338, 849);
            this.ModifyInventory.Name = "ModifyInventory";
            this.ModifyInventory.Size = new System.Drawing.Size(141, 46);
            this.ModifyInventory.TabIndex = 47;
            this.ModifyInventory.Text = "Modify Inventory";
            this.ModifyInventory.UseVisualStyleBackColor = true;
            this.ModifyInventory.Click += new System.EventHandler(this.ModifyInventory_Click);
            // 
            // ModifyDesc
            // 
            this.ModifyDesc.Location = new System.Drawing.Point(562, 849);
            this.ModifyDesc.Name = "ModifyDesc";
            this.ModifyDesc.Size = new System.Drawing.Size(133, 46);
            this.ModifyDesc.TabIndex = 48;
            this.ModifyDesc.Text = "Modify Description";
            this.ModifyDesc.UseVisualStyleBackColor = true;
            this.ModifyDesc.Click += new System.EventHandler(this.ModifyDesc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 849);
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
            this.TableDropDown.Location = new System.Drawing.Point(100, 861);
            this.TableDropDown.Name = "TableDropDown";
            this.TableDropDown.Size = new System.Drawing.Size(178, 24);
            this.TableDropDown.TabIndex = 50;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(129, 821);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 787);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Enter Name of Item";
            // 
            // InventoryInput
            // 
            this.InventoryInput.Location = new System.Drawing.Point(367, 821);
            this.InventoryInput.Name = "InventoryInput";
            this.InventoryInput.Size = new System.Drawing.Size(100, 22);
            this.InventoryInput.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 787);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Number to add to existing Inventory";
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(547, 821);
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(161, 22);
            this.DescriptionInput.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(577, 787);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "New Description";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(807, 821);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 22);
            this.NameInput.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(819, 787);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 16);
            this.label13.TabIndex = 58;
            this.label13.Text = "New Name";
            // 
            // InventoryTableChoice
            // 
            this.InventoryTableChoice.FormattingEnabled = true;
            this.InventoryTableChoice.Items.AddRange(new object[] {
            "snack",
            "drink",
            "item"});
            this.InventoryTableChoice.Location = new System.Drawing.Point(112, 374);
            this.InventoryTableChoice.Name = "InventoryTableChoice";
            this.InventoryTableChoice.Size = new System.Drawing.Size(201, 24);
            this.InventoryTableChoice.TabIndex = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 923);
            this.Controls.Add(this.InventoryTableChoice);
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
            this.Controls.Add(this.InventoryReport);
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
            this.Controls.Add(this.DisplayUserButton);
            this.Controls.Add(this.UsersGridView);
            this.Controls.Add(this.OutOfStockGridView);
            this.Controls.Add(this.OutOfStockButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OutOfStockGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OutOfStockButton;
        private System.Windows.Forms.DataGridView OutOfStockGridView;
        private System.Windows.Forms.Button DisplayUserButton;
        private System.Windows.Forms.TextBox nicnameTextBox;
        private System.Windows.Forms.TextBox debitBox1;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label debitLabel;
        private System.Windows.Forms.Label newUserLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button NukeAll;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView UsersGridView;
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
        private System.Windows.Forms.Button InventoryReport;
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
        private System.Windows.Forms.ComboBox InventoryTableChoice;
    }
}

