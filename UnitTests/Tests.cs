using calculator;
using UnitTests;
using NUnit

namespace UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionTest()
        {
            //arrange
            int a = 4;
            int b = 5;
            var operation = Calculator.operation.Addition;
            //act
            
            //assert
            Assert.AreEqual(8, (a+b));
        }
    }
}