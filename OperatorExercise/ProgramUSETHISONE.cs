using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circe with radius of {radius} is {AreaOfCircle(radius)}");
            Console.WriteLine("For the thought exercise: the value of k is 16.");

            do
            {
                Console.WriteLine("press Enter to close");
            } while (!Console.ReadLine().Equals(""));

            /*Thought Exercise:
What is the value that is printed out to the console?:
var i = 3;
var j = 4; 
var k = ++i * j++;
Console.WriteLine(k);

*/

        }

        public static double AreaOfCircle(double radius)
    {

        return Math.PI * radius * radius;
    }
}
}
