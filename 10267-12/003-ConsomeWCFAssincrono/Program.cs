using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _003_ConsomeWCFAssincrono.Proxy;

namespace _003_ConsomeWCFAssincrono
{
    class Program
    {
        static ClienteServiceClient c = null;

        static void Main(string[] args)
        {
            c = new ClienteServiceClient();

            c.BeginGetTop10(GetTop10Completed, null);

            c.BeginGetById(1, GetByIdCompleted, null);
            c.BeginGetById(10, GetByIdCompleted, null);
            c.BeginGetById(100, GetByIdCompleted, null);

            Console.ReadKey();
        }

        private static void GetByIdCompleted(IAsyncResult iar)
        {
            var obj = c.EndGetById(iar);

            if (obj == null) return;

            Console.WriteLine("por Id -> {0} {1}", obj.CustomerID, obj.FirstName);
        }

        private static void GetTop10Completed(IAsyncResult iar)
        {
            var objs = c.EndGetTop10(iar);

            if (objs == null || objs.Length == 0) return;

            foreach (var item in objs)
            {
                Console.WriteLine("-> {0} {1}", item.CustomerID, item.FirstName);
            }
        }
    }
}
