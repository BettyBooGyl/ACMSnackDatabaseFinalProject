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
    public struct Drink : Items
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
        public override string ToString()
        {
            if (is_caffinated) return $"{itemname}, {price}, {description}," + " is cafinated";
            else return $"{itemname}, {price}, {description}," + " is not cafinated";
        }
    }

    public struct Snack : Items
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

    public struct Transaction
    {
        public int transID;
        public int itemID;
        public int customerID;
        public String timestamp;
        public Transaction(int transID, int itemID, int customerID, String timestamp)
        {
            this.transID = transID;
            this.itemID = itemID;
            this.customerID = customerID;
            this.timestamp = timestamp;

        }

        public override string ToString() => $"{transID}, {itemID}, {customerID}, {timestamp}";
    }

    public partial class Form1 : Form
    {
        // ----- !!! PLEASE PUT YOUR PASSWORD IN THE PASSWORD SECTION IN THE CONNECTION STRING OTHERWI ( HERE ) SE IT WILL NOT WORK; 111 ----- \\
        static string connection = "Host=localhost;Port=5432;Database=366Project;Username=postgres;Password=Dijon0416;Persist Security Info=True";

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
                int count = items.Count; ;
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
                    listItemBox.Items.Add(items[highestIndex].ToString());
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
        private void updateCustomers()
        {
            // Get db connection
            NpgsqlConnection conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            string query = "SELECT * FROM customer";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
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
            // Clears the list box so that customers are not doubled
            listBox2.Items.Clear();
            int count = customers.Count;
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

                conn.Close();
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
                if (reader["allergens"].Equals(""))
                {
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
        private void viewSnackButton_Click(object sender, EventArgs e) { }

        private void viewTransactions_Click(object sender, EventArgs e) { }

        private void addButton_Click(object sender, EventArgs e)
        {



            // Get db connection to update inventory
            NpgsqlConnection conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            // Make command for db
            string query = "INSERT INTO customer (nickname, debit) VALUES (@nickname, @debitMoney)";

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            if (nicnameTextBox.Text.Trim().Length == 3)
            {
                cmd.Parameters.AddWithValue("@nickname", nicnameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("@debitMoney", Convert.ToDecimal(debitBox1.Text));
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
                string message = "A new user has been added!";
                string caption = "User added";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                updateCustomers();
            }
            else
            {
                string message = "A nickname must be 3 characters long!";
                string caption = "Invalid Nickname";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
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

                listItemBox.Items.Clear();
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
            cmd.Parameters.AddWithValue("@selectedIndex", listItemBox.SelectedIndex + 1); // idk how to get the selectedItem.itemid out of the listbox, possibly because it dosnt exist because I am doing this wrong with a listbox when I should be using a datagridview but as long as we dont delete records, this should work.
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
            cmd.Parameters.AddWithValue("@selectedIndex", listItemBox.SelectedIndex + 1); // idk how to get the selectedItem.userid out of the listbox, possibly because it dosnt exist because I am doing this wrong with a listbox when I should be using a datagridview but as long as we dont delete records, this should work.
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
                    cmd.Parameters.AddWithValue("@selectedIndex", itemList[listItemBox.SelectedIndex].itemid);
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
                    cmd.Parameters.AddWithValue("@iID", itemList[listItemBox.SelectedIndex].itemid);
                    cmd.Parameters.AddWithValue("@cID", customerList[listBox2.SelectedIndex].userid);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    try
                    {
                        // --- DELETE LISTBOXES AND "GLOBAL LISTS" : FILL LISTBOXES AND "GLOBAL LISTS" ---



                        // Delete everything from the listboxes. Then fill them back in. Why? because this way i dont have to write more code.
                        listItemBox.Items.Clear();
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
                            listItemBox.Items.Add(items[highestIndex].ToString());

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

                    // Calls update customers method that repopulates the listbox with new information
                    updateCustomers();

                    // -- THANK YOU POP UP --

                    string message = "Thank you for adding funds!";
                    string caption = "Transaction Succeeded";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                }
            }
            catch (Exception ex)
            {
                string message = "Specify a value in 0.00 format or try selecting a user";
                string caption = ex.ToString();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void listAvailableButton_Click(object sender, EventArgs e)
        {
            //clear out of item box
            listItemBox.Items.Clear();

            // Get db connection
            NpgsqlConnection conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            

            string query = "SELECT item.itemID, item.itemname, item.price, item.description, item.inventory, drink.is_caffinated, snack.allergens FROM item LEFT JOIN snack on snack.itemid = item.itemid LEFT JOIN drink on drink.itemid = item.itemid ORDER BY itemid;";
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
            conn.Close();
            for (int i = 0; i < items.Count; i++)
            {
                listItemBox.Items.Add(items[i].ToString());
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            // Get db connection to update inventory
            NpgsqlConnection conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            // Make command for db
            string query = "INSERT INTO item (itemname, price, description, inventory) VALUES (@itemname, @price, @description, @inventory)";

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            if (itemNameBox.Text.Trim().Length > 0 && itemCostBox.Text.Trim().Length > 0)
            {
                cmd.Parameters.AddWithValue("@itemname", itemNameBox.Text.Trim());
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(itemCostBox.Text));
                cmd.Parameters.AddWithValue("@description", itemDescBox.Text.Trim());
                cmd.Parameters.AddWithValue("@inventory", Convert.ToInt16(itemInvBox.Text.Trim()));
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
                string message = "A new item has been added!";
                string caption = "Item added";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                string message = "An item must have a name and price!";
                string caption = "Invalid Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void addSnack_Click(object sender, EventArgs e)
        {
            // Get db connection to update inventory
            NpgsqlConnection conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            // Make command for db
            string query = "INSERT INTO snack (itemID, allergens) VALUES (@itemID, @allergens)";

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            if (snackIDBox.Text.Trim().Length > 0)
            {
                cmd.Parameters.AddWithValue("@itemID", Convert.ToInt32(snackIDBox.Text.Trim()));
                cmd.Parameters.AddWithValue("@allergens", allergenBox.Text.Trim());

                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
                string message = "A new snack has been added!";
                string caption = "Snack added";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                string message = "A snack must have an existing ID!";
                string caption = "Invalid Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void addDrink_Click(object sender, EventArgs e)
        {
            // Get db connection to update inventory
            NpgsqlConnection conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            // Make command for db
            string query = "INSERT INTO drink (itemID, is_caffinated) VALUES (@itemID, @is_caffinated)";

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            if (drinkIDBox.Text.Trim().Length > 0 && caffineBox.Text.Trim().Length > 0)
            {
                cmd.Parameters.AddWithValue("@itemID", Convert.ToInt32(drinkIDBox.Text.Trim()));
                if (caffineBox.Text.Trim() == "t")
                {
                    cmd.Parameters.AddWithValue("@is_caffinated", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@is_caffinated", false);
                }

                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
                string message = "A new drink has been added!";
                string caption = "Drink added";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                string message = "A drink must have an existing ID!";
                string caption = "Invalid Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Get db connection to update inventory
            NpgsqlConnection conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            // Make command for db
            string query = "DELETE FROM snack WHERE itemID = @itemID; DELETE FROM drink WHERE itemID = @itemID; DELETE FROM item WHERE itemID = @itemID;";

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            if (removeIDBox.Text.Trim().Length > 0)
            {
                cmd.Parameters.AddWithValue("@itemID", Convert.ToInt32(removeIDBox.Text.Trim()));

                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
                string message = "A item has been removed!";
                string caption = "Item Removed";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                string message = "A item must have an existing ID!";
                string caption = "Invalid Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void viewTransactionsButton_Click(object sender, EventArgs e)
        {
            //clear out of item box
            listItemBox.Items.Clear();

            // Get db connection
            NpgsqlConnection conn = new NpgsqlConnection(connection);

            // Open connection to db
            conn.Open();

            string query = "SELECT * FROM transactions;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Prepare();

            // Get data out of command and get object
            NpgsqlDataReader reader = cmd.ExecuteReader();

            // initialization
            List<Transaction> transactions = new List<Transaction>();
            try
            {
                while (reader.Read())
                {
                    Transaction transaction = new Transaction((Convert.ToInt32(reader["transID"])),
                        (Convert.ToInt32(reader["itemID"])),
                        (Convert.ToInt32(reader["customerID"])),
                        (Convert.ToString(reader["timest"])));

                    transactions.Add(transaction);
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }

            int count = transactions.Count;
            for (int i = 0; i < count; i++)
            {
                int highest = int.MaxValue;
                int highestIndex = int.MaxValue;
                for (int j = 0; j < transactions.Count; j++)
                {
                    if (transactions[j].transID < highest)
                    {
                        highest = transactions[j].transID;
                        highestIndex = j;
                    }
                }
                listItemBox.Items.Add(transactions[highestIndex].ToString());
                //transactionList.Add(transactions[highestIndex]); // fill the "global" list
                transactions.RemoveAt(highestIndex);

                conn.Close();
            }

        
            
        }
        private void ModifyInventory_Click(object sender, EventArgs e)
        {
            try
            {
                // Get db connection to update inventory
                NpgsqlConnection conn = new NpgsqlConnection(connection);

                // Open connection to db
                conn.Open();

                // Make command for db
                string name = NameTextBox.Text;
                string table = TableDropDown.SelectedItem.ToString(); 
                int setInventory = int.Parse(InventoryInput.Text);
                string query = "";
                if (table == "Item")
                {
                    query = "UPDATE " + table + " SET inventory = inventory + " + setInventory + " WHERE itemName = '" + name + "'";
                    
                }
                if (table == "Snack")
                {
                    query = "UPDATE " + table + " SET inventory = inventory + " + setInventory + " WHERE snack_name = '" + name + "'";
                }
                if (table == "Drink")
                {
                    query = "UPDATE " + table + " SET inventory = inventory + " + setInventory + " WHERE drink_name = '" + name + "'";
                }
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();

                
            }catch(Exception ex)
            {

            }
            
        }

        private void ModifyDesc_Click(object sender, EventArgs e)
        {
            try
            {
                // Get db connection to update inventory
                NpgsqlConnection conn = new NpgsqlConnection(connection);

                // Open connection to db
                conn.Open();

                string name = NameTextBox.Text;
                string table = TableDropDown.SelectedText;
                string description = DescriptionInput.Text;
                string query = "";
                if (table == "item")
                {
                    query = "UPDATE " + table + " SET description = " + description + " WHERE itemName = '" + name + "'";
                }
                if (table == "snack")
                {
                    query = "UPDATE " + table + " SET description = " + description + " WHERE snack_name = '" + name + "'";
                }
                if (table == "drink")
                {
                    query = "UPDATE " + table + " SET description = " + description + " WHERE drink_name = '" + name + "'";
                }
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
            }catch(Exception ex) { }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get db connection to update inventory
                NpgsqlConnection conn = new NpgsqlConnection(connection);

                // Open connection to db
                conn.Open();

                string name = NameTextBox.Text;
                string table = TableDropDown.SelectedText;
                string newName = NameInput.Text;
                string query = "";
                if (table == "item")
                {
                    query = "UPDATE " + table + " SET itemName = " + newName + " WHERE itemName = '" + name + "'";
                }
                if (table == "snack")
                {
                    query = "UPDATE " + table + " SET snack_name = " + newName + " WHERE snack_name = '" + name + "'";
                }
                if (table == "drink")
                {
                    query = "UPDATE " + table + " SET drink_name = " + newName + " WHERE drink_name = '" + name + "'";
                }
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Prepare();

                cmd.ExecuteNonQuery();
                conn.Close();
            }catch(Exception ex){

            }
        }
    }
    
}
