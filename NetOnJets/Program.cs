using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace NetOnJets
{
    class Program
    {
        

        static void Main(string[] args)
        {


        }

        public static void WriteToConsole(string message = "")
        {
            if (message.Length > 0)
            {
                Console.WriteLine(message);
            }
        }
    }
}