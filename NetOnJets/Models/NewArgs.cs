using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerArgs;

namespace NetOnJets.Models
{
    class NewArgs
    {
        [HelpHook, ArgShortcut("-?"), ArgDescription("Shows this help")]
        public bool Help { get; set; }

        [ArgDescription("This is the ProjectName")]
        [ArgShortcut("-n"), ArgShortcut("-name")]
        [ArgRequired(PromptIfMissing = true)]
        public string Name { get; set; }

        [ArgDescription("This allows for options")]
        [ArgShortcut("-o"), ArgShortcut("-option")]
        public string Option { get; set; }
    }
}
