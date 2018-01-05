using System;
using System.Linq;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz C#");
            foreach (var number in Enumerable.Range(1, 100))
            {
                string output = null;
                if(number % 3 == 0) { output = number + ": Fizz";}
                if(number % 5 == 0) { output = number + ": Buzz";}
                if(number % 15 == 0) { output = number + ": FizzBuzz";}
                output = (output == null) ? number.ToString() : output;
                Console.WriteLine(output);

            }


        }
    }
}
