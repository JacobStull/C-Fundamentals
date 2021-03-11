using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Morning_Challenges
{
    [TestClass]
    public class W1D3
    {
        [TestMethod]
        public void Chalenge()
        {
            string super = "Supercalifragilisticexpialidocious";
            int count = 1;
            foreach (char letter in super)
            {
                if (letter == 'i')
                {
                    Console.WriteLine($"{count++} - {letter}    I ");

                }
                else if (letter == 'l')
                {
                    Console.WriteLine($"{count++} - {letter}   L");
                }
                else
                {
                    Console.WriteLine($"{count++} - {letter}   Not an I");
                   
                }
                
            }
            
            
        }
    }
}
