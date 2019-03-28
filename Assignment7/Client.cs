using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Client
    {


        public void Connect()
        {
            string connectionString;    //Variable declaration
            SqlConnection cnn;

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\colum\Source\Repos\Assignment7\Assignment7\Db.mdf;Integrated Security=True"; //Set connection string
            cnn = new SqlConnection(connectionString);  //Assign connection
            cnn.Open(); //Open connection
            Console.WriteLine("Connection Open  !");


        }


        //For reading Contract_Clients table
        public void ReadClients()
        {
            string connectionString;    //Variable declaration
            SqlConnection cnn;

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\colum\Source\Repos\Assignment7\Assignment7\Db.mdf;Integrated Security=True"; //Set connection string
            cnn = new SqlConnection(connectionString);  //Assign connection
            cnn.Open(); //Open connection

            //For reading
            //Define variables
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select Client_ID, Client_Name, DOB, Address from Contract_Clients";    //Define sql statement
            command = new SqlCommand(sql, cnn); // The command statement
            dataReader = command.ExecuteReader();   //Define the data reader

            Console.WriteLine("Client_ID, Client_Name, DOB, Address");    //Display the output to the user

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + "\n";

            }

            Console.WriteLine(Output);    //Display the output to the user

            dataReader.Close(); //Close all objects
            command.Dispose();
        }


        //For Inserting
        public void Insert()
        {
            string connectionString;    //Variable declaration
            SqlConnection cnn;

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\colum\Source\Repos\Assignment7\Assignment7\Db.mdf;Integrated Security=True"; //Set connection string
            cnn = new SqlConnection(connectionString);  //Assign connection
            cnn.Open(); //Open connection

            //For Inserting
            //Define variables
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            //Define the insert statement
            sql = "INSERT INTO [Contract_Clients](Client_Id, Client_Name, DOB, Address) VALUES ('00000004', 'Mary Joe', '10/1/1985', 'Barna, Galway')";

            //Define the sqlcommand
            command = new SqlCommand(sql, cnn);

            //Associate the insert command
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            //Close all objects
            command.Dispose();

        }
        //For Updating
        public void Update()
        {

            string connectionString;    //Variable declaration
            SqlConnection cnn;

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\colum\Source\Repos\Assignment7\Assignment7\Db.mdf;Integrated Security=True"; //Set connection string
            cnn = new SqlConnection(connectionString);  //Assign connection
            cnn.Open(); //Open connection

            //For Updating
            //Define variables
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            //Define the Update statement

            sql = "Update [Contract_Clients] set Client_Name = '" + "Mary Joe Joe " + "' where Client_Id=00000004 ";

            //Define the sqlcommand
            command = new SqlCommand(sql, cnn);

            //Associate the Update command
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            //Close all objects
            command.Dispose();

        }

        //For Deleting
        public void Delete()
        {

            string connectionString;    //Variable declaration
            SqlConnection cnn;

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\colum\Source\Repos\Assignment7\Assignment7\Db.mdf;Integrated Security=True"; //Set connection string
            cnn = new SqlConnection(connectionString);  //Assign connection
            cnn.Open(); //Open connection



            //For Deleting
            //Define variables
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            //Define the Update statement
            sql = "Delete Contract_Clients where Client_Id=00000004 ";

            //Define the sqlcommand
            command = new SqlCommand(sql, cnn);

            //Associate the Update command
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            //Close all objects
            command.Dispose();

        }

        public void Disconnect()
        {
            string connectionString;    //Variable declaration
            SqlConnection cnn;

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\colum\Source\Repos\Assignment7\Assignment7\Db.mdf;Integrated Security=True"; //Set connection string
            cnn = new SqlConnection(connectionString);  //Assign connection

            cnn.Close();
            Console.WriteLine("Connection Closed  !");

        }

    }
}
