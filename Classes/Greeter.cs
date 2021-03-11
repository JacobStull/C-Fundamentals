using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Greeter
    {
        
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        Random _random = new Random();
        public void GetRandomGreeting()
        {
            string[] avaliableGreetings = new string[] { "Good Morning", "Whats up", "Whas up Dawh", "Howdy" };
            int randomNumber = _random.Next(0, avaliableGreetings.Length);
            string randomGreeting = avaliableGreetings.ElementAt(randomNumber);
            Console.WriteLine($"{randomGreeting}");

        }
    }
}
