using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Contract
    {


        BusinessLogic businessLogic = new BusinessLogic();

        //For reading Contract table
        public void ReadContract()
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

            sql = "Select ContractNo, Value, Client_Id, StartDate, EndDate from contract";    //Define sql statement
            command = new SqlCommand(sql, cnn); // The command statement
            dataReader = command.ExecuteReader();   //Define the data reader

            Console.WriteLine("ContractNo, Value, Client_Id, StartDate, EndDate");    //Display the output to the user

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + " - " + dataReader.GetValue(4) + "\n";

            }

            Console.WriteLine(Output);    //Display the output to the user

            dataReader.Close(); //Close all objects
            command.Dispose();

        }

        //1
        //--Calculate the overall average number of contracts per client.
        public void Average()
        {
            Console.WriteLine("The overall average number of contracts per client is " + businessLogic.Average());
            
        }

        //--2
        //--b.Calculate the average contract duration.
        public void AvgContractLength()
        {
            Console.WriteLine("The average contract duration. " + businessLogic.AvgContractLength());

        }



        //--3
        //--c.Estimate the time remaining on a specific contract.
        public void EstimateOnContract()
        {

            Console.WriteLine("The average contract duration. " + businessLogic.EstimateOnContract(1));

        }


        //        --4
        //--d.Calculate the average contract value per client.
        public void EstimateAVGContractValue()  
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

            sql = "SELECT[Client_Id], avg([Value]) as 'AVGContractValue' FROM contract group by[Client_Id]";    //Define sql statement
            command = new SqlCommand(sql, cnn); // The command statement
            dataReader = command.ExecuteReader();   //Define the data reader

            Console.WriteLine("AverageContractDurationForSpecificContract is");    //Display the output to the user

            Console.WriteLine("[Client_Id], avg([Value]");    //Display the output to the user


            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " Euro" + " - " + "\n";

            }

            Console.WriteLine(Output);    //Display the output to the user

            dataReader.Close(); //Close all objects
            command.Dispose();


        }
        //     --5
        //--e.Calculate the total number of contrats open currently.
        public void CalculateNoOfOpenContracts()
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

            sql = "Select Count([ContractNo]) as ContractsStillOpen from [contract] where convert(date, GETDATE()) < [EndDate]";    //Define sql statement
            command = new SqlCommand(sql, cnn); // The command statement
            dataReader = command.ExecuteReader();   //Define the data reader

            Console.WriteLine("CalculateNoOfOpenContracts is");    //Display the output to the user

            Console.WriteLine("Count([ContractNo])");    //Display the output to the user


            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " Open at present" + "\n";

            }

            Console.WriteLine(Output);    //Display the output to the user

            dataReader.Close(); //Close all objects
            command.Dispose();


        }

    }
}