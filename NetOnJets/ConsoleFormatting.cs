using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOnJets
{
    class ConsoleFormatting
    {
        public static string Indent(int count)
        {
            return "".PadLeft(count);
        }
    }
}
