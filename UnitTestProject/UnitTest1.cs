using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarsRents;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public bool PasswordLengthTest(string password)
        {
            if (password.Length >= 4 && password.Length <= 20)
                return true;
            else 
                return false;
        }

        [TestMethod]
        public void ValidatePasswordTest()
        {

            string password = "admin";

            bool isCorrect = PasswordLengthTest(password);

            Assert.AreEqual(true, isCorrect);

        }

    }
}
