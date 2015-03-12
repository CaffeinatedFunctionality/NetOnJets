using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NetOnJets.Models;
using PowerArgs;

namespace NetOnJets
{
    class Program
    {
        

        static void Main(string[] args)
        {
            try
            {

                Args.InvokeAction<CommandArgs>(args);
            }
            catch (PowerArgs.ArgException argEx)
            {
                Console.WriteLine(argEx.Message);
                ArgUsage.GetStyledUsage<CommandArgs>(null, new ArgUsageOptions() { ShowType = false }).Write();
            }
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