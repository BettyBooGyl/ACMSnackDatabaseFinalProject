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
            ((System.ComponentModel.ISupportInitialize)(this.OutOfStockGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OutOfStockButton
            // 
            this.OutOfStockButton.Location = new System.Drawing.Point(84, 256);
            this.OutOfStockButton.Name = "OutOfStockButton";
            this.OutOfStockButton.Size = new System.Drawing.Size(151, 30);
            this.OutOfStockButton.TabIndex = 0;
            this.OutOfStockButton.Text = "Check Out of stock items";
            this.OutOfStockButton.UseVisualStyleBackColor = true;
            this.OutOfStockButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutOfStockGridView
            // 
            this.OutOfStockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutOfStockGridView.Location = new System.Drawing.Point(84, 304);
            this.OutOfStockGridView.Name = "OutOfStockGridView";
            this.OutOfStockGridView.RowHeadersWidth = 123;
            this.OutOfStockGridView.Size = new System.Drawing.Size(606, 261);
            this.OutOfStockGridView.TabIndex = 1;
            this.OutOfStockGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DisplayUserButton
            // 
            this.DisplayUserButton.Location = new System.Drawing.Point(727, 304);
            this.DisplayUserButton.Name = "DisplayUserButton";
            this.DisplayUserButton.Size = new System.Drawing.Size(151, 30);
            this.DisplayUserButton.TabIndex = 3;
            this.DisplayUserButton.Text = "Display Users";
            this.DisplayUserButton.UseVisualStyleBackColor = true;
            this.DisplayUserButton.Click += new System.EventHandler(this.DisplayUserButton_Click);
            // 
            // nicnameTextBox
            // 
            this.nicnameTextBox.Location = new System.Drawing.Point(1113, 221);
            this.nicnameTextBox.Name = "nicnameTextBox";
            this.nicnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nicnameTextBox.TabIndex = 4;
            // 
            // debitBox1
            // 
            this.debitBox1.Location = new System.Drawing.Point(1256, 221);
            this.debitBox1.Name = "debitBox1";
            this.debitBox1.Size = new System.Drawing.Size(100, 20);
            this.debitBox1.TabIndex = 5;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(1110, 187);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(55, 13);
            this.nicknameLabel.TabIndex = 6;
            this.nicknameLabel.Text = "Nickname";
            // 
            // debitLabel
            // 
            this.debitLabel.AutoSize = true;
            this.debitLabel.Location = new System.Drawing.Point(1253, 187);
            this.debitLabel.Name = "debitLabel";
            this.debitLabel.Size = new System.Drawing.Size(32, 13);
            this.debitLabel.TabIndex = 7;
            this.debitLabel.Text = "Debit";
            // 
            // newUserLabel
            // 
            this.newUserLabel.AutoSize = true;
            this.newUserLabel.Location = new System.Drawing.Point(1110, 141);
            this.newUserLabel.Name = "newUserLabel";
            this.newUserLabel.Size = new System.Drawing.Size(81, 13);
            this.newUserLabel.TabIndex = 8;
            this.newUserLabel.Text = "Add a new user";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1119, 269);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // NukeAll
            // 
            this.NukeAll.Location = new System.Drawing.Point(1125, 491);
            this.NukeAll.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.listBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(609, 212);
            this.listBox1.TabIndex = 12;
            // 
            // UsersGridView
            // 
            this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView.Location = new System.Drawing.Point(727, 351);
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.RowHeadersWidth = 123;
            this.UsersGridView.Size = new System.Drawing.Size(291, 261);
            this.UsersGridView.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(727, 31);
            this.listBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 750);
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
    }
}

