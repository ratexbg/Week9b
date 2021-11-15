using Problem1;
using System;
using System.Collections.Generic;

namespace Problem1test
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(new int[] { 1, 2, 3 }, 1);
            Console.WriteLine(v1);
            Vector v2 = new Vector(v1);
            Console.WriteLine("Hashcode and Equals");
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v1.GetHashCode());
            Console.WriteLine(v2.GetHashCode());
            Console.WriteLine(v1.Equals(v2));
            Vector v3 = new Vector();
            Console.WriteLine(v3);
            Console.WriteLine(v2);
            Console.WriteLine(v3.GetHashCode());
            Console.WriteLine(v2.GetHashCode());
            Console.WriteLine(v3.Equals(v2));
            Vector v4 = new Vector(new int[] { 3, 2, 1 }, 1);
            Console.WriteLine(v1);
            Console.WriteLine(v1.GetHashCode());
            Console.WriteLine(v4.GetHashCode());
            Console.WriteLine(v1.Equals(v4));

            int[] array = (int[])v4; // Explicit conversion
            Console.WriteLine(v4);
            Console.WriteLine(string.Join(", ", array));

            Vector v5 = new int[] { 3, 4, 5, 6 }; // implict  conversion
            Console.WriteLine(v5);
            Console.WriteLine(string.Join(", ", new int[] { 3, 4, 5, 6 }));

            List<int> list = v5.Filter(e => e > 3);
            Console.WriteLine(string.Join(", ", list));

            Vector v6 = v5.Map(e => e * e);
            Console.WriteLine(v6);
        }
    }
}
