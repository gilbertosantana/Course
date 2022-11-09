using System;

namespace DataTypeBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte n1 = 127;

            byte n2 = 255;

            int n3 = 1000;

            int n4 = 2147483647;

            long n5 = 2147483648L;

            bool complete = false;

            char genre = 'F';

            char letter = '\u03B2';

            float n6 = 4.5F;

            double n7 = 4.5;

            string name = "Maria Green";

            object obj1 = "Alex Brown";
            
            object obj2 = 4.5f;

            n1++;
            n2++;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            
            Console.WriteLine(complete);
            Console.WriteLine(genre);
            Console.WriteLine(letter);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(name);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

        }
    }
}
