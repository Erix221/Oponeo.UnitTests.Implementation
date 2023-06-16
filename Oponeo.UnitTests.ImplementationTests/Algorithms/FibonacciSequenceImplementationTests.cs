using Oponeo.UnitTests.Implementation.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.UnitTests.ImplementationTests.Algorithms
{
    [TestClass]
    public class FibonacciSequenceImplementationTests
    {
        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(3, 2)]
        [DataRow(11, 89)]
        public void Returns_Proper_Fibonacci_Number_Given_Index_Iterative(int index, int expectedResult)
        {
            //Arrange
            FibonacciSequenceImplementation fibonacciSequenceImplementation = new FibonacciSequenceImplementation();

            //Act
            int result = fibonacciSequenceImplementation.ProcessIterative(index);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Throws_Out_Of_Range_Argument_Exception_Given_Out_Of_Range_Index_Expected_Exception_Approach_Iterative(int index)
        {
            //Arrange
            FibonacciSequenceImplementation fibonacciSequenceImplementation = new FibonacciSequenceImplementation();

            //Act
            fibonacciSequenceImplementation.ProcessIterative(index);

            //
            Assert.Fail("Exception should have been thrown earlier");
        }

        [TestMethod]
        [DataRow(-1)]
        public void Throws_Out_Of_Range_Argument_Exception_Given_Out_Of_Range_Index_Try_Catch_Approach_Iterative(int index)
        {
            //Arrange
            FibonacciSequenceImplementation fibonacciSequenceImplementation = new FibonacciSequenceImplementation();
            Exception expectedExcetpion = null;

            //Act
            try
            {
                int result = fibonacciSequenceImplementation.ProcessIterative(index);
            }
            catch (ArgumentOutOfRangeException e)
            {
                expectedExcetpion = e;
            }
            
            //Assert
            Assert.IsNotNull(expectedExcetpion);

        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(3, 2)]
        [DataRow(11, 89)]
        public void Returns_Proper_Fibonacci_Number_Given_Index_Recursive(int index, int expectedResult)
        {
            //Arrange
            FibonacciSequenceImplementation fibonacciSequenceImplementation = new FibonacciSequenceImplementation();

            //Act
            int result = fibonacciSequenceImplementation.ProcessRecursive(index);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Throws_Out_Of_Range_Argument_Exception_Given_Out_Of_Range_Index_Expected_Exception_Approach_Recursive(int index)
        {
            //Arrange
            FibonacciSequenceImplementation fibonacciSequenceImplementation = new FibonacciSequenceImplementation();

            //Act
            fibonacciSequenceImplementation.ProcessRecursive(index);

            //
            Assert.Fail("Exception should have been thrown earlier");
        }

        [TestMethod]
        [DataRow(-1)]
        public void Throws_Out_Of_Range_Argument_Exception_Given_Out_Of_Range_Index_Try_Catch_Approach_Recursive(int index)
        {
            //Arrange
            FibonacciSequenceImplementation fibonacciSequenceImplementation = new FibonacciSequenceImplementation();
            Exception expectedExcetpion = null;

            //Act
            try
            {
                int result = fibonacciSequenceImplementation.ProcessRecursive(index);
            }
            catch (ArgumentOutOfRangeException e)
            {
                expectedExcetpion = e;
            }

            //Assert
            Assert.IsNotNull(expectedExcetpion);

        }
    }
}
