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
using System.Diagnostics;
using System.Numerics;
using System.Collections;

namespace ACMSnackDatabase
{
    public struct Item
    {
        public Item(int itemid, string itemname, decimal price, string description, int inventory)
        {
            this.itemid = itemid;
            this.itemname = itemname;
            this.price = price;
            this.description = description;
            this.inventory = inventory;
        }

        public int itemid;
        public string itemname;
        public decimal price;
        public string description;
        public int inventory;

        public override string ToString() => $"{itemid}, {itemname}, {price}, {description}, {inventory}";
    }
    public interface Items
    {
    }
    public struct Drink:Items
    {
        public string itemname;
        public decimal price;
        public string description;
        public bool is_caffinated;
        public Drink(string itemname, decimal price, string description, bool is_caffinated)
        {
            this.itemname = itemname;
            this.price = price;
            this.description = description;
            this.is_caffinated = is_caffinated;

        }
        public override string ToString() { 
            if (is_caffinated) return $"{itemname}, {price}, {description}," + " is cafinated";
            else return $"{itemname}, {price}, {description}," + " is not cafinated";
        } 
    }

    public struct Snack:Items
    {
        public string itemname;
        public decimal price;
        public string description;
        public string allergens;
        public Snack(string itemname, decimal price, string description, string allergens)
        {
            this.itemname = itemname;
            this.price = price;
            this.description = description;
            this.allergens = allergens;

        }
        public override string ToString() => $"{itemname}, {price}, {description}, {allergens}";
    }
    public struct Customer
    {
        public Customer(int userid, string nickname, decimal debit)
        {
            this.userid = userid;
            this.nickname = nickname;
            this.debit = debit;
        }
        public int userid;
        public string nickname;
        public decimal debit;

        public override string ToString() => $"{userid}, {nickname}, {debit}";
    }

    public partial class Form1 : Form
    { 
        // ----- !!! PLEASE PUT YOUR PASSWORD IN THE PASSWORD SECTION IN THE CONNECTION STRING OTHERWI ( HERE ) SE IT WILL NOT WORK; 111 ----- \\
        static string connection = "Host=localhost;Database=ACMSnackDatabase;Username=postgres;Password=Elizabeth1;Persist Security Info=True";
        
        // these are so that I can access an ordered list of the items and customers wherever.
        public List<Item> itemList = new List<Item>();
        public List<Customer> customerList = new List<Customer>();


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

                // Get data out of command and get object
                NpgsqlDataReader reader = cmd.ExecuteReader();

                // initialization
                List<Item> items = new List<Item>(); // this will be a memory leak. there is nothing you can do about it. cope and seeth.

                // while reader has things to read: make a new item, throw it in the list;
                while (reader.Read())
                {
                    Item item = new Item((Convert.ToInt32(reader["itemid"])), 
                        (Convert.ToString(reader["itemname"])),
                        (Convert.ToDecimal(reader["price"])), 
                        (Convert.ToString(reader["description"])), 
                        (Convert.ToInt32(reader["inventory"]))); 

                    items.Add(item);
                }

                // Close connection to db
                conn.Close();

                // the code that follows is because i am doing some crazy stuff that would not need to happen if I did this correctly but im going to take on some tech debt here
                // finds the lowest id; puts it in the listbox first. this way it orders it.
                int highest;
                int highestIndex;
                int count = items.Count;;
                for(int i = 0; i < count; i++)
                {
                    highest = int.MaxValue;
                    highestIndex = int.MaxValue;
                    for (int j = 0; j < items.Count; j++)
                    {
                        if (items[j].itemid < highest)
                        {
                            highest = items[j].itemid;
                            highestIndex = j;
                        }
                    }
                    listBox1.Items.Add(items[highestIndex].ToString());
                    itemList.Add(items[highestIndex]); // fill the "global" list
                    items.RemoveAt(highestIndex);
                }

                // Begin doing the same for customers;
                conn.Open();

                query = "SELECT * FROM customer";
                cmd = new NpgsqlCommand(query, conn);
                cmd.Prepare();

                reader = cmd.ExecuteReader();

                List<Customer> customers = new List<Customer>();

