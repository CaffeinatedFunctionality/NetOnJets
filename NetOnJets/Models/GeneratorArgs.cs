using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerArgs;

namespace NetOnJets.Models
{
    public class GeneratorArgs
    {
        [ArgDescription("Is a Model"), DefaultValue(false)]
        [ArgShortcut("-m")]
        public bool Model { get; set; }

        [ArgDescription("Is a Controller"), DefaultValue(false)]
        [ArgShortcut("-c")]
        public bool Controller { get; set; }

        [ArgDescription("Controller/Model Name"), ArgPosition(3)]
        public string Name { get; set; }
        
        [ArgDescription("Defines Views")]
        [ArgShortcut("-v")]
        public string[] Views { get; set; }
        
        [ArgDescription("Defines Attributes")]
        [ArgShortcut("-a")]
        public string[] Attributes { get; set; }

        [ArgDescription("Defines Namespace")]
        [ArgShortcut("-n")]
        public string Namespace { get; set; }

        [ArgDescription("Installs in Repository - Not yet Implemented"), DefaultValue(false)]
        [ArgShortcut("-r")]
        public bool Repository { get; set; }

        [ArgDescription("Installs CRUD Controller with views"), DefaultValue(false)]
        [ArgShortcut("-mvc")]
        public bool Crud { get; set; }

    }
}
