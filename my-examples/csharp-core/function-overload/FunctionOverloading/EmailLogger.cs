using System;

namespace FunctionOverloading
{
    public class EmailLogger : Logger
    {
        public override void Log()
        {
            Console.WriteLine("email logger classtan loglandı");
        }
    }
}
