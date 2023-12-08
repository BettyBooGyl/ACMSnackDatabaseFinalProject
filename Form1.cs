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
using Npgsql;

namespace ACMSnackDatabase
{
    public partial class Form1 : Form
    { 
        static string connection = "Host=localhost;Port=5432;Database=DBFinal;Username=postgres;Password=jhKat17daJ#-;Persist Security Info=True";
        
        
        public Form1()
        
        {
            InitializeComponent();



            try
            {
                // Get db connection
                NpgsqlConnection conn = new NpgsqlConnection(connection);

                // Open connection to db
                conn.Open();

                // Make command for db
                string query = "SELECT * FROM item";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Prepare();

                // Get data out of command and get book object
                NpgsqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    StringBuilder item = new StringBuilder();
                    item.Append(Convert.ToString(reader["itemid"]) + " ");
                    item.Append(Convert.ToString(reader["itemname"]) + " ");
                    item.Append(Convert.ToString(reader["price"]) + " ");
                    item.Append(Convert.ToString(reader["description"]) + " ");
                    item.Append(Convert.ToString(reader["inventory"]));

                    listBox1.Items.Add(item);
                }

                // Close connection to db
                conn.Close();


                conn.Open();

                query = "SELECT * FROM customer";
                cmd = new NpgsqlCommand(query, conn);
                cmd.Prepare();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    StringBuilder customer = new StringBuilder();
                    customer.Append(Convert.ToString(reader["userid"]) + " ");
                    customer.Append(Convert.ToString(reader["nickname"]) + " ");
                    customer.Append(Convert.ToString(reader["debit"]));

                    listBox2.Items.Add(customer);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            /*
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT item.itemname, item.price, item.description, drink.is_caffinated, snack.allergens FROM item LEFT JOIN snack on snack.itemid = item.itemid LEFT JOIN drink on drink.itemid = item.itemid WHERE inventory = 0;";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                OutOfStockGridView.ReadOnly = true;
                OutOfStockGridView.DataSource = ds.Tables[0];
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "CREATE TABLE IF NOT EXISTS snacks (itemID serial PRIMARY KEY, snack_name VARCHAR(20) not NULL, price decimal not NULL, description VARCHAR(50), inventory int default 0);";

                //string query = "SELECT item.itemname, item.price, item.description, drink.is_caffinated, snack.allergens FROM item LEFT JOIN snack on snack.itemid = item.itemid LEFT JOIN drink on drink.itemid = item.itemid WHERE inventory = 0;";
                SqlCommand cmd = new SqlCommand(query, conn);

                /*SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                OutOfStockGridView.ReadOnly = true;
                OutOfStockGridView.DataSource = ds.Tables[0]; */
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

        

        private void NukeAll_Click(object sender, EventArgs e)
        {
            try
            {
                NukeHelper("transaction");
                NukeHelper("drink");
                NukeHelper("snack");
                NukeHelper("item");

                listBox1.Items.Clear();
            }
            catch (Exception ex)
            {

            }
        }

        private void NukeHelper(string tablename)
        {
            // Get db connection
            NpgsqlConnection conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            // Make command for db
            string query = "DELETE FROM " + tablename + " *";

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
