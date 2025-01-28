using System;

namespace FunctionOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CorparateCustomerManager corparateCustomerManager = new CorparateCustomerManager();
            corparateCustomerManager.Add(new EmailLogger());

        }
    }
}
