using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            int sum = a + b;
            sum += 3;

            Console.WriteLine(sum);

            int difference = a - b;
            // difference -= 3;
            Console.WriteLine($"difference : { difference}");

            int product = a * b;
            // product*=3;
            Console.WriteLine($"product : {product}");

            int quotient = a / b;
            Console.WriteLine($"quotient : {quotient} ");

            int remainder = a % b;
            Console.WriteLine($"remainder : {remainder}");

            DateTime now = DateTime.Now;
            DateTime someday = new DateTime(1978, 1, 1);

            TimeSpan timeSpan = now - someday;
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(timeSpan.TotalMilliseconds);

        }
    }
}

