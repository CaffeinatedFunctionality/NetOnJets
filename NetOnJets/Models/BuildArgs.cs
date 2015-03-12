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
        [ArgDescription("This is the SolutionName"), ArgPosition(1)]
        public string SolutionName { get; set; }

        [ArgDescription("This is the Project Override"), DefaultValue(false)]
        [ArgShortcut("-p")]
        public bool Project { get; set; }
        
        [ArgDescription("This is the Config Name"), DefaultValue("Release")]
        [ArgShortcut("-c"), ArgShortcut("-config")]
        public string BuildConfiguration { get; set; }
    }
}
