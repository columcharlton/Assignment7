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
        [TestMethod]
        public void AverageTest()
        {
            BusinessLogic businessLogic = new BusinessLogic();

            businessLogic.Average(); Console.Write("TESTING Average method\n");

            Assert.AreEqual(2, businessLogic.Average());


        }

        //[TestMethod]
        //public void AvgContractLength()
        //{
        //    Contract contract = new Contract();

        //    contract.AvgContractLength(); Console.Write("TESTING Average method\n");

        //    Assert.AreEqual(9, contract.AvgContractLength());


        //}


        //[Test]
        //public void NegativeTest()
        //{
        //    if (true)
        //        Assert.Fail("Failure");
        //}



        //[Test, ExpectedException(typeof(NotSupportedException))]
        //public void ExpectedExceptionTest()
        //{
        //    throw new NotSupportedException();
        //}

        //[Test, Ignore]
        //public void NotImplemtedException()
        //{
        //    throw new NotImplementedException();
        //}



    }
}
