﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Assignment7
{
        [TestClass]
        public class NUnitTest
{
        BusinessLogic businessLogic = new BusinessLogic();

        [TestMethod]
        public void AverageTest()
        {
            
            businessLogic.Average(); Console.Write("TESTING Average method\n");

            Assert.AreEqual(2, businessLogic.Average());


        }

        [TestMethod]
        public void AvgContractLength()
        {
            
            businessLogic.AvgContractLength(); Console.Write("TESTING Average method\n");

            Assert.AreEqual(9, businessLogic.AvgContractLength());

        }



        [TestMethod]
        public void EstimateOnContract()
        {

            businessLogic.EstimateOnContract(1); Console.Write("TESTING Average method\n");

            Assert.AreEqual(1, businessLogic.EstimateOnContract(1));

        }

        
        [TestMethod]
        public void EstimateAVGContractValue()
        {
            
            businessLogic.EstimateOnContract(1); Console.Write("TESTING Average method\n");

            Assert.AreEqual(1100, businessLogic.EstimateAVGContractValue(1));

        }


        [TestMethod]
        public void CalculateNoOfOpenContracts()
        {

            businessLogic.CalculateNoOfOpenContracts(); Console.Write("TESTING Average method\n");

            Assert.AreEqual(5, businessLogic.CalculateNoOfOpenContracts());

        }

        
    }
}
