using System;
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
            //Unit test for AverageTest method expected answer = 2
            Assert.AreEqual(2, businessLogic.Average());
        }

        [TestMethod]
        public void AvgContractLength()
        {
            //Unit test for AvgContractLength method expected answer = 9
            Assert.AreEqual(9, businessLogic.AvgContractLength());
        }

        [TestMethod]
        public void EstimateOnContract()
        {
            //Unit test for EstimateOnContract method expected answer = 1
            //for for ContractNo =1
            Assert.AreEqual(1, businessLogic.EstimateOnContract(1));
        }

        [TestMethod]
        public void EstimateAVGContractValue()
        {

            //Unit test for EstimateAVGContractValue method expected answer = 1100
            //for Clintid =1
            Assert.AreEqual(1100, businessLogic.EstimateAVGContractValue(1));
        }


        [TestMethod]
        public void CalculateNoOfOpenContracts()
        {
            //Unit test for CalculateNoOfOpenContracts method expected answer = 5
            Assert.AreEqual(5, businessLogic.CalculateNoOfOpenContracts());

        }

        
    }
}
