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
            Console.WriteLine("ContractNo, Value, Client_Id, StartDate, EndDate");    //Display the output to the user
            Console.WriteLine(businessLogic.ReadContract());
            
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
            Console.WriteLine("The average contract duration is " + businessLogic.AvgContractLength() + " months");

        }



        //--3
        //--c.Estimate the time remaining on a specific contract.
        public void EstimateOnContract()
        {

            Console.WriteLine("The time remaining on that specific contract is " + businessLogic.EstimateOnContract(1) + " Month");

        }


        //        --4
        //--d.Calculate the average contract value per client.
        public void EstimateAVGContractValue()  
        {

            Console.WriteLine("The average contract value for that client " + businessLogic.EstimateAVGContractValue(1) );

        }
        //     --5
        //--e.Calculate the total number of contrats open currently.
        public void CalculateNoOfOpenContracts()
        {

            Console.WriteLine("The average contract duration " + businessLogic.CalculateNoOfOpenContracts() + " months");

        }

    }
}