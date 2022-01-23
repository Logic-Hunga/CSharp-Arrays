using System;

namespace numberArray
{
    // main class 
    public class NumberArray
    {

        // main method 
        public static void Main(String [] args)
        {
            // main method body
            // 
            int [] elements = {12, 4, 6,12, 45,67,78};

            // printing an element at particular index
            Console.WriteLine("The number is " + elements[0]);
            Console.WriteLine("The number is " + elements[1]);
            Console.WriteLine("The number is " + elements[2]);
            Console.WriteLine("The number is " + elements[3]);
            Console.WriteLine("The number is " + elements[4]);
            Console.WriteLine("The number is " + elements[5]);

            // updating a number
            elements[0] = 22;
            Console.WriteLine("The number is at index 0 now is " + elements[0]);
        }
    }
}
