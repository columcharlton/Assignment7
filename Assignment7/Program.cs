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
                    Console.WriteLine("Would you like to connect:1 , read:2 , insert:3 , update:4 delete:5 or disconnect:5 ? ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    //int choice = 1;
                    switch (choice)
                    {
                        case 1:
                            client.Connect();
                            client.Disconnect();
                            break;
                        case 2:
                            client.ReadClients();
                            contract.ReadContract();
                            client.Disconnect();
                            break;
                        case 3:
                            client.Insert();
                            client.ReadClients();
                            client.Disconnect();
                            break;
                        case 4:
                            client.Update();
                            client.ReadClients();
                            client.Disconnect();
                            break;
                        case 5:
                            client.Delete();
                            client.ReadClients();
                            client.Disconnect();
                            break;
                        case 6:
                            client.Disconnect();
                            break;


                    }
                    break;
                case 2:
                    //Console.WriteLine("Would you like to connect:1 , read:2 , insert:3 , update:4 delete:5 or disconnect:5 ? ");
                    Console.WriteLine("Would you like to \n connect:1 \n View table data:2 \n See Average Contract duration:3 \n See Avg Contract Length:4 \n " +
                        "Estimate time remaining on Contract:5 \n Estimate AVG Contract Value:6 \n Calculate No Of Open Contracts:7  ? ");

                    int choice2 = Convert.ToInt32(Console.ReadLine());


                    switch (choice2)
                    {
                        case 1:
                            client.Connect();
                            break;
                        case 2:
                            contract.ReadContract();
                            break;
                        case 3:
                            contract.Average();
                            break;
                        case 4:
                            contract.AvgContractLength();
                            break;
                        case 5:
                            contract.EstimateOnContract(1);
                            break;
                        case 6:
                            contract.EstimateAVGContractValue();
                            break;
                        case 7:
                            contract.CalculateNoOfOpenContracts();
                            break;


                    }
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
            Console.ReadLine();

        }

        }
    }