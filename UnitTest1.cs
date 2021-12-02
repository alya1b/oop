using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest8
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expression = "sdgsgs";
            string expected = "";

            oopLaba1.Cell a = new oopLaba1.Cell(expression);
            string actual = a.Evaluate();

            Assert.AreEqual(expected, actual);

        }
    }
}
