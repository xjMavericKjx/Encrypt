using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encrypt;
namespace MyFirstTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCaesarEncrypt()
        {
            string testString = Caesar.Encrypt("bbbb", 2);
            Assert.AreEqual(testString, "dddd", "Не верны данные");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCaesarEncryptError()
        {
            Caesar.Encrypt("bbb1", 2);
        }

        [TestMethod]
        public void TestCaesarShiftError()
        {
            UIMainForm m = new UIMainForm();
            Assert.IsNotNull(m.GetShift());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestVijinerGetMatrixCharError()
        {
            Vijiner.GetCharInMatrix(25, 26);
        }

        [TestMethod]
        public void TestCaesarDecrypt()
        {
            string testString = Caesar.Decrypt("dddd", 2);
            Assert.AreEqual(testString, "bbbc", "Не верны данные");
        }
    }
}
