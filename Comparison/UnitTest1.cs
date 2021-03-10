using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Jacob";

            bool equals = age == 21;
            Console.WriteLine(equals);

            bool userIsJacob = userName == "Jacob";
            Console.WriteLine(userName);
            Console.WriteLine("user is 21:" + equals);

            bool notEqual = age != 122;
            Console.WriteLine($"User is not 122: {notEqual}");

            bool userIsNotTerry = userName != "Terry";
            Console.WriteLine(userIsNotTerry);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listAreEqual = firstList == secondList;
            Console.WriteLine($"The list are equal?: {listAreEqual}");

            bool greaterThan = age > 12;
            Console.WriteLine(greaterThan);

            bool greaterThanOrEqual = age <= 24;
            Console.WriteLine(greaterThanOrEqual);

            bool lessThan = age < 66;
            Console.WriteLine(lessThan);

            bool lessThanOrEqualTo = age <= 24;
            Console.WriteLine(lessThanOrEqualTo);

            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;

            Console.WriteLine($"True or True {tOrT}");
            Console.WriteLine($"True or False {tOrF}");
            Console.WriteLine($"False or True {fOrT}");
            Console.WriteLine($"False or False {tOrF}");


            bool andValue = greaterThan && orValue;

            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;

            Console.WriteLine($"True or True {tAndT}");
            Console.WriteLine($"True or False {tAndF}");
            Console.WriteLine($"False or True {fAndT}");
            Console.WriteLine($"False or False {tAndF}");
        }
    }
}

