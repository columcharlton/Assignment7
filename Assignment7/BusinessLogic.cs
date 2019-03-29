using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class BusinessLogic
    {
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
        public int Average()
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


            sql = "SELECT Count(ContractNo)/COUNT(distinct Client_Id) as 'AverageNoOfContractsPerCustomer'FROM contract";    //Define sql statement
            command = new SqlCommand(sql, cnn); // The command statement
            dataReader = command.ExecuteReader();   //Define the data reader

            //while (dataReader.Read())
            //{
            //    Output = "AverageNoOfContractsPerCustomer " + Output + dataReader.GetValue(0) + "\n";

            //}

            //Console.WriteLine(Output);    //Display the output to the user

            //while (dataReader.Read())
            //{
            //    O = dataReader.GetValue(0) + "\n";

            //}

            int x = 0;

            while (dataReader.Read())
            {
                x = Convert.ToInt32(dataReader.GetValue(0));

            }


            dataReader.Close(); //Close all objects
            command.Dispose();
            cnn.Close();

            return (x);

        }

        //--2
        //--b.Calculate the average contract duration.
        public int AvgContractLength()
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
            int x = 0;


            sql = "SELECT sum(DATEDIFF(MONTH, StartDate, EndDate))/COUNT(distinct ContractNo) as 'AvgContractLength' FROM contract";    //Define sql statement
            command = new SqlCommand(sql, cnn); // The command statement
            dataReader = command.ExecuteReader();   //Define the data reader

            //while (dataReader.Read())
            //{
            //    Output = "AverageContractDuration " + Output + dataReader.GetValue(0) + " months" + "\n";

            //}

            //Console.WriteLine(Output);    //Display the output to the user

            //dataReader.Close(); //Close all objects
            //command.Dispose();


            
            while (dataReader.Read())
            {
                x = Convert.ToInt32(dataReader.GetValue(0));

            }
            
            dataReader.Close(); //Close all objects
            command.Dispose();
            cnn.Close();


            return (x);
            
        }



        //--3
        //--c.Estimate the time remaining on a specific contract.
        public int EstimateOnContract(int ContractNo)
        {
            int contractNo = ContractNo;
            int x = 0; 
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

            sql = "SELECT[ContractNo], DATEDIFF(MONTH, StartDate, EndDate) as 'ContractLength' FROM contract where ContractNo =" + ContractNo + ";";    //Define sql statement
            command = new SqlCommand(sql, cnn); // The command statement
            dataReader = command.ExecuteReader();   //Define the data reader


            while (dataReader.Read())
            {
                x = Convert.ToInt32(dataReader.GetValue(0));

            }

            dataReader.Close(); //Close all objects
            command.Dispose();
            cnn.Close();


            return (x);
            
        }


        //        --4
        //--d.Calculate the average contract value per client.
        public int EstimateAVGContractValue(int ClientId)
        {
            int clientId = ClientId;
            int x = 0;
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

            sql = "SELECT avg([Value]) as 'AVGContractValue' FROM contract where [Client_Id] = " + clientId + ";";    //Define sql statement
            command = new SqlCommand(sql, cnn); // The command statement
            dataReader = command.ExecuteReader();   //Define the data reader

            
            while (dataReader.Read())
            {
                x = Convert.ToInt32(dataReader.GetValue(0));

            }

            dataReader.Close(); //Close all objects
            command.Dispose();
            cnn.Close();


            return (x);
            
        }
        //     --5
        //--e.Calculate the total number of contrats open currently.
        public int CalculateNoOfOpenContracts()
        {

            int x = 0;
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


            while (dataReader.Read())
            {
                x = Convert.ToInt32(dataReader.GetValue(0));

            }

            dataReader.Close(); //Close all objects
            command.Dispose();
            cnn.Close();


            return (x);


        }
    }
}
