using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Contract contract = new Contract();



            Console.WriteLine("Which table would you like to work with ? ");
            Console.WriteLine("Press 1 for Clients ");
            Console.WriteLine("Press 2 for Contracts ");
            Console.WriteLine("Press 0 to exit ");
            int caseSwitch1 = Convert.ToInt32(Console.ReadLine());



            switch (caseSwitch1)
            {
                case 1:
                    Console.WriteLine("Would you like to 1:connect , 2:read , 3:insert , 4:update 5:delete or 5:disconnect ? ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    //int choice = 1;
                    switch (choice)
                    {
                        case 1:
                            client.Connect();
                            break;
                        case 2:
                            client.ReadClients();
                            contract.ReadContract();
                            break;
                        case 3:
                            client.Insert();
                            client.ReadClients();
                            break;
                        case 4:
                            client.Update();
                            client.ReadClients();
                            break;
                        case 5:
                            client.Delete();
                            client.ReadClients();
                            break;
                        case 6:
                            client.Disconnect();
                            break;


                    }
                    break;
                case 2:
                    //Console.WriteLine("Would you like to connect:1 , read:2 , insert:3 , update:4 delete:5 or disconnect:5 ? ");
                    Console.WriteLine("Would you like to \n 1:View table data \n 2:See Average Contract duration \n 3:See Avg Contract Length \n " +
                        "4:Estimate time remaining on Contract \n 5:Estimate AVG Contract Value \n 6:Calculate No Of Open Contracts  ");

                    int choice2 = Convert.ToInt32(Console.ReadLine());


                    switch (choice2)
                    {
                        case 1:
                            contract.ReadContract();
                            break;
                        case 2:
                            contract.Average();
                            break;
                        case 3:
                            contract.AvgContractLength();
                            break;
                        case 4:
                            contract.EstimateOnContract();
                            break;
                        case 5:
                            contract.EstimateAVGContractValue();
                            break;
                        case 6:
                            contract.CalculateNoOfOpenContracts();
                            break;


                    }
                    break;
                }
                    Console.ReadLine();

        }

        }
    }