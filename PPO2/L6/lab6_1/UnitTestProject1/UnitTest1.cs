using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void zero()
        {
            Silnia s = new Silnia(0);
            Assert.AreEqual(s.oblicz(), 1);
        }
        [TestMethod]
        public void jeden()
        {
            Silnia s1 = new Silnia(1);
            Assert.AreEqual(s1.oblicz(), 1);
        }
        [TestMethod]
        public void piec()
        {
            Silnia s5 = new Silnia(5);
            Assert.AreEqual(s5.oblicz(), 120);
        }
    }
}
