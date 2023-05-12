using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = WordToInteger.Program.ParseEnglish("I wrote two millions sentences");
            Assert.AreEqual(result, "I wrote 2000000 sentences");
        }
        [TestMethod]
        public void TestMethod2()
        {
            var result = WordToInteger.Program.ParseEnglish("I wrote two millions sentences");
            Assert.AreNotEqual(result, "I wrote 2000001 sentences");
        }
        [TestMethod]
        public void TestMethod3()
        {
            var result = WordToInteger.Program.ParseEnglish("I wrote two millions sentences for three dollars");
            Assert.AreEqual(result, "I wrote 2000000 sentences for 3 dollars");
        }
        [TestMethod]
        public void TestMethod4()
        {
            var result = WordToInteger.Program.ParseEnglish("I bought forty cars");
            Assert.AreEqual(result, "I bought 40 cars");
        }
        [TestMethod]
        public void TestMethod5()
        {
            var result = WordToInteger.Program.ParseEnglish("I bought fifty cars");
            Assert.AreEqual(result, "I bought 50 cars");
        }
        [TestMethod]
        public void TestMethod6()
        {
            var result = WordToInteger.Program.ParseEnglish("I have three quadrillions homes");
            Assert.AreEqual(result, "I have 3000000000000000 homes");
        }
    }
}