                while (reader.Read())
                {
                    Customer customer = new Customer((Convert.ToInt32(reader["userid"])), 
                        (Convert.ToString(reader["nickname"])), 
                        (Convert.ToDecimal(reader["debit"])));

                    customers.Add(customer);
                }

                count = customers.Count;
                for (int i = 0; i < count; i++)
                {
                    highest = int.MaxValue;
                    highestIndex = int.MaxValue;
                    for (int j = 0; j < customers.Count; j++)
                    {
                        if (customers[j].userid < highest)
                        {
                            highest = customers[j].userid;
                            highestIndex = j;
                        }
                    }
                    listBox2.Items.Add(customers[highestIndex].ToString());
                    customerList.Add(customers[highestIndex]); // fill the "global" list
                    customers.RemoveAt(highestIndex);

                    conn.Close();
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
                // Get db connection
                NpgsqlConnection conn = new NpgsqlConnection(connection);

                // Open connection to db
                conn.Open();

                //string query = "CREATE TABLE IF NOT EXISTS snacks (itemID serial PRIMARY KEY, snack_name VARCHAR(20) not NULL, price decimal not NULL, description VARCHAR(50), inventory int default 0);";

                string query = "SELECT item.itemname, item.price, item.description, drink.is_caffinated, snack.allergens FROM item LEFT JOIN snack on snack.itemid = item.itemid LEFT JOIN drink on drink.itemid = item.itemid WHERE inventory = 0;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Prepare();

                /*SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                dAdapter.Fill(ds);
                OutOfStockGridView.ReadOnly = true;
                OutOfStockGridView.DataSource = ds.Tables[0]; */
                // Get data out of command and get object
                NpgsqlDataReader reader = cmd.ExecuteReader();

                // initialization
                List<Items> items = new List<Items>(); // this will be a memory leak. there is nothing you can do about it. cope and seeth.

                // while reader has things to read: make a new item, throw it in the list;
                while (reader.Read())
                {
                    if (reader["allergens"].Equals("")){
                        Drink drink = new Drink(
                        (Convert.ToString(reader["itemname"])),
                        (Convert.ToDecimal(reader["price"])),
                        (Convert.ToString(reader["description"])), (Convert.ToBoolean(reader["is_caffinated"])));
                    items.Add(drink);
                }
                else
                {
                    Snack snack = new Snack(
                        (Convert.ToString(reader["itemname"])),
                        (Convert.ToDecimal(reader["price"])),
                        (Convert.ToString(reader["description"])), (Convert.ToString(reader["allergens"])));
                    items.Add(snack);
                }
                    
                }
                 conn.Close();
            for (int i = 0; i < items.Count; i++)
            {
                listBoxOutOfStock.Items.Add(items[i].ToString());
            }


            }

        private void addButton_Click(object sender, EventArgs e)
        {

            using (NpgsqlConnection conn = new NpgsqlConnection(connection))
            {
                string nickname = nicnameTextBox.Text.Trim();
                Decimal debit = Convert.ToDecimal(debitBox1.Text);
                SqlMoney debitMoney = debit;
                string query = "INSERT INTO[dbo].[customer] ([nickname], [debit]) VALUES(N'" + nickname + "', CAST(" + debitMoney + " AS Money))";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                //SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            }

        }

        

        private void NukeAll_Click(object sender, EventArgs e)
        {
            try
            {
                NukeHelper("transaction");
                NukeHelper("customer");
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

        private void purchase_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            decimal debit = 0;
            int inventory = 0;


            // Get db connection
            NpgsqlConnection conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            // Make command for db
            string query = "SELECT price FROM item WHERE itemid = @selectedIndex";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@selectedIndex", listBox1.SelectedIndex + 1); // idk how to get the selectedItem.itemid out of the listbox, possibly because it dosnt exist because I am doing this wrong with a listbox when I should be using a datagridview but as long as we dont delete records, this should work.
            cmd.Prepare();

            // Get data out of command and get object
            NpgsqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                price = Convert.ToDecimal(reader["price"]);
            }

            // Close connection to db
            conn.Close();





            // Get db connection
            conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            // Make command for db
            query = "SELECT debit FROM customer WHERE userid = @selectedIndex";
            cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@selectedIndex", listBox2.SelectedIndex + 1); // idk how to get the selectedItem.userid out of the listbox, possibly because it dosnt exist because I am doing this wrong with a listbox when I should be using a datagridview but as long as we dont delete records, this should work.
            cmd.Prepare();

            // Get data out of command and get object
            reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                debit = Convert.ToDecimal(reader["debit"]);
            }

            // Close connection to db
            conn.Close();





            // Get db connection for inventory.
            conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            // Make command for db
            query = "SELECT inventory FROM item WHERE itemid = @selectedIndex";
            cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@selectedIndex", listBox1.SelectedIndex + 1); // idk how to get the selectedItem.userid out of the listbox, possibly because it dosnt exist because I am doing this wrong with a listbox when I should be using a datagridview but as long as we dont delete records, this should work.
            cmd.Prepare();

            // Get data out of command and get object
            reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                inventory = Convert.ToInt32(reader["inventory"]);
            }

