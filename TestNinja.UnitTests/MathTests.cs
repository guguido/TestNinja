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

        [Test]
        public void max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            //Act
            var result = _math.Max(2, 1);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            //Act
            var result = _math.Max(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void max_ArgumentsAreEqual_ReturnTheArguments()
        {
            //Act
            var result = _math.Max(1, 1);

            //Assert
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
