using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionOverloading
{
    public class CorparateCustomerManager:BaseCustomerManager
    {
        public override void Add(Logger logger)
        {
            Console.WriteLine("logger geldi");
        }
    }
}
