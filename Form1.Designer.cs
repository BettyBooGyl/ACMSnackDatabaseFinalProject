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
            this.Nuke = new System.Windows.Forms.Button();
            this.NukeAll = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutOfStockGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OutOfStockButton
            // 
            this.OutOfStockButton.Location = new System.Drawing.Point(265, 729);
            this.OutOfStockButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.OutOfStockButton.Name = "OutOfStockButton";
            this.OutOfStockButton.Size = new System.Drawing.Size(478, 85);
            this.OutOfStockButton.TabIndex = 0;
            this.OutOfStockButton.Text = "Check Out of stock items";
            this.OutOfStockButton.UseVisualStyleBackColor = true;
            this.OutOfStockButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutOfStockGridView
            // 
            this.OutOfStockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutOfStockGridView.Location = new System.Drawing.Point(265, 866);
            this.OutOfStockGridView.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.OutOfStockGridView.Name = "OutOfStockGridView";
            this.OutOfStockGridView.RowHeadersWidth = 123;
            this.OutOfStockGridView.Size = new System.Drawing.Size(1919, 743);
            this.OutOfStockGridView.TabIndex = 1;
            this.OutOfStockGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DisplayUserButton
            // 
            this.DisplayUserButton.Location = new System.Drawing.Point(2302, 848);
            this.DisplayUserButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.DisplayUserButton.Name = "DisplayUserButton";
            this.DisplayUserButton.Size = new System.Drawing.Size(478, 85);
            this.DisplayUserButton.TabIndex = 3;
            this.DisplayUserButton.Text = "Display Users";
            this.DisplayUserButton.UseVisualStyleBackColor = true;
            this.DisplayUserButton.Click += new System.EventHandler(this.DisplayUserButton_Click);
            // 
            // nicnameTextBox
            // 
            this.nicnameTextBox.Location = new System.Drawing.Point(3524, 629);
            this.nicnameTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.nicnameTextBox.Name = "nicnameTextBox";
            this.nicnameTextBox.Size = new System.Drawing.Size(308, 44);
            this.nicnameTextBox.TabIndex = 4;
            // 
            // debitBox1
            // 
            this.debitBox1.Location = new System.Drawing.Point(3977, 629);
            this.debitBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.debitBox1.Name = "debitBox1";
            this.debitBox1.Size = new System.Drawing.Size(308, 44);
            this.debitBox1.TabIndex = 5;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(3515, 532);
            this.nicknameLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(160, 37);
            this.nicknameLabel.TabIndex = 6;
            this.nicknameLabel.Text = "Nickname";
            // 
            // debitLabel
            // 
            this.debitLabel.AutoSize = true;
            this.debitLabel.Location = new System.Drawing.Point(3968, 532);
            this.debitLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.debitLabel.Name = "debitLabel";
            this.debitLabel.Size = new System.Drawing.Size(91, 37);
            this.debitLabel.TabIndex = 7;
            this.debitLabel.Text = "Debit";
            // 
            // newUserLabel
            // 
            this.newUserLabel.AutoSize = true;
            this.newUserLabel.Location = new System.Drawing.Point(3515, 401);
            this.newUserLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.newUserLabel.Name = "newUserLabel";
            this.newUserLabel.Size = new System.Drawing.Size(240, 37);
            this.newUserLabel.TabIndex = 8;
            this.newUserLabel.Text = "Add a new user";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3543, 766);
            this.addButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(238, 65);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Nuke
            // 
            this.Nuke.Location = new System.Drawing.Point(4246, 1557);
            this.Nuke.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Nuke.Name = "Nuke";
            this.Nuke.Size = new System.Drawing.Size(339, 68);
            this.Nuke.TabIndex = 10;
            this.Nuke.Text = "Delete All Records";
            this.Nuke.UseVisualStyleBackColor = true;
            // 
            // NukeAll
            // 
            this.NukeAll.Location = new System.Drawing.Point(3563, 1398);
            this.NukeAll.Name = "NukeAll";
            this.NukeAll.Size = new System.Drawing.Size(228, 54);
            this.NukeAll.TabIndex = 11;
            this.NukeAll.Text = "Delete all Records";
            this.NukeAll.UseVisualStyleBackColor = true;
            this.NukeAll.Click += new System.EventHandler(this.NukeAll_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(265, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1919, 596);
            this.listBox1.TabIndex = 12;
            // 
            // UsersGridView
            // 
            this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView.Location = new System.Drawing.Point(2302, 998);
            this.UsersGridView.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.RowHeadersWidth = 123;
            this.UsersGridView.Size = new System.Drawing.Size(922, 743);
            this.UsersGridView.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 37;
            this.listBox2.Location = new System.Drawing.Point(2302, 88);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(769, 596);
            this.listBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3844, 1736);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.NukeAll);
            this.Controls.Add(this.Nuke);
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
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
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
        private System.Windows.Forms.Button Nuke;
        private System.Windows.Forms.Button NukeAll;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.ListBox listBox2;
    }
}

