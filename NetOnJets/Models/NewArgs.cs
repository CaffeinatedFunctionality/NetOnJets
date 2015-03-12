using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerArgs;

namespace NetOnJets.Models
{
    public class NewArgs
    {
        [ArgDescription("This is the ProjectName")]
        [ArgShortcut("-n"), ArgShortcut("-name")]
        public string ProjectName { get; set; }
    }
}
