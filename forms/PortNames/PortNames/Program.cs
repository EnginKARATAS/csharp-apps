using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] SerialPorts = System.IO.Ports.SerialPort.GetPortNames();
           
            //show all available ports
            foreach (string com in SerialPorts)
            {
                Console.WriteLine(com);
                Console.ReadKey();
            }
        }
    }
}
