using System.Text;

namespace Oponeo.UnitTests.Implementation
{
    public class FizzBuzzImplementation
    {
        public string Process(int i)
        {
            StringBuilder sb = new StringBuilder();

            if (i % 3 == 0)
            {
                sb.Append("Fizz");
            }

            if (i % 5 == 0)
            {
                sb.Append("Buzz");
            }

            if (sb.Length == 0)
            {
                sb.Append(i);
            }

            return sb.ToString();
        }
    }
}