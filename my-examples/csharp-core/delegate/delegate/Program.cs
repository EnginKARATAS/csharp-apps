using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        public delegate int stringArgsExeptionPhenemenonEventHandler(int a, int b);
        public static int Carp(int a, int b)
        {
            return a * b;
        }
        public static int Topla(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            stringArgsExeptionPhenemenonEventHandler delege = new stringArgsExeptionPhenemenonEventHandler(Topla);
            Console.WriteLine(new string('-', 40));
            delege += Carp;
            Console.WriteLine(delege.Invoke(5, 5));
            Console.WriteLine(new string('-', 40));
            delege -= Carp;
            
            Console.WriteLine(delege.Invoke(5, 5));


            Delegate[] metodlarimiz = delege.GetInvocationList();
            foreach (var item in metodlarimiz)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.Target);
                int sonuc = (int)item.DynamicInvoke(10, 10);
                Console.WriteLine(sonuc);
                Console.ReadKey();

            }
        }
    }
}
