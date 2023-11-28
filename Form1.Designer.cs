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
            this.UsersGridView = new System.Windows.Forms.DataGridView();
            this.DisplayUserButton = new System.Windows.Forms.Button();
            this.nicnameTextBox = new System.Windows.Forms.TextBox();
            this.debitBox1 = new System.Windows.Forms.TextBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.debitLabel = new System.Windows.Forms.Label();
            this.newUserLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OutOfStockGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OutOfStockButton
            // 
            this.OutOfStockButton.Location = new System.Drawing.Point(53, 298);
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
            this.OutOfStockGridView.Location = new System.Drawing.Point(53, 31);
            this.OutOfStockGridView.Name = "OutOfStockGridView";
            this.OutOfStockGridView.Size = new System.Drawing.Size(606, 261);
            this.OutOfStockGridView.TabIndex = 1;
            this.OutOfStockGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UsersGridView
            // 
            this.UsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView.Location = new System.Drawing.Point(727, 31);
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.Size = new System.Drawing.Size(291, 261);
            this.UsersGridView.TabIndex = 2;
            // 
            // DisplayUserButton
            // 
            this.DisplayUserButton.Location = new System.Drawing.Point(727, 298);
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
            this.addButton.Location = new System.Drawing.Point(1191, 269);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 610);
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
        private System.Windows.Forms.DataGridView UsersGridView;
        private System.Windows.Forms.Button DisplayUserButton;
        private System.Windows.Forms.TextBox nicnameTextBox;
        private System.Windows.Forms.TextBox debitBox1;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label debitLabel;
        private System.Windows.Forms.Label newUserLabel;
        private System.Windows.Forms.Button addButton;
    }
}

