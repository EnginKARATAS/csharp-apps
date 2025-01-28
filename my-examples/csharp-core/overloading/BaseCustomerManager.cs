using System;

namespace FunctionOverloading
{
    public class BaseCustomerManager
    {
        public virtual void Add(Logger deger)
        {
            Console.WriteLine("base classtan " + deger + " eklendi");
        }
    }
}