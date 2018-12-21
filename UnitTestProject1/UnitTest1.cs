using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetCheck_1Point()
        {
            string a = "+79871197276";
            int expected = 1;
            int actual = Class1.GetCheck(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCheck_2Point()
        {
            string a = "460000";
            int expected = 1;
            int actual = Class1.GetCheck(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCheck_3Point()
        {
            string a = "Оренбург";
            int expected = 2;
            int actual = Class1.GetCheck(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCheck_4Point()
        {
            string a = "Жмышенко";
            int expected = 2;
            int actual = Class1.GetCheck(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCheck_5Point()
        {
            string a = "228-666-999 88";
            int expected = 1;
            int actual = Class1.GetCheck(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
