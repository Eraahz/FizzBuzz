using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FizzBuzz;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void AliceGiveNumberToBob()
        {
            var actual = FizzBuzzGame.AliceGiveNumberToBob(18);
            Assert.IsNotNull(actual);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void AliceGiveNumber0ToBobExpectingArgumentOutOfRangeException()
        {
            var actual = FizzBuzzGame.AliceGiveNumberToBob(0);
            Assert.AreEqual(new ArgumentOutOfRangeException(), actual);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void AliceGiveNegativeNumberToBobExpectingArgumentOutOfRangeException()
        {
            var actual = FizzBuzzGame.AliceGiveNumberToBob(-18);
            Assert.AreEqual(new ArgumentOutOfRangeException(), actual);
        }

        [TestMethod]
        public void AliceGiveNumberMultipleOf3OnlyExpectingFizz()
        {
            var actual = FizzBuzzGame.AliceGiveNumberToBob(6);
            Assert.AreEqual("Fizz", actual);
        }

        [TestMethod]
        public void AliceGiveNumberMultipleOf5OnlyExpectingBuzz()
        {
            var actual = FizzBuzzGame.AliceGiveNumberToBob(10);
            Assert.AreEqual("Buzz", actual);
        }

        [TestMethod]
        public void AliceGiveNumberMultipleOf5And3ExpectingFizzBuzz()
        {
            var actual = FizzBuzzGame.AliceGiveNumberToBob(15);
            Assert.AreEqual("FizzBuzz", actual);
        }
    }
}
