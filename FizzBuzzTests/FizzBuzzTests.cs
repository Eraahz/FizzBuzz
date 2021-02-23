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
    }
}
