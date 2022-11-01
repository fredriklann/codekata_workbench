using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKata
{
    [TestClass]
    public class CodeKataTests
    {
        [TestMethod]
        public void printFizzBuzzAndNumbersTest()
        {
            for (int i = 1; i <= 100; i++)
            {
                StringBuilder sb = new StringBuilder();

                bool isMultipleOf3 = (i % 3 == 0);
                bool isMultipleOf5 = (i % 5 == 0);

                if (isMultipleOf3) sb.Append("Fizz");
                if (isMultipleOf5) sb.Append("Buzz");
                if (sb.Length == 0) sb.Append(i);

                Console.WriteLine(sb.ToString());

            }
        }
    }
}