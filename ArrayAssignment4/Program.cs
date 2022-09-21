using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] num2 = new int[10] { 89, 32, 52, 46, 13, 10, 31, 91, 73, 91 };
            Console.WriteLine("Orignal Array is:");

            foreach(int i in num2)
            {
                Console.WriteLine(i);
            }

            int min = num2.Min();

             Console.WriteLine($"Minimum integer value is: {min}");
            
        }
    }
}
