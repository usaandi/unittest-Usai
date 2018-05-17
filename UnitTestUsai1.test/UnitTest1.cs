using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUsai1.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string firstname = "Kaur ";
            string lastname = "Usai";
            string fullname = "Kaur Usai";

            MyTest n = new MyTest();
            string nimi = n.Name(firstname, lastname);

            Assert.AreEqual(fullname, nimi);
        }
    }
}
