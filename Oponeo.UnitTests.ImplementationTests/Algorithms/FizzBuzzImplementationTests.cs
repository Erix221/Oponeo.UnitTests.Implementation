using Oponeo.UnitTests.Implementation.Algorithms;

namespace Oponeo.UnitTests.ImplementationTests.Algorithms
{
    [TestClass]
    public class FizzBuzzImplementationTests
    {
        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        public void Returns_Proper_String_Given_I(int i, string expectedResult)
        {
            //Arrange
            FizzBuzzImplementation fizzBuzz = new FizzBuzzImplementation();

            //Act
            string result = fizzBuzz.Process(i);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}