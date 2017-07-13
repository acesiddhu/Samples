using System;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]        
        public void Verify_TransactionFactory_01()
        {

            Console.WriteLine(  "hello1");
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Verify_TransactionFactory_02()
        {

            Console.WriteLine("hello2");
            Assert.AreEqual(1, 1);
        }

        [TestCase("A","b","c")]
        [TestCase("qwe","qwe","bfgbd")]
        [TestCase("ykjghfg","trwert","fgsdfg")]
        public void validatestrings(string first, string second, string third)
        {
            //Comment
        }
    }
}
