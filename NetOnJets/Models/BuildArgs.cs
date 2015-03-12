using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerArgs;

namespace NetOnJets.Models
{
    public class BuildArgs
    {
        [HelpHook, ArgShortcut("-?"), ArgDescription("Shows this help")]
        public bool Help { get; set; }

        [ArgDescription("This is the SolutionName"), ArgPosition(2)]
        [ArgRequired(PromptIfMissing = true)]
        public string SolutionName { get; set; }
        [ArgDescription("This is the Project Override")]
        [ArgShortcut("-p"), ArgShortcut("-project")]
        public bool Project { get; set; }
        [ArgDescription("This is the Config Options")]
        [ArgShortcut("-o"), ArgShortcut("-options")]
        public string Options { get; set; }
        [ArgDescription("This is the Config Name")]
        [ArgShortcut("-c"), ArgShortcut("-config")]
        public string ConfigurationName { get; set; }
    }
}
