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

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void AliceGiveNumber0ToBob()
        {
            var actual = FizzBuzzGame.AliceGiveNumberToBob(0);
            Assert.AreEqual(new ArgumentException(), actual);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void AliceGiveNegativeNumberToBob()
        {
            var actual = FizzBuzzGame.AliceGiveNumberToBob(-18);
            Assert.AreEqual(new ArgumentException(), actual);
        }

        [TestMethod]
        public void AliceGiveNumberMultipleOf3()
        {
            var actual = FizzBuzzGame.AliceGiveNumberToBob(6);
            Assert.AreEqual("Fizz", actual);
        }

        [TestMethod]
        public void AliceGiveNumberMultipleOf5()
        {
            var actual = FizzBuzzGame.AliceGiveNumberToBob(10);
            Assert.AreEqual("Buzz", actual);
        }
    }
}
