using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1Tests
{
    [TestClass]
    public class UnitTest1
    {
        private StringUtils sut;

        [TestInitialize]
        public void Setup()
        {
            sut = new StringUtils();
        }

        [TestMethod]
        [DataRow("abcd", "dcba")]
        [DataRow("1234", "4321")]
        [DataRow("a", "a")]
        [DataRow("ab", "ba")]
        [DataRow("", "")]
        public void Should_Reverse_A_Valid_String2(string input, string expected)
        {
            //Arrange

            //Act
            string actual = sut.Reverse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_Throw_Exception_When_Null()
        {
            //Arrange
            string input = null;

            //Act
            //Assert

            Assert.ThrowsException<ArgumentNullException>
                (() => sut.Reverse(input));
        }

    }
}
