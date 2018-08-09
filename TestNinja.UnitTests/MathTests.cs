using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        // Set Up
        [SetUp]
        public void Setup()
        {
            _math = new Math();

        }

        [Test]
        public void add_WhenCalled_ReturnTheSumOfArguments()
        {
            //Act
            var result = _math.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void max_FirstArgumentIsGreater_ReturnTheFirstArgument(int a, int b, int expectedResult)
        {
            //Act
            var result = _math.Max(a, b);
                 
            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
