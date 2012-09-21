using System;
using _002_ConsomeWCF.Proxy;

namespace _002_ConsomeWCF
{
    class Program
    {
        static void Main()
        {
            var proxy = new ClienteServiceClient();

            var c = proxy.GetById(1);
            if (c != null) Console.WriteLine("{0} -> {1}", c.CustomerID, c.FirstName);

            c = proxy.GetById(10);
            if (c != null) Console.WriteLine("{0} -> {1}", c.CustomerID, c.FirstName);

            c = proxy.GetById(10000);
            if (c != null) Console.WriteLine("{0} -> {1}", c.CustomerID, c.FirstName);

            Console.WriteLine();

            var generos = proxy.GetTop10();

            foreach (var item in generos)
            {
                Console.WriteLine("{0} -> {1}", item.CustomerID, item.FirstName);
            }

            Console.ReadKey();
        }
    }
}
