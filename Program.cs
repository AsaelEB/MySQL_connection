// Import libraries to be used
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySQL_connection
{
    class Program
    {
        static void Main(string[] args)
        {
            //insert();
            read();
        }

        // Insert new user to 'user' table from 'users' database 
        static void insert()
        {
            /* Create connection string to MySQL local database 'users'
            Used default port provided by XAMPP */
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=users;";
            // Read new User ID & name from input
            Console.WriteLine("Enter ID: ");
            String num = Console.ReadLine();
            Console.WriteLine("Enter the name: ");
            String nom = Console.ReadLine();

            // String to insert new user to user column
            string sql = "INSERT INTO user VALUES ('" + num + "','" + nom + "')";
            // Create connection and command
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand comm = new MySqlCommand(sql, conn);

            // Open connection 
            comm.Connection.Open();
            // Execute command to insert the new user
            comm.ExecuteNonQuery();
            // Close connection
            conn.Close();
        }

        // Visualize user information from 'user' local table, on 'users' database
        static void read() 
        {
            // Connection string to MySQL local database
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=users;";
            // Query to get everything from table 'user'
            string sql = "select * from user";
            // Create new connection and command Objects
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand comm = new MySqlCommand(sql, conn);
            // Create new data reader
            MySqlDataReader dr;
            try
            {
                // Open connection
                conn.Open();
                dr = comm.ExecuteReader();
                // Read every line from the Data Reader
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // Format printing data from the 'user' table
                        Console.WriteLine("Id: " + dr.GetString(0));
                        Console.WriteLine("Nom: " + dr.GetString(1));
                        Console.WriteLine("--------------------------");
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Wait for line to close the program
            Console.ReadLine();
        }
    }
}
