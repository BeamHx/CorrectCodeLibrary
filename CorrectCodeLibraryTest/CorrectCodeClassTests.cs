using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CorrectCodeLibrary;

namespace CorrectCodeLibraryTest
{
    [TestClass]
    public class CorrectCodeClassTests
    {
        //Нерпавильный код = false
        [DataTestMethod]
        [DataRow("")]
        [DataRow("   ")]
        [DataRow("123")]
        [DataRow("123123123123123")]
        [DataRow("strokasymb")]
        [DataRow("1234123404")]
        [DataRow("1234123401")]



        public void IsCorrectCode_False_ReturnFalse(string candidate)
        {
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            Assert.IsFalse(actual);
        }
        //Правилный код = false
        [DataTestMethod]
        [DataRow("1234123400")]
        [DataRow("3000030001")]
        [DataRow("3000130009")]


        public void IsCorrectCode_True_ReturnTrue(string candidate)
        {
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            Assert.IsTrue(actual);
        }
    }
}
