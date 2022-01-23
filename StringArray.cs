using System;

namespace StringArray
{
    // main class
    public class StringArray
    {
        public static void Main(string[] args)
        {
            // Declare the array of strings
            String [] relatives = {"Martha", "Blackson", "Romance", "Gradyes","Chipiliro", "Kisty"};

            // Printing the family members
            Console.WriteLine("1 born " + relatives[0]);
            Console.WriteLine("2 born " + relatives[1]);
            Console.WriteLine("3 born " + relatives[2]);
            Console.WriteLine("4 born " + relatives[3]);
            Console.WriteLine("5 born " + relatives[4]);
            Console.WriteLine("6 born " + relatives[5]);


            Console.WriteLine("The length is " + relatives.Length);
        }
    }
}