            conn.Close();

            // IF IS VALID TRANSACTION
            if (price != 0 && debit != 0 && inventory != 0)
            {
                if (debit > price)
                {
                    // --- UPDATE CUSTOMER DEBIT ---
                    // Get db connection to update inventory
                    conn = new NpgsqlConnection(connection);

                    // Open connection to db
                    conn.Open();

                    // Make command for db
                    query = "UPDATE customer SET debit = @updatedD WHERE userid = @selectedIndex";

                    cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@updatedD", debit - price);
                    cmd.Parameters.AddWithValue("@selectedIndex", customerList[listBox2.SelectedIndex].userid);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // --- UPDATE ITEM INVENTORY ---
                    // Get db connection to update inventory
                    conn = new NpgsqlConnection(connection);

                    // Open connection to db
                    conn.Open();

                    // Make command for db
                    query = "UPDATE item SET inventory = @updatedI WHERE itemid = @selectedIndex";

                    cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@updatedI", inventory - 1);
                    cmd.Parameters.AddWithValue("@selectedIndex", itemList[listBox1.SelectedIndex].itemid);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    // --- UPDATE TRANSACTION TABLE ---
                    // Get db connection to update inventory
                    conn = new NpgsqlConnection(connection);

                    // Open connection to db
                    conn.Open();

                    // Make command for db
                    query = "INSERT INTO transactions(itemID, customerID, timest) VALUES (@iId, @cID, NOW())";

                    cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@iID", itemList[listBox1.SelectedIndex].itemid);
                    cmd.Parameters.AddWithValue("@cID", customerList[listBox2.SelectedIndex].userid);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    try
                    {
                        // --- DELETE LISTBOXES AND "GLOBAL LISTS" : FILL LISTBOXES AND "GLOBAL LISTS" ---



                        // Delete everything from the listboxes. Then fill them back in. Why? because this way i dont have to write more code.
                        listBox1.Items.Clear();
                        listBox2.Items.Clear();

                        // -- WORK ITEM --
                        // Get db connection
                        conn = new NpgsqlConnection(connection);

                        // Open connection to db
                        conn.Open();

                        // Make command for db
                        query = "SELECT * FROM item";
                        cmd = new NpgsqlCommand(query, conn);
                        cmd.Prepare();

                        // Get data out of command and get object
                        reader = cmd.ExecuteReader();


                        List<Item> items = new List<Item>(); // this will be a memory leak. there is nothing you can do about it. cope and seeth.

                        // while reader has things to read: make a new item, throw it in the list;
                        while (reader.Read())
                        {
                            Item item = new Item((Convert.ToInt32(reader["itemid"])),
                                (Convert.ToString(reader["itemname"])),
                                (Convert.ToDecimal(reader["price"])),
                                (Convert.ToString(reader["description"])),
                                (Convert.ToInt32(reader["inventory"])));

                            items.Add(item);
                        }

                        // Close connection to db
                        conn.Close();

                        // the code that follows is because i am doing some crazy stuff that would not need to happen if I did this correctly but im going to take on some tech debt here
                        // finds the lowest id; puts it in the listbox first. this way it orders it.
                        int highest;
                        int highestIndex;
                        int count = items.Count; 
                        
                        itemList.Clear(); //clear the global list, prep it for recreation

                        for (int i = 0; i < count; i++)
                        {
                            highest = int.MaxValue;
                            highestIndex = int.MaxValue;
                            for (int j = 0; j < items.Count; j++)
                            {
                                if (items[j].itemid < highest)
                                {
                                    highest = items[j].itemid;
                                    highestIndex = j;
                                }
                            }
                            listBox1.Items.Add(items[highestIndex].ToString());
                            
                            itemList.Add(items[highestIndex]); // fill the "global" list
                            items.RemoveAt(highestIndex);
                        }

                        // -- WORK CUSTOMER --

                        conn.Open();

                        query = "SELECT * FROM customer";
                        cmd = new NpgsqlCommand(query, conn);
                        cmd.Prepare();

                        reader = cmd.ExecuteReader();

                        List<Customer> customers = new List<Customer>();

                        while (reader.Read())
                        {
                            Customer customer = new Customer((Convert.ToInt32(reader["userid"])),
                                (Convert.ToString(reader["nickname"])),
                                (Convert.ToDecimal(reader["debit"])));

                            customers.Add(customer);
                        }

                        count = customers.Count;

                        customerList.Clear(); //clear the global list, prep it for recreation

                        for (int i = 0; i < count; i++)
                        {
                            highest = int.MaxValue;
                            highestIndex = int.MaxValue;
                            for (int j = 0; j < customers.Count; j++)
                            {
                                if (customers[j].userid < highest)
                                {
                                    highest = customers[j].userid;
                                    highestIndex = j;
                                }
                            }
                            listBox2.Items.Add(customers[highestIndex].ToString());
                            customerList.Add(customers[highestIndex]); // fill the "global" list
                            customers.RemoveAt(highestIndex);
                        }

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message, ex);
                    }

                    // -- THANK YOU POP UP --

                    string message = "Thank you for your purchase!";
                    string caption = "Transaction Succeeded";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);

                }
            }
        }

        private void addFunds_Click(object sender, EventArgs e)
        {
            // --- UPDATE CUSTOMER DEBIT ---
            try
            {
                if (Convert.ToDecimal(addFundsTextBox.Text) > 0)
                {
                    // Get db connection to update inventory
                    NpgsqlConnection conn = new NpgsqlConnection(connection);

                    // Open connection to db
                    conn.Open();

                    // Make command for db
                    string query = "UPDATE customer SET debit = @updatedD WHERE userid = @selectedIndex";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@updatedD", customerList[listBox2.SelectedIndex].debit + Convert.ToDecimal(addFundsTextBox.Text));
                    cmd.Parameters.AddWithValue("@selectedIndex", customerList[listBox2.SelectedIndex].userid);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                    conn.Close();


                    listBox2.Items.Clear();

                    conn.Open();

                    query = "SELECT * FROM customer";
                    cmd = new NpgsqlCommand(query, conn);
                    cmd.Prepare();

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    List<Customer> customers = new List<Customer>();

                    while (reader.Read())
                    {
                        Customer customer = new Customer((Convert.ToInt32(reader["userid"])),
                            (Convert.ToString(reader["nickname"])),
                            (Convert.ToDecimal(reader["debit"])));

                        customers.Add(customer);
                    }

                    int count = customers.Count;

                    customerList.Clear(); //clear the global list, prep it for recreation

                    for (int i = 0; i < count; i++)
                    {
                        int highest = int.MaxValue;
                        int highestIndex = int.MaxValue;
                        for (int j = 0; j < customers.Count; j++)
                        {
                            if (customers[j].userid < highest)
                            {
                                highest = customers[j].userid;
                                highestIndex = j;
                            }
                        }
                        listBox2.Items.Add(customers[highestIndex].ToString());
                        customerList.Add(customers[highestIndex]); // fill the "global" list
                        customers.RemoveAt(highestIndex);
                    }

                    conn.Close();

                    // -- THANK YOU POP UP --

                    string message = "Thank you for adding funds!";
                    string caption = "Transaction Succeeded";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                }
            }catch(Exception ex)
            {
                string message = "Specify a value in 0.00 format or try selecting a user";
                string caption = ex.ToString();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
