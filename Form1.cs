using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlTypes;
using System.Security.Policy;

namespace ACMSnackDatabase
{
    public partial class Form1 : Form
    { string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Betty\\Documents\\ACMSnackDatabaseServer.mdf;Integrated Security = True; Connect Timeout = 30";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT item.itemname, item.price, item.description, drink.is_caffinated, snack.allergens FROM item LEFT JOIN snack on snack.itemid = item.itemid LEFT JOIN drink on drink.itemid = item.itemid WHERE inventory = 0;";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                OutOfStockGridView.ReadOnly = true;
                OutOfStockGridView.DataSource = ds.Tables[0];
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DisplayUserButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT nickname, debit FROM customer";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                UsersGridView.ReadOnly = true;
                UsersGridView.DataSource = ds.Tables[0];
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string nickname = nicnameTextBox.Text.Trim();
                Decimal debit = Convert.ToDecimal(debitBox1.Text);
                SqlMoney debitMoney = debit;
                string query = "INSERT INTO[dbo].[customer] ([nickname], [debit]) VALUES(N'" + nickname + "', CAST(" + debitMoney + " AS Money))";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            }

        }
    }
}
