using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.UnitTests.Implementation.Algorithms
{
    public class FibonacciSequenceImplementation
    {
        public int ProcessRecursive(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Given index is out of range for fibonacci sequence");

            if (index <= 1)
                return index;

            return ProcessRecursive(index - 1) + ProcessRecursive(index - 2);
        }
        public int ProcessIterative(int index)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            if (index < 0)
                    throw new ArgumentOutOfRangeException("Given index is out of range for fibonacci sequence");

            if (index <= 1)
                return index;

            for (int i = 2; i <= index; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
    }
}
