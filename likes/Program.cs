using System;
using System.Collections.Generic;
namespace likes
{
    class Program
    {
        static void Main(string[] args)
        {
            IdList a = new IdList();
            a.AddId(6);
            a.AddId(643002);
            a.AddId(8);
            a.AddId(3);
            a.AddId(1);
            a.AddId(12);
            a.removeId(6);
            Console.WriteLine(a.hasId(2));
            Console.WriteLine(a.toString());
            foreach (var c in a.toList())
                Console.WriteLine(c);
        }
    }
}
