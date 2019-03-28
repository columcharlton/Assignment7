using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment7
{
    [TestFixture]
    class NUnitTest
    {
        [Test]
        public void PositiveTest()
        {
            int x = 7;
            int y = 10;

            Assert.AreEqual(x, y);

        }

        [Test]
        public void NegativeTest()
        {
            if (true)
                Assert.Fail("Failure");
        }


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